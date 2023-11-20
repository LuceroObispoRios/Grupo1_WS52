<script>
import { HttpCommonService } from "@/services/http-common.service.js";
export default {
  name: "bookingCard",
  props: {
    bookingHistory: null,
  },
  data() {
    return {
      dialogVisible: false,
      message: {},
      submitted: false,
      chatHeader: '',
      bookingMessages: [],
      apiService: new HttpCommonService(),
      userId: '',
      userType: '',
      bookingToUpdate:[],
      chat: [
        {
          id: null,
          user: null,
          message: null,
          dateTime: null
        }
      ],
      reviewDialogVisible: false,
      reviewHeader: '',
      rating: '',
      commentText: '',
      reviewuser: new HttpCommonService(),
      workersApiService: new HttpCommonService(),
      workers: [],
      workerDialogVisible: false,
      editDialogVisible:false,
      workerHeader: '',
      editHeader:'',
      commentToWorker: '',
      workerToUpdate: [],
      bookingStatus:'',
      dateUpdate:'',
      timeUpdate:'',
      paymentUpdate:'',
      confirmDialogVisible: false,
    }
  },
  created() {
    //console.log('this route is: ',this.$route);

    // Obtiene el id del usuario
    this.userId = this.$route.params.id;
    //console.log('User id:', this.userId);

    // Obtiene el tipo de usuario
    const routeParts = this.$route.path.split('/');
    this.userType = routeParts[1];
    //console.log('User type:', this.userType);
    console.log("Bokking History: ", this.bookingHistory)
    // Obtiene todos los workers
    this.getAllWorkers();

  },
  methods: {
    openEditDialog() {
      this.editDialogVisible = true;
      this.editHeader = `Editar reserva de ${this.bookingHistory.hiredCompanyName}`;
      this.dateUpdate = this.bookingHistory.movingDate;
      this.timeUpdate = this.bookingHistory.movingTime;
      this.paymentUpdate = this.bookingHistory.payment;
    },
    openReEditDialog() {
      this.editDialogVisible = true;
      this.editHeader = `Reprogramar Reserva de ${this.bookingHistory.hiredCompanyName}`;
      this.dateUpdate = this.bookingHistory.movingDate;
      this.timeUpdate = this.bookingHistory.movingTime;
      this.paymentUpdate = this.bookingHistory.payment;
    },
    cancelEdit() {
      this.editDialogVisible=false;
    },
    saveEdit() {
      const updatedBooking = {};

      if (this.dateUpdate !== this.bookingHistory.movingDate) {
        updatedBooking.movingDate = this.dateUpdate;
      }

      if (this.timeUpdate !== this.bookingHistory.movingTime) {
        updatedBooking.movingTime = this.timeUpdate;
      }

      if (this.paymentUpdate !== this.bookingHistory.payment) {
        updatedBooking.payment = this.paymentUpdate;
      }
      if (Object.keys(updatedBooking).length===0){
        this.editDialogVisible = false;
        return;
      }
      if(this.bookingHistory.status === 'Programada'|| this.bookingHistory.status === 'Reprogramar'){
        updatedBooking.status = 'Reprogramar';
      } else {
        updatedBooking.status = 'Por programar';
      }
      // Realizar una copia del booking actual
      const bookingToUpdate = JSON.parse(JSON.stringify(this.bookingHistory));

      // Invertir el orden del chat
      if(this.bookingToUpdate.chats !== null)
        bookingToUpdate.chats = [...this.bookingHistory.chats].reverse();

      // Actualizar la copia con los nuevos datos
      Object.assign(bookingToUpdate, updatedBooking);

      console.log('Booking to update: ',bookingToUpdate);

      this.apiService.updateBooking(bookingToUpdate.id, bookingToUpdate)
          .then(response => {
            // Manejar la respuesta en consecuencia si es necesario
            console.log('Booking actualizado con éxito:', response);

            // Mostrar mensaje de edición de reserva completada
            this.mensajeEdicionReserva();

            this.editDialogVisible = false;
            // Actualizar bookingHistory con los nuevos datos
            Object.assign(this.bookingHistory, updatedBooking);
          }).catch(error => {
        console.error('Error al actualizar el booking:', error);
      });
    },

    mensajeEdicionReserva() {
      this.$toast.add({
        severity: "info",
        summary: "Edición de reserva completada",
        detail: "Esperando respuesta del cliente",
        life: 5000,
      });
    },

    openConfirmDialog() {
      this.confirmDialogVisible = true;
      this.editHeader = `Estos son los cambios realizados en la reserva`;
    },

    confirmChanges() {
      // Copiar la reserva actual
      const updatedBooking = JSON.parse(JSON.stringify(this.bookingHistory));
      updatedBooking.status = 'Programada';
      updatedBooking.chats = updatedBooking.chats.reverse();

      this.apiService.updateBooking(this.bookingHistory.id, updatedBooking)
          .then(response => {
            console.log('Estado de la reserva actualizado con éxito:', response);
            this.$toast.add({
              severity: 'success',
              summary: 'Cambios confirmados',
              detail: 'La reserva ha sido confirmada con éxito.',
              life: 5000,
            });
            this.confirmDialogVisible = false;
            // Actualizar bookingHistory con los nuevos datos
            Object.assign(this.bookingHistory, updatedBooking);
          })
          .catch(error => {
            console.error('Error al actualizar el estado de la reserva:', error);
          });
    },

    cancelConfirmDialog() {
      // Copiar la reserva actual
      const updatedBooking = JSON.parse(JSON.stringify(this.bookingHistory));
      updatedBooking.status = 'Cancelado';
      // Invertir el orden del chat
      updatedBooking.chats = updatedBooking.chats.reverse();

      this.apiService.updateBooking(this.bookingHistory.id, updatedBooking)
          .then(response => {
            console.log('Estado de la reserva actualizado con éxito:', response);
            this.$toast.add({
              severity: 'success',
              summary: 'Reserva cancelada',
              detail: 'La reserva ha sido cancelada con éxito.',
              life: 5000,
            });
            this.confirmDialogVisible = false;
            // Actualizar bookingHistory con los nuevos datos
            Object.assign(this.bookingHistory, updatedBooking);
          })
          .catch(error => {
            console.error('Error al actualizar el estado de la reserva:', error);
          });
    },

    FinishBooking() {
      // Copiar la reserva actual
      const updatedBooking = JSON.parse(JSON.stringify(this.bookingHistory));
      updatedBooking.status = 'Finalizado';
      updatedBooking.chats = updatedBooking.chats.reverse();
      this.apiService.updateBooking(this.bookingHistory.id, updatedBooking)
          .then(response => {
            console.log('Estado de la reserva actualizado con éxito:', response);
            this.$toast.add({
              severity: 'success',
              summary: 'Reserva finalizada',
              detail: 'La reserva ha sido finalizada con éxito.',
              life: 5000,
            });
            this.confirmDialogVisible = false;
            // Actualizar bookingHistory con los nuevos datos
            Object.assign(this.bookingHistory, updatedBooking);
          })
          .catch(error => {
            console.error('Error al actualizar el estado de la reserva:', error);
          });
    },

    openChat() {
      this.bookingMessages = this.bookingHistory.chats;
      this.dialogVisible = true;
      this.chatHeader = `Chat con ${this.bookingHistory.hiredCompanyName}`;
    },

    hideDialog() {
      this.dialogVisible = false;
      this.submitted = false;
    },

    sendMessage(){
      if (this.message.content.trim() !== '') {
        console.log('new message: ', this.message);

        const newMessage = {
          user: this.userType,
          message: this.message.content,
          dateTime: new Date().toISOString(),
        };
        console.log('newMessage antes del unshift: ', newMessage);
        this.bookingMessages.unshift(newMessage);
        console.log('messages saved: ', this.bookingMessages);
        this.message.content = '';
        this.bookingHistory.chats = this.bookingMessages;
        this.bookingToUpdate = JSON.parse(JSON.stringify(this.bookingHistory));
        this.bookingToUpdate.chats.reverse();
        console.log('bookingToUpdate: ', this.bookingToUpdate);

        // // esto ya no iría
        // this.apiService.updateBooking(this.bookingToUpdate.id, this.bookingToUpdate)
        //     .then(response => {
        //       // Manejar la respuesta en consecuencia si es necesario
        //       console.log('Booking actualizado con éxito:', response);
        //     }).catch(error => {
        //   // Manejar el error si ocurre
        //   console.error('Error al actualizar el booking:', error);
        // });
        this.apiService.createMessage(this.bookingHistory.id, newMessage)
            .then(response => {
              console.log('Mensaje creado con éxito:', response);
            })
            .catch(error => {
              console.error('Error al crear el mensaje:', error);
            });

        this.message.content = '';
      }
      //
    },

    cancelBooking(){
      this.bookingHistory.status = 'Cancelado';
      console.log('bookingHistory: ', this.bookingHistory);
      this.bookingToUpdate = JSON.parse(JSON.stringify(this.bookingHistory));
      if(this.bookingToUpdate.chats !== null)
        this.bookingToUpdate.chats.reverse();

      console.log('bookingToUpdate: ', this.bookingToUpdate);

      this.apiService.updateBooking(this.bookingToUpdate.id, this.bookingToUpdate)
          .then(response => {
            console.log('Booking actualizado con éxito:', response);
            this.$toast.add({severity:'success', summary: 'Reserva cancelada', detail:'Tu reserva del servicio ha sido cancelada.', life: 3000});
          }).catch(error => {
            console.error('Error al actualizar el booking:', error);
            this.$toast.add({severity:'error', summary: 'Error', detail:'Hubo un error al cancelar la reserva. Por favor, inténtalo de nuevo.', life: 3000});
      });
    },

    // Sección para realizar comentarios a los trabajadores
    getAllWorkers(){
      if(!this.bookingHistory.workers){
        console.log("no hubo workers para booking ", this.bookingHistory.id)
      }
      else {
        //console.log("Workers for id",this.bookingHistory.id, " : ", this.bookingHistory.workers)

        this.bookingHistory.workers.forEach((workerId, index) =>{
          this.apiService.getWorkerById(workerId) //id?
              .then(response => {
                //console.log('Response:', response);
                this.workers.push(response.data);
              })
              .catch(error => {
                console.error('Error al obtener el worker:', error);
              });
        });

      }
    },

    openWorkerDialog(worker) {
      this.workerToUpdate = worker;
      this.workerDialogVisible = true;
      this.workerHeader = `Comentarios sobre el trabajador:`;
      this.commentToWorker = '';
      console.log('worker commentaries: ', this.workerToUpdate.comments);
    },

    commentToWorkers() {
      if (this.commentToWorker.trim() !== '') {
        //console.log('workerComment: ', this.commentToWorker);

      const newComment = {
          commentText: this.commentToWorker,
            bookingId: this.bookingHistory.id,
      };

        console.log('Nuevo comentario:', newComment);

      this.workerToUpdate.comments.push(newComment);
      this.workerToUpdate = JSON.parse(JSON.stringify(this.workerToUpdate));
      //console.log('workerToUpdate: ', this.workerToUpdate);

      this.workersApiService.updateWorkerComment(this.workerToUpdate.id, this.workerToUpdate)
          .then(() => {
            this.workerDialogVisible= false;
            this.$toast.add({severity:'success', summary: 'Comentario enviado', detail:'Tu comentario ha sido enviado con éxito.', life: 3000});
            //console.log('Comentario enviado con éxito:', response);
          })
          .catch(error => {
            this.$toast.add({severity:'error', summary: 'Error', detail:'Hubo un error al enviar tu comentario. Por favor, inténtalo de nuevo.', life: 3000});
            console.error('Error al actualizar los comentarios', error);
          });
        this.commentToWorker = '';
      }
    },

    cancelCommentToWorker() {
      this.workerDialogVisible = false;
      this.commentToWorker = '';
    },

    openReview() {
      this.reviewDialogVisible = true;
      this.reviewHeader = `Reseña de ${this.bookingHistory.hiredCompanyName}`;
      this.rating = '';
      this.comment = '';
    },

    cancelReview() {
      this.reviewDialogVisible = false; // Ocultamos el diálogo de reseñas
    },

    async addReviewAndUpdateAverage(companyId, review) {
      try {
        // Agrega la nueva reseña
        const response = await this.reviewuser.addReview(companyId,review);

        // Obtiene todas las reseñas de la compañía
        const allReviews = await this.reviewuser.getReviews();
        const companyReviews = allReviews.data.filter(r => r.companyId === companyId);

        let averageRating = 0;
        // Verifica si hay reseñas antes de calcular el promedio
        if (companyReviews.length > 0) {
          // Calcula la calificación promedio
          const totalRating = companyReviews.reduce((total, review) => total + review.rating, 0);
          averageRating = Math.round(totalRating / companyReviews.length);
        }

        // Actualiza la calificación promedio en la base de datos
        await this.reviewuser.updateCompany(companyId, { averageRating });

        return response;
      } catch (error) {
        console.error(error);
      }
    },

    submitReview() {
      // Comprueba si se ha seleccionado una calificación
      if (!this.rating) {
        this.$toast.add({severity:'error', summary: 'Error', detail:'Por favor, selecciona una calificación antes de enviar tu reseña.', life: 3000});
        return;
      }

      // Comprueba si el comentario es demasiado corto
      if (this.comment.length < 10) { // Ajusta este número al mínimo de caracteres que desees
        this.$toast.add({severity:'error', summary: 'Error', detail:'Tu comentario es demasiado corto. Por favor, escribe un comentario más detallado.', life: 3000});
        return;
      }
      // Crea un objeto de reseña
      const review = {
        rating: this.rating,
        comment: this.comment,
      };


      this.addReviewAndUpdateAverage(this.bookingHistory.idCompany, review)
          .then(() => {
            this.reviewDialogVisible = false;
            this.$toast.add({severity:'success', summary: 'Reseña enviada', detail:'Tu reseña ha sido enviada con éxito.', life: 3000});
          })
          .catch(error => {
            console.error(error);
            this.$toast.add({severity:'error', summary: 'Error', detail:'Hubo un error al enviar tu reseña. Por favor, inténtalo de nuevo.', life: 3000});
          });
    }
  },
}

