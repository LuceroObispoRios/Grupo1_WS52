<script>
import { cargaSinEstresApiService } from "@/company-search/services/cargaSinEstres-api.service";
import BookingCard from "@/bookingHistory/pages/booking-card.component.vue";
import toolbarClient from "@/public/pages/toolbar-client.component.vue";
export default {
  name: "booking-list",
  components: { BookingCard, toolbarClient},
  data() {
    return {
      bookingList: [],
      errors: [],
      bookingApiService: new cargaSinEstresApiService(),
      userId: '',
      userType: '',
    };
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

    this.getAllBookingHistory(this.userId);
    this.getAllMessages();
  },
  methods: {
    getAllBookingHistory(id){
      if(this.userType === 'client'){
        this.bookingApiService.getBookingsByClient(id)
            .then((response) => {
              this.bookingList = response.data
              console.log('data client: ', this.bookingList);
              this.bookingList.forEach((booking, index) => {
                booking.counter = index + 1;
              });
              this.bookingList.reverse();
              console.log('data client reverse with counter: ', this.bookingList);
              this.bookingList.forEach((booking, index) => {
                booking.chat = booking.chat.reverse();
              });
            })
            .catch((error) => {
              this.errors.push(error);
            });
      } else if (this.userType === 'company'){
        this.bookingApiService.getBookingsByCompany(id)
            .then((response) => {
              this.bookingList = response.data;
              console.log('data company: ', this.bookingList);
              this.bookingList.forEach((booking, index) => {
                booking.counter = index + 1;
              });
              this.bookingList.reverse();
              console.log('data company reverse with counter: ', this.bookingList);

              // this.bookingApiService.getMessagesByBooking(booking.id)
              //     .then((response) => {
              //       this.messages = response.data;
              //       console.log('messages: ', this.messages);
              //     })
              //     .catch((error) => {
              //       this.errors.push(error);
              //     });

            })
            .catch((error) => {
              this.errors.push(error);
            });
      }
    },
    getAllMessages(){
      this.bookingApiService.getMessages()
          .then((response) => {
            this.messages = response.data;
            console.log('All messages: ',this.messages);
          })
          .catch((error) => {
            this.errors.push(error);
          });
    }
  }
};
</script>

<template>

  <!-- <div>
    <router-link to="/home" custom v-slot="{ navigate, href }" key="Home">
      <div><pv-button class="pi pi-arrow-left text-black-alpha-90 mt-3 hover:bg-yellow-200"
                      rounded outlined aria-label="Favorite" :href="href" @click="navigate" /></div>
    </router-link>
  </div> -->
  <div><h1 class="title flex justify-content-center">Historial de Reservas</h1></div>
  <div v-for="bookingHistory in bookingList" :key="bookingHistory.id">
    <booking-card :bookingHistory="bookingHistory"></booking-card>
  </div>
</template>

<style scoped>
.title {
  color: #FDAE39;
  font-family: sans-serif;
}
</style>
