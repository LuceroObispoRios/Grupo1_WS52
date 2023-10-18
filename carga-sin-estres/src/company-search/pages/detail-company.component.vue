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
            this.$router.push('/bookingHistory')
      });
    }
  }
};
</script>

<template>
  <div>
    <toolbar-client></toolbar-client>
  </div>

  <div><h1 class="title flex justify-content-center">Información de empresa</h1></div>

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
        <p class="label">Descripción: </p>
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
        <p class="label">Dirección: </p>
        <p class="value">{{ company.direccion }}</p>
      </div>

      <div class="company-services">
        <p class="label">Número de contacto: </p>
        <p class="value">{{ company.numeroContacto }}</p>
      </div>

    </template>
  </pv-card>
  
  <!-- FORMULARIO PARA AGREGAR RESERVA -->
  <br>
  <div class="custom-addReservation">
    <pv-panel header="Reservar" toggleable>
      <form @submit.prevent="submitForm" id="add-reservation" class="reservation-info">

        <!-- reserva info -->
        <label for="bookingDate">Fecha de hoy:</label><br>
        <input type="text" v-model="reservation.bookingDate" id="bookingDate"  required placeholder="Ex. 2023-10-17"><br>
        <label for="services">Servicios:</label><br>
        <input type="text" v-model="reservation.services" id="services"  required placeholder="Ex. Carga"><br>
        <label for="pickupAddress">Direccion de entrega:</label><br>
        <input type="text" v-model="reservation.pickupAddress" id="pickupAddress" required placeholder="Ex. Monterrico"><br>
        <label for="destinationAddress">Direccion de destino:</label><br>
        <input type="text" v-model="reservation.destinationAddress" id="destinationAddress"  required placeholder="Ex. Monterrico"><br>
        <label for="movingDate">Fecha cuando el servicio se lleva a cabo:</label><br>
        <input type="text" v-model="reservation.movingDate" id="movingDate"  required placeholder="Ex. 2023-10-19"><br>
        <label for="movingTime">Hora cuando el servicio se lleva a cabo:</label><br>
        <input type="text" v-model="reservation.movingTime" id="movingTime"  required placeholder="Ex. 14:00"><br>

        <!-- metodo de pago info -->
        <label for="cardNumber">Numero de tarjeta de pago:</label><br>
        <input type="text" id="cardNumber"  required placeholder="Ex. 1234 5678 9012 3456"><br>
        <label for="cvvCard">CVV de la tarjeta de pago:</label><br>
        <input type="text" id="cvvCard"  required placeholder="Ex. 123"><br>
        <label for="dateCard">Fecha de vencimiento de la tarjeta:</label><br>
        <input type="text" id="dateCard"  required  placeholder="Ex. 10/25"><br>

        <button type="submit">Realizar reserva</button>

      </form>
    </pv-panel>
  </div>


</template>



<style scoped>
/* CARD */
.custom-card {
  width: 80%; /* Ajusta el ancho según tus necesidades */
  max-width: 600px; /* Establece un ancho máximo para evitar que se vuelva demasiado ancho en pantallas grandes */
  margin: 50px auto;
  background-color: #ffffff;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
  border-radius: 8px;
  padding: 20px;
  text-align: left;
  display: flex;
  flex-direction: column;
  align-items: center;
}

.custom-card .company-name {
  font-size: 30px;
  font-weight: bold;
  margin: 10px 0;
}

.custom-card img {
  width: 80%; 
  height: auto;
  border-radius: 15px;
  align-self: center;
}

.company-type {
  font-size: 1rem;
  color: #666;
}

.label {
  font-weight: bold;
  font-size: 16px;
}

.value {
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
  width: 100%;

}

.reservation-info {
  display: flex;
  flex-direction: column;
  margin-top: 10px;
  max-width: 100%;
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
  margin-top: 20px;
}

button:hover {
  background-color: #ee8f00;
}

/*Titulo*/
.title {
  color: #FDAE39;
  font-family: sans-serif;
}

</style>