</script>

<template>
  <div class="card">
    <pv-panel unstyled class="mr-3 ml-3">
<!--      --------------------------- Header -------------------------------------------->
      <template #header>
        <div class="header">{{bookingHistory.counter}}. Reserva {{bookingHistory.bookingDate}}</div>
      </template>
      <div class="panel-content">
        <div class="responsive p-3 flex flex-wrap">
          <div class="panel-left flex flex-wrap">
            <!--------------------------------->
            <div class="col w-20rem">
              <div class="mt-2"><span class="font-bold">Fecha de mudanza: </span>{{bookingHistory.movingDate}}</div>
              <div class="mt-2"><span class="font-bold">Hora: </span>{{bookingHistory.movingTime}}</div>
              <div class="mt-2"><span class="font-bold">Estado de reserva: </span>{{bookingHistory.status}}</div>
              <div class="mt-3"><span class="font-bold">Dirección de recojo: </span>{{bookingHistory.pickupAddress}}</div>
              <div class="mt-1"><span class="mt-3 pt-7 font-bold">Dirección de entrega: </span>{{bookingHistory.destinationAddress}}</div>
              <div class="flex ml-2 mt-3">
                <div class="review">
                  <pv-button v-if="bookingHistory.status === 'Finalizado' && userType === 'client'" class="btn-chat hover:bg-gray-300 review-button" @click="openReview">
                    <div class="flex items-center">
                      <i class="pi pi-star font-bold mr-1"></i>
                      <span>Realizar Reseña</span>
                    </div>
                  </pv-button>
                </div>
              </div>
            </div>
            <!--------------------------------->
            <div class="col">
              <div class="mt-3"><span class="font-bold">Pago total: </span>S/.{{bookingHistory.payment}}</div>
              <div class="mt-2"><span class="font-bold">Empresa contratada: </span>{{bookingHistory.hiredCompanyName}}</div>
              <div class="mt-2"><span class="font-bold">Trabajadores: </span></div>
              <div v-for="(worker, index) in workers" :key="index" class="mb-2">
                <i class="pi pi-user mr-2 mt-2" style="color: #FDAE39"></i>
                {{worker.firstName}} {{worker.lastName}}
                <pv-button v-if="(bookingHistory.status ==='Finalizado') && userType ==='client'" class="bg-blue-500 font-bold hover:bg-gray-300 p-2 pl-3 pr-3 mt-2 ml-3" @click="openWorkerDialog(worker)">
                  <p class="m-0 text-xs">Comentar</p>
                </pv-button>
                <div v-if="bookingHistory.status ==='Finalizado'&& userType === 'company'">
                  <div v-for="(comment, ind) in worker.comments" :key="ind">
                    <div v-if="comment.bookingId === bookingHistory.id">
                      <p class="m-0 text-xs ml-5 font-italic">~"{{comment.comment}}"</p>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <!--------------------------------->
          </div>
          <div class="panel-right bg-white ml-8">
            <img :src="bookingHistory.hiredCompanyLogo" :alt="bookingHistory.hiredCompanyName"
                 class="lg:border-round" width="150" height="150">
          </div>
        </div>
        <!------------------------------------------  Buttons ------------------------------------------->
        <div class="flex-container">
          <div class="mr-2 mb-2" v-if="(bookingHistory.status !=='Finalizado' || bookingHistory.status !=='Cancelado')">
            <pv-button v-if="(bookingHistory.status !=='Finalizado' && bookingHistory.status !=='Cancelado')" class="btn-chat font-bold hover:bg-gray-300 p-2 pl-3 pr-5" @click="openChat">
              <div class="pi pi-comment font-bold mr-2"></div><p class="m-0">Chat</p>
            </pv-button>
          </div>
          <div>
            <pv-button v-if="(bookingHistory.status === 'Iniciar Proceso' || bookingHistory.status === 'Por programar') && userType === 'company'" class="btn-chat hover:bg-gray-300 review-button" @click="openEditDialog">
              <div class="pi pi-pencil font-bold mr-2"></div><p class="m-0">Editar detalles reserva</p>
            </pv-button>
          </div>
          <div>
            <pv-button v-if="(bookingHistory.status === 'En curso' || bookingHistory.status === 'Reprogramar' || bookingHistory.status === 'Programada') && userType === 'company'" class="btn-chat hover:bg-gray-300 review-button" @click="openReEditDialog">
              <div class="pi pi-cog font-bold mr-2"></div><p class="m-0">Reprogramar reserva</p>
            </pv-button>
          </div>
          <div>
            <pv-button v-if="(bookingHistory.status === 'Por programar' || bookingHistory.status === 'Reprogramar') && this.userType === 'client'" class="btn-chat hover:bg-gray-300 review-button" @click="openConfirmDialog">
              <div class="flex items-center">
                <span>Ver cambios en la reserva</span>
              </div>
            </pv-button>
          </div>
          <div class="mb-2">
            <pv-button v-if="bookingHistory.status === 'Programada' && bookingHistory.payment > 0 " class="bg-orange-800 font-bold hover:bg-gray-300 p-2 pl-3 pr-3" @click="FinishBooking">
              <div class="pi pi-times font-bold mr-2"></div><p class="m-0">Finalizar Reserva</p>
            </pv-button>
          </div>
          <div class="mb-2">
            <pv-button v-if="bookingHistory.status !== 'Cancelado' && bookingHistory.status !== 'Finalizado'" class="bg-red-500 font-bold hover:bg-gray-300 p-2 pl-3 pr-3" @click="cancelBooking">
              <div class="pi pi-times font-bold mr-2"></div><p class="m-0">Cancelar reserva</p>
            </pv-button>
          </div>
        </div>
      </div>
    </pv-panel>

    <!------------------------------------------  Dialogs ------------------------------------------->
    <!--------------------  CHAT -------------------------->
    <div>
      <pv-dialog
          v-model:visible="dialogVisible"
          :style="{ width: '450px' }"
          :header="chatHeader"
          :modal="true"
          class="p-fluid">
        <div class="flex align-content-center justify-content-center bg-white">
          <img :src="bookingHistory.hiredCompanyLogo" :alt="bookingHistory.hiredCompanyName"
               class="lg:border-round" width="150" height="150">
        </div>
        <div ref="scrollPanel"
             style="overflow-y: scroll; height: 200px; display: flex; flex-direction: column-reverse; margin-bottom: 5px;">
          <div v-for="(message, index) in bookingMessages" :key="index">
            <div class="message-card bg-gray-200 mt-0 pt-1 pb-1 pl-2 pr-2 mb-1 pb-0 border-round-sm">
              <div>
                <div v-if="message.user === 'client'">
                  <p class="p-0 m-0 font-bold">Cliente</p>
                </div>
                <div v-else-if="message.user === 'company'">
                  <p class="p-0 m-0 font-bold">Empresa</p>
                </div>
                <p class="p-0 m-0 text-gray-500 dateTime">{{message.dateTime}}</p>
                <p class="p-0 m-0">{{message.message}}</p>
              </div>
            </div>
          </div>
        </div>

        <div class="field">
        <span class="p-float-label">
          <pv-textarea
              id="content"
              v-model="message.content"
              placeholder="Escriba aquí su mensaje..."
              autofocus
              required="false"
              rows="5"
              cols="20"
          />
          <label for="description"></label>
        </span>
        </div>
        <template #footer>
          <pv-button
              :label="'cancelar'.toUpperCase()"
              icon="pi pi-times"
              class="p-button-text"
              @click="hideDialog"/>
          <pv-button
              :label="'Enviar'.toUpperCase()"
              icon="pi pi-check"
              class="p-button-text" @click="sendMessage"/>
        </template>

      </pv-dialog>
    </div>
    <!--------------------  REVIEWS -------------------------->
    <div class="reviews">
      <pv-dialog
          v-model:visible="reviewDialogVisible"
          :style="{ width: '450px' }"
          :header="reviewHeader"
          :modal="true"
          class="p-fluid"
      >
        <div class="flex align-content-center justify-content-center bg-white">
          <img :src="bookingHistory.hiredCompanyLogo" :alt="bookingHistory.hiredCompanyName" class="lg:border-round" width="150" height="150">
        </div>

        <div class="field">
        <span class="p-float-label">
          <pv-textarea
              id="content"
              v-model="comment"
              placeholder="Escriba aquí su reseña..."
              autofocus
              required="false"
              rows="5"
              cols="20"
          />
          <label for="description"></label>
        </span>
        </div>

        <div class="field">
          <label for="rating">Calificación</label>
          <Rating v-model="rating" :cancel="false" />
        </div>

        <template #footer>
          <pv-button
              :label="'Cancelar'.toUpperCase()"
              icon="pi pi-times"
              class="p-button-text"
              @click="cancelReview"
          />
          <pv-button :label="'Enviar'.toUpperCase()" icon="pi pi-check" class="p-button-text" @click="submitReview" />
        </template>
      </pv-dialog>
    </div>

    <!-------------------- COMMENTS -------------------------->
    <div>
      <pv-dialog
          v-model:visible="workerDialogVisible"
          :style="{ width: '450px' }"
          :header="workerHeader"
          :modal="true"
          class="p-fluid">
        <div class="flex align-content-center justify-content-left mb-3 font-semibold">
          <i class="pi pi-user mr-2 ml-4" style="color: #FDAE39"></i>
          {{this.workerToUpdate.firstName}} {{workerToUpdate.lastName}}
        </div>

        <div class="field">
          <span class="p-float-label">
            <pv-textarea
                id="content"
                v-model="commentToWorker"
                placeholder="Escriba aquí su comentario..."
                autofocus
                required="false"
                rows="5"
                cols="20"/>
            <label for="description"></label>
          </span>
        </div>
        <template #footer>
          <pv-button
              :label="'Cancelar'.toUpperCase()"
              icon="pi pi-times"
              class="p-button-text"
              @click="cancelCommentToWorker"
          />
          <pv-button :label="'Enviar'.toUpperCase()" icon="pi pi-check" class="p-button-text" @click="commentToWorkers()"/>
        </template>
      </pv-dialog>
    </div>
    <!-------------------- EDIT -------------------------->
    <div>
      <pv-dialog
          v-model:visible="editDialogVisible"
          :style="{ width: '450px' }"
          :header="editHeader"
          :modal="true"
          class="p-fluid">

        <div class="mt-2"><span class="font-bold">Fecha de mudanza actual: </span>{{bookingHistory.movingDate}}</div>
        <div class="field">
          <span class="p-float-label">
            <pv-input-text
                id="content"
                v-model="dateUpdate"
                placeholder="Ex. 2023-10-19"
                autofocus
                required="false"
                rows="5"
                cols="20"/>
            <label for="description"></label>
          </span>
        </div>

        <div class="mt-2"><span class="font-bold">Hora actual: </span>{{bookingHistory.movingTime}}</div>
        <div class="field">
          <span class="p-float-label">
            <pv-input-text
                id="content"
                v-model="timeUpdate"
                placeholder="Ex. 14:00"
                autofocus
                required="false"
                rows="5"
                cols="20"/>
            <label for="description"></label>
          </span>
        </div>

        <div class="mt-3"><span class="font-bold">Pago total actual: </span>S/.{{bookingHistory.payment.totalAmount}}</div>
        <div class="field">
          <span class="p-float-label">
            <pv-input-text
                id="content"
                v-model="paymentUpdate"
                placeholder="Ex. S/200"
                autofocus
                required="false"
                rows="5"
                cols="20"/>
            <label for="description"></label>
          </span>
        </div>


        <template #footer>
          <pv-button
              :label="'Cancelar'.toUpperCase()"
              icon="pi pi-times"
              class="p-button-text"
              @click="cancelEdit"
          />
          <pv-button :label="'Enviar'.toUpperCase()" icon="pi pi-check" class="p-button-text" @click="saveEdit()"/>
        </template>

      </pv-dialog>
    </div>
    <!-------------------- confirmDialogVisible -------------------------->
    <div>
      <pv-dialog
          v-model:visible="confirmDialogVisible"
          :style="{ width: '450px' }"
          :header="editHeader"
          :modal="true"
          class="p-fluid">

        <div class="mt-2"><span class="font-bold">Fecha de mudanza actual: </span>{{bookingHistory.movingDate}}</div>
        <div class="mt-2"><span class="font-bold">Hora actual: </span>{{bookingHistory.movingTime}}</div>
        <div class="mt-3"><span class="font-bold">Pago total actual: </span>S/.{{bookingHistory.payment}}</div>

        <template #footer>
          <pv-button
              :label="'Rechazar'.toUpperCase()"
              icon="pi pi-times"
              class="p-button-text"
              @click="cancelConfirmDialog"
          />
          <pv-button :label="'Confirmar'.toUpperCase()" icon="pi pi-check" class="p-button-text" @click="confirmChanges()"/>
        </template>

      </pv-dialog>
    </div>

  </div>


</template>

<style scoped>

.dateTime {
  font-size: 12px;
}
.card {
  margin-top: 20px;
  font-family: sans-serif;
}

.header {
  font-weight: bold;
  font-size: 18px;
  background-color: #D9D9D9;
  padding: 10px;
  border-radius: 5px 5px 0 0;
}

.panel-content {
  padding-bottom: 20px;
  background-color: #FFF9F9;
  border-radius: 0 0 5px 5px;
}

.responsive {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.btn {
  display: flex;
  justify-content: flex-start;
}
.review-button {
  height: 2.5rem; /* Ajusta altura del boton */
}


.review-button .flex {
  align-items: center;
}
.panel-left {
  flex: 1;
  font-size: 15px;
}

.panel-right {
  margin-left: 20px;
}
.btn-chat {
  font-family: sans-serif;
  background-color: #FDAE39;
  padding: 0 25px;
}
.btn-chat:hover {
  background-color: #FDBE59;
}
.flex-container {
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  align-items: flex-start;
}

.flex-container > div {
  margin-bottom: 10px;
}
</style>
