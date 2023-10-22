<script>
import { cargaSinEstresApiService } from "@/company-search/services/cargaSinEstres-api.service";
export default {
  name: "booking-card",
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
      apiService: new cargaSinEstresApiService(),
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
      comment: '',
      reviewuser: new cargaSinEstresApiService()

    }
  },
  created() {
    console.log('this route is: ',this.$route);

    // Obtiene el id del usuario
    this.userId = this.$route.params.id;
    console.log('User id:', this.userId);

    // Obtiene el tipo de usuario
    const routeParts = this.$route.path.split('/');
    this.userType = routeParts[1];
    console.log('User type:', this.userType);
  },
  methods: {
    openChat() {
      this.bookingMessages = this.bookingHistory.chat;
      this.dialogVisible = true;
      this.chatHeader = `Chat con ${this.bookingHistory.hiredCompany.name}`;
      console.log(`this.dialogVisible: ${this.dialogVisible}`);
      console.log('bookingMessages: ', this.bookingMessages);
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
          dateTime: new Date().toLocaleString(),
        };

        this.bookingMessages.unshift(newMessage);
        console.log('messages saved: ', this.bookingMessages);
        this.message = {};
        this.bookingHistory.chat = this.bookingMessages;
        console.log('bookingHistory: ', this.bookingHistory);
        this.bookingToUpdate = JSON.parse(JSON.stringify(this.bookingHistory));
        this.bookingToUpdate.chat.reverse();
        console.log('bookingToUpdate: ', this.bookingToUpdate);
        // console.log('bookingToUpdate nuevo: ', this.bookingToUpdate);
        // console.log('verificar si se cambia:', this.bookingHistory.chat);

        this.apiService.updateBooking(this.bookingToUpdate.id, this.bookingToUpdate)
            .then(response => {
              // Manejar la respuesta en consecuencia si es necesario
              console.log('Booking actualizado con éxito:', response);
            }).catch(error => {
          // Manejar el error si ocurre
          console.error('Error al actualizar el booking:', error);
        });

        // console.log('messages saved: ', this.bookingMessages);
        // this.bookingHistory.chat.id ='';
        // this.bookingHistory.chat.user = this.userType;
        // this.bookingHistory.chat.message = this.bookingMessages.reverse();
        // this.bookingHistory.chat.dateTime = new Date().toLocaleString();
        // console.log('bookingHistory: ', this.bookingHistory);

      }
    },
    cancelBooking(){
      this.bookingHistory.status = 'Cancelado';
      this.bookingToUpdate = JSON.parse(JSON.stringify(this.bookingHistory));
      this.bookingToUpdate.chat.reverse();
      console.log('bookingToUpdate: ', this.bookingToUpdate);
      this.apiService.updateBooking(this.bookingToUpdate.id, this.bookingToUpdate)
          .then(response => {
            // Manejar la respuesta en consecuencia si es necesario
            console.log('Booking actualizado con éxito:', response);
          }).catch(error => {
        // Manejar el error si ocurre
        console.error('Error al actualizar el booking:', error);
      });
    },
    openReview() {
      this.reviewDialogVisible = true;
      this.reviewHeader = `Reseña de ${this.bookingHistory.hiredCompany.name}`;
      this.rating = '';
      this.comment = '';
    },
    cancelReview() {
      this.reviewDialogVisible = false; // Ocultamos el diálogo de reseñas
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

      this.reviewuser.addReview(this.bookingHistory.idCompany, review)
          .then(() => {
            this.reviewDialogVisible = false;
            this.$toast.add({severity:'success', summary: 'Reseña enviada', detail:'Tu reseña ha sido enviada con éxito.', life: 3000});
          })
          .catch(error => {
            console.error(error);
            this.$toast.add({severity:'error', summary: 'Error', detail:'Hubo un error al enviar tu reseña. Por favor, inténtalo de nuevo.', life: 3000});
          });
    }
  }
}

</script>

<template>
  <div class="card">
    <pv-panel unstyled class="mr-3 ml-3">
      <template #header>
        <div class="header">{{bookingHistory.counter}}. Reserva {{bookingHistory.bookingDate}}</div>

      </template>
      <div class="panel-content">
        <div class="responsive p-3 flex flex-wrap">
          <div class="panel-left flex flex-wrap">
            <div class="col w-20rem">
              <div class="mt-2"><span class="font-bold">Fecha de mudanza: </span>{{bookingHistory.movingDate}}</div>
              <div class="mt-2"><span class="font-bold">Estado de reserva: </span>{{bookingHistory.status}}</div>
              <div class="mt-3"><span class="font-bold">Dirección de recojo: </span>{{bookingHistory.pickupAddress}}</div>
              <div class="mt-1"><span class="mt-3 pt-7 font-bold">Dirección de entrega: </span>{{bookingHistory.destinationAddress}}</div>
              <div class="flex ml-2 mt-3">
                <div class="review">
                  <pv-button v-if="bookingHistory.status === 'Finalizado'" class="btn-chat hover:bg-gray-300" @click="openReview">
                    <div class="pi pi-star font-bold"></div>&nbsp;<p>Realizar Reseña</p>
                  </pv-button>
                </div>
              </div>
            </div>
            <div class="col">
              <div class="mt-3"><span class="font-bold">Pago total: </span>S/.{{bookingHistory.payment.totalAmount}}</div>
              <div class="mt-2"><span class="font-bold">Empresa contratada: </span>{{bookingHistory.hiredCompany.name}}</div>

            </div>
          </div>
          <div class="panel-right bg-white ml-8">
            <img :src="bookingHistory.hiredCompany.logo" :alt="bookingHistory.hiredCompany.name"
                 class="lg:border-round" width="150" height="150">
          </div>

        </div>
        <div class="flex flex-wrap ml-3">
          <div class="mr-2 mb-2">
            <pv-button v-if="bookingHistory.status ==='En curso'" class="btn-chat font-bold hover:bg-gray-300 p-2 pl-3 pr-5" @click="openChat">
              <div class="pi pi-comment font-bold mr-2"></div><p class="m-0">Chat</p>
            </pv-button>
          </div>
          <div class="m-3"></div>
          <div class="mb-2">
            <pv-button v-if="bookingHistory.status ==='En curso'" class="bg-red-500 font-bold hover:bg-gray-300 p-2 pl-3 pr-3"  @click="cancelBooking">
              <div class="pi pi-times font-bold mr-2"></div><p class="m-0">Cancelar reserva</p>
            </pv-button>
          </div>
        </div>
      </div>
    </pv-panel>
    <div>
      <pv-dialog
          v-model:visible="dialogVisible"
          :style="{ width: '450px' }"
          :header="chatHeader"
          :modal="true"
          class="p-fluid">
        <div class="flex align-content-center justify-content-center bg-white">
          <img :src="bookingHistory.hiredCompany.logo" :alt="bookingHistory.hiredCompany.name"
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
                  <!--                    Se muestra el nombre de la empresa-->
                  <!--                    <p class="p-0 m-0 font-bold">Empresa {{bookingHistory.hiredCompany.name}}</p>-->
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
    <div class="reviews">
      <pv-dialog
          v-model:visible="reviewDialogVisible"
          :style="{ width: '450px' }"
          :header="reviewHeader"
          :modal="true"
          class="p-fluid"
      >
        <div class="flex align-content-center justify-content-center bg-white">
          <img :src="bookingHistory.hiredCompany.logo" :alt="bookingHistory.hiredCompany.name" class="lg:border-round" width="150" height="150">
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

</style>
