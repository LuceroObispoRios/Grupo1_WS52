<script>
import { cargaSinEstresApiService } from "../services/cargaSinEstres-api.service";

export default {
  name: 'company-detail',
  data() {
    return {
      id: null,
      companyData: null,
      reservation:{
        id: null,
        idCompany: null,
        services: null,
      },
      cargaSinEstres_service: null,
    };
  },
  created() {
    const companyData = this.$route.query.companyData;
    this.id = this.$route.params.id;
    if (companyData) {
      this.company = JSON.parse(companyData);
    }
  },
  methods:{
    submitForm(){
      this.reservation.idCompany=this.company.id;
      this.addReservation();
    },
    addReservation(){
      this.cargaSinEstres_service = new cargaSinEstresApiService();
      this.cargaSinEstres_service.createReservation(this.reservation)
          .then((response) => {
            console.log("Reservation:");
            console.log(response.data);
            this.$data.reservation = response.data;
      });
    }
  }
};
</script>

<template>
  <!-- INFORMACION DE LA EMPRESA -->
  <pv-card class="custom-card">
    <template #title>
      <img :src="company.photo" alt="Logo Company" class="company-logo">
    </template>

    <template #content>
      <div class="company-info">
        <h2 class="company-name">{{ company.name }}</h2>
        <p class="company-type">Empresa</p>
      </div>
      <div class="company-services">
        <p class="label">Servicios: </p>
        <p class="value">{{ company.services }}</p>
      </div>
    </template>
  </pv-card>

  <!-- FORMULARIO PARA AGREGAR RESERVA -->
  <br>
  <div class="custom-addReservation">
    <pv-panel header="Reservar" toggleable>
      <form @submit.prevent="submitForm" id="add-reservation" class="reservation-info">
        <label for="services">Servicios:</label><br>
        <input type="text" v-model="reservation.services" id="services"  required><br>
        <button type="submit" >Realizar reserva</button>
      </form>
    </pv-panel>
  </div>


</template>



<style scoped>

/* CARD */

.custom-card {
  width: 400px;
  margin: 50px auto;
  background-color: #ffffff;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
  border-radius: 8px;
  padding: 20px;
  text-align: left;
}

.custom-card mat-card-title {
  font-size: 24px;
  font-weight: bold;
  margin: 10px 0;
}

.custom-card img {
  width: 300px;
  height: auto;
  margin: 0 auto;
  border-radius: 15px;
}

.custom-card mat-card-content{
  margin-top: 30px;
}

.company-type {
  font-size: 1rem;
  color: #666;
}

.label{
  font-weight: bold;
  font-size: 16px;
}

.value{
  font-size: 16px;
}

/* FORM RESERVATION */

.custom-addReservation {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  margin-top: 20px;
  padding: 20px;
  background-color: #ffffff;
  border-radius: 15px;

}

.reservation-info {
  display: flex;
  flex-direction: column;
  margin-top: 10px;
  width: 350px;
}

.reservation-info input[type="text"] {
  width: 100%;
  padding: 10px;
  margin-bottom: 10px;
  border: 1px solid #ccc;
  border-radius: 5px;
  font-size: 16px;
}

button {
  background-color: #ee8f00;
  color: #fff;
  padding: 10px 20px;
  border: none;
  border-radius: 5px;
  font-size: 18px;
  cursor: pointer;
  transition: background-color 0.3s ease;
  margin-top: 20px; /* Agrega margen superior para separar el botón */
}

button:hover {
  background-color: #ee8f00;
}

</style>