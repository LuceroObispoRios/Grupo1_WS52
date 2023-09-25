<script>
import { cargaSinEstresApiService } from "../services/cargaSinEstres-api.service";
import toolbarClient from "@/public/pages/toolbar-client.component.vue";

export default {
  name: 'company-detail',
  components: {toolbarClient},
  data() {
    return {
      id: null,
      companyData: null,
      reservation:{
        id: null,
        idCompany: null,
        services: null,
        bookingDate: null,
        pickupAddress: null,
        destinationAddress: null,
        movingDate: null,
        movingTime: null,
        status: null,
        payment: {
          totalAmount: null,
          paymentMethod: null,
        },
        hiredCompany: {
          name: null,
          logo: null,
        },
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
      this.reservation.hiredCompany.name = this.company.name;
      this.reservation.hiredCompany.logo = this.company.photo;
      this.reservation.status="En curso";
      this.reservation.payment.totalAmount=0;
      this.reservation.payment.paymentMethod="Por definir";

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
  <div>
    <toolbar-client></toolbar-client>
  </div>
  <!-- INFORMACION DE LA EMPRESA -->
  <pv-card class="custom-card">
    <template #title>
      <img :src="company.photo" alt="logo de empresa" class="company-logo">
    </template>

    <template #content>
      <div class="company-info">
        <h2 class="company-name">{{ company.name }}</h2>
        <p class="company-type">Empresa</p>
      </div>

      <div class="company-services">
        <p class="label">Descripcion: </p>
        <p class="value">{{ company.description }}</p>
      </div>

      <div class="company-services">
        <p class="label">Servicios: </p>
        <div class="company-services">
          <ul>
            <li class="value" v-if="company.transporte">Transporte</li>
            <li class="value" v-if="company.carga">Carga</li>
            <li class="value" v-if="company.embalaje">Embalaje</li>
            <li class="value" v-if="company.montaje">Montaje</li>
            <li class="value" v-if="company.desmontaje">Desmontaje</li>
          </ul>
        </div>
      </div>

      <div class="company-services">
        <p class="label">Direccion: </p>
        <p class="value">{{ company.direccion }}</p>
      </div>

      <div class="company-services">
        <p class="label">Numero de contacto: </p>
        <p class="value">{{ company.numeroContacto }}</p>
      </div>

    </template>
  </pv-card>

  <!-- FORMULARIO PARA AGREGAR RESERVA -->
  <br>
  <div class="custom-addReservation">
    <pv-panel header="Reservar" toggleable>
      <form @submit.prevent="submitForm" id="add-reservation" class="reservation-info">
        <label for="bookingDate">Fecha de hoy:</label><br>
        <input type="text" v-model="reservation.bookingDate" id="bookingDate"  required><br>
        <label for="services">Servicios:</label><br>
        <input type="text" v-model="reservation.services" id="services"  required><br>
        <label for="pickupAddress">Direccion de entrega:</label><br>
        <input type="text" v-model="reservation.pickupAddress" id="pickupAddress"  required><br>
        <label for="destinationAddress">Direccion de destino:</label><br>
        <input type="text" v-model="reservation.destinationAddress" id="destinationAddress"  required><br>
        <label for="movingDate">Fecha cuando el servicio se lleva a cabo:</label><br>
        <input type="text" v-model="reservation.movingDate" id="movingDate"  required><br>
        <label for="movingTime">Hora cuando el servicio se lleva a cabo:</label><br>
        <input type="text" v-model="reservation.movingTime" id="movingTime"  required><br>

        <button type="submit">Realizar reserva</button>

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

.custom-card .company-name {
  font-size: 30px;
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
