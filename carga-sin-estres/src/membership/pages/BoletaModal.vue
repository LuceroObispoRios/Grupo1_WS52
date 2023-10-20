<template>
  <div>
    <toolbar-company></toolbar-company>
    <br><br><br>
  </div>
  
  <div>
    <div class="container1">
      <form @submit.prevent="submitForm" id="customer-info" class="left-container">
        <label for="nombre">Nombre de la Empresa:</label><br>
        <input type="text" v-model="nombreEmpresa" required><br>
        <label for="ruc">RUC:</label><br>
        <input type="number" v-model="ruc" required><br>
        <label for="direccion">Dirección:</label><br>
        <input type="text" v-model="direccion" required><br>
        <label for="tipoMembresia">Tipo de membresía:</label>
        <select v-model="tipoMembresia" required>
          <option value="35">1 Mes</option>
          <option value="95">3 Meses</option>
          <option value="365">1 Año</option>
        </select><br>
        <label for="tipoTarjeta">Tipo de tarjeta:</label>
        <select v-model="tipoTarjeta" required @change="resetCardFields">
          <option value="Visa">Visa</option>
          <option value="Mastercard">MasterCard</option>
        </select><br><br>
        <!-- Campos de tarjeta Visa -->
        <div v-if="tipoTarjeta === 'Visa'">
          <label for="nombreTarjeta">Nombre en la tarjeta:</label><br>
          <input type="text" v-model="tarjetaVisa.nombre" required><br>
          <label for="numeroTarjeta">Número de tarjeta:</label><br>
          <input type="number" v-model="tarjetaVisa.numero" required><br>
          <label for="fechaVencimiento">Fecha de vencimiento:</label><br>
          <input type="date" v-model="tarjetaVisa.fechaVencimiento" required><br>
          <label for="cvv">CVV:</label><br>
          <input type="number" v-model="tarjetaVisa.cvv" required><br>
          <label for="pais">País:</label><br>
          <input type="text" v-model="tarjetaVisa.pais" required><br>
        </div>

        <!-- Campos de tarjeta MasterCard -->
        <div v-else-if="tipoTarjeta === 'Mastercard'">
          <label for="nombreTarjeta">Nombre en la tarjeta:</label><br>
          <input type="text" v-model="tarjetaMasterCard.nombre" required><br>
          <label for="numeroTarjeta">Número de tarjeta:</label><br>
          <input type="number" v-model="tarjetaMasterCard.numero" required><br>
          <label for="fechaVencimiento">Fecha de vencimiento:</label><br>
          <input type="date" v-model="tarjetaMasterCard.fechaVencimiento" required><br>
          <label for="cvv">CVV:</label><br>
          <input type="number" v-model="tarjetaMasterCard.cvv" required><br>
          <label for="pais">País:</label><br>
          <input type="text" v-model="tarjetaMasterCard.pais" required><br>
        </div>

        <button type="submit">Pagar Ahora</button>
      </form>
      <div class="right-container">
        <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Proyecto/image/Cargalogo.png?raw=true" alt="Imagen" class="floating-image">
      </div>
    </div>
  </div>
  <br>
</template>

<script>
import boletaModal from "@/membership/pages/BoletaModal.vue";
import toolbarCompanyComponent from "@/public/pages/toolbar-company.component.vue";
import toolbarCompany from "@/public/pages/toolbar-company.component.vue";

export default {
  name: 'FormularioPage',
  components: {toolbarCompany, toolbarCompanyComponent },
  computed: {
    boletaModal() {
      return boletaModal
    }
  },
  data() {
    return {
      dni: '',
      nombreEmpresa: '',
      ruc: '',
      direccion: '',
      tipoMembresia: '',
      tipoTarjeta: '',
      tarjetaVisa: {
        nombre: '',
        numero: '',
        fechaVencimiento: '',
        cvv: '',
        pais: '',
      },
      tarjetaMasterCard: {
        nombre: '',
        numero: '',
        fechaVencimiento: '',
        cvv: '',
        pais: '',
      },
    };
  },
  methods: {
    submitForm() {
      {
        setTimeout(() => {
          // Redirigir al usuario a la página de la boleta con el número de boleta obtenido
          this.$router.push({
            path: '/boleta',
            query: {
              nombreEmpresa: this.nombreEmpresa,
              ruc: this.ruc,
              direccion: this.direccion,
              tipoMembresia: this.tipoMembresia,
              tipoTarjeta: this.tipoTarjeta,
            },
          });
        },);
      }
    },
    resetCardFields() {
      if (this.tipoTarjeta === 'Visa') {
        this.tarjetaVisa = {
          nombre: '',
          numero: '',
          fechaVencimiento: '',
          cvv: '',
          pais: '',
        };
      } else if (this.tipoTarjeta === 'Mastercard') {
        this.tarjetaMasterCard = {
          nombre: '',
          numero: '',
          fechaVencimiento: '',
          cvv: '',
          pais: '',
        };
      }
    }
  },
};
</script>

<style>
h2{
  color: #181818;
  font-size: 50px;
}

/* Estilos para el contenedor principal */
.container1 {
  display: flex;
  justify-content: space-between;
  align-items: flex-start;
  max-width: 800px;
  margin: 0 auto;
  padding: 20px;
}

/* Estilos para el formulario en la mitad izquierda */
.left-container {
  flex: 3;
  background-color: #e8a300;
  border-radius: 10px;
  box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.2);
  padding: 60px;
  margin-right: 20px;
  margin-top: 20px;
  margin-bottom: 20px;
}

/* Estilos para las etiquetas dentro del formulario */
.left-container label {
  font-weight: bold;
  margin-bottom: 10px;
  font-size: 15px;
  width: 90px;
  display: inline-block;
}

input[type="text"] {
  width: 100%;
  padding: 10px;
  margin-bottom: 20px;
  border: 1px solid #ccc;
  border-radius: 5px;
  font-size: 12px;
}

input[type="number"] {
  width: 100%;
  padding: 10px;
  margin-bottom: 20px;
  border: 1px solid #ccc;
  border-radius: 5px;
  font-size: 12px;
}

/* Estilos para la imagen a la derecha */
.right-container {
  flex: 1;
  text-align: center;
  display: flex;
  flex-direction: column;
  align-items: center;
}

/* Estilos para la imagen */
.floating-image {
  width: 150px;
  margin-top: 120px;
  height: 400px;
}
</style>
