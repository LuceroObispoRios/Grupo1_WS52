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
      bookingApiService: new cargaSinEstresApiService()
    };
  },
  created() {
    this.getAllBookingHistory();
  },
  methods: {
    getAllBookingHistory(){
      this.bookingApiService.getAllBookings()
          .then((response) => {
            this.bookingList = response.data;
            this.bookingList.reverse();
            console.log(this.bookingList);
          })
          .catch((error) => {
            this.errors.push(error);
          });
    }
  }
};
</script>

<template>
  <div>
    <toolbar-client></toolbar-client>
  </div>

  <!-- <div>
    <router-link to="/home" custom v-slot="{ navigate, href }" key="Home">
      <div><pv-button class="pi pi-arrow-left text-black-alpha-90 mt-3 hover:bg-yellow-200"
                      rounded outlined aria-label="Favorite" :href="href" @click="navigate" /></div>
    </router-link>
  </div> -->
  <div><h1 class="title flex justify-content-center">Historial de Reservas</h1></div>
  <div v-for="bookingHistory in bookingList">
    <booking-card :bookingHistory="bookingHistory"></booking-card>
  </div>
</template>

<style scoped>
.title {
  color: #FDAE39;
  font-family: sans-serif;
}
</style>
  
