<script>
import { HttpCommonService } from "@/services/http-common.service.js";
import BookingCard from "@/bookingHistory/components/bookingCard.component.vue";
export default {
  name: "bookingList",
  components: { BookingCard },
  data() {
    return {
      bookingList: [],
      errors: [],
      bookingApiService: new HttpCommonService(),
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
    console.log('Booking history: ', this.bookingList);
  },
  methods: {
    getAllBookingHistory(id){
      if(this.userType === 'client'){
        this.bookingApiService.getBookingsByClient(id)
            .then((response) => {
              this.bookingList = response.data;
              console.log('get response: ', response.data);
              console.log('total bookings client: ', this.bookingList);
              this.bookingList.forEach((booking, index) => {
                booking.counter = index + 1;
                this.bookingApiService.getById(booking.idCompany)
                    .then((response) => {
                      booking.hiredCompanyName = response.data.name;
                      booking.hiredCompanyLogo = response.data.photo;
                    })
                    .catch((error) => {
                      this.errors.push(error);
                    });
              });
              this.bookingList.reverse();
              this.bookingList.forEach((booking, index) => {
                booking.chats = booking.chats.reverse();
              });
              console.log('data client reverse with counter: ', this.bookingList);
            })
            .catch((error) => {
              this.errors.push(error);
            });
      } else if (this.userType === 'company'){
        this.bookingApiService.getBookingsByCompany(id)
            .then((response) => {
              this.bookingList = response.data;
              console.log('get response: ', response.data);
              console.log('data company: ', this.bookingList);
              this.bookingList.forEach((booking, index) => {
                booking.counter = index + 1;
                this.bookingApiService.getById(booking.idCompany)
                    .then((response) => {
                      booking.hiredCompanyName = response.data.name;
                      booking.hiredCompanyLogo = response.data.photo;
                    })
                    .catch((error) => {
                      this.errors.push(error);
                    });
              });
              this.bookingList.reverse();
              this.bookingList.forEach((booking, index) => {
                booking.chats = booking.chats.reverse();
              });
              console.log('data company reverse with counter: ', this.bookingList);
            })
            .catch((error) => {
              this.errors.push(error);
            });
      }
    }
  }
};
</script>

<template>

  <div><h1 class="title flex justify-content-center">Historial de Reservas</h1></div>
  <div v-for="bookingHistory in bookingList" :key="bookingHistory.id">
    <bookingCard :bookingHistory="bookingHistory"></bookingCard>
  </div>
</template>

<style scoped>
.title {
  color: #FDAE39;
  font-family: sans-serif;
}
</style>
