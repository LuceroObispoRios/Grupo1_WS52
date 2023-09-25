<template>
  <div>
    <toolbar-company></toolbar-company>
  </div>

  <div>
      <h2>Formulario-Membresía</h2><hr>
    <div class="container1">
    <form @submit.prevent="submitForm" id="customer-info" class="left-container">
      <label for="nombre">Nombres:</label><br>
      <input type="text" v-model="nombre" required><br>
      <label for="apellido">Apellidos:</label><br>
      <input type="text" v-model="apellido" required><br>
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
      <label for="tarjeta">Tipo de tarjeta:</label>
      <select v-model="tipoTarjeta" required>
        <option value="visa">Visa</option>
        <option value="mastercard">MasterCard</option>
        <!-- Agrega más opciones según tus necesidades -->
      </select><br><br>
      <button type="submit">Continuar</button> <!-- Cambia @click por type="submit" -->
    </form>
      <div class="right-container">
        <img src="public/Cargalogo.png" alt="Imagen" class="floating-image">
      </div>
    </div>
  </div>
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
      nombre: '',
      apellido: '',
      ruc: '',
      direccion: '',
      tipoMembresia: '', // Agrega una propiedad para el tipo de membresía
      tipoTarjeta: '',
    };
  },
  methods: {
    submitForm() {
      // Asegúrate de que contadorBoletas sea un número antes de incrementarlo
      //if (typeof this.$root.$options.$contadorBoletas === 'number')
      {
        const contadorBoletas = ++this.$root.$options.$contadorBoletas; // Incrementar el contador global de boletas

        // Simular una solicitud al servidor (aquí puedes enviar los datos al servidor si es necesario)
        setTimeout(() => {
          // Redirigir al usuario a la página de la boleta con el número de boleta obtenido
          this.$router.push({
            path: '/boleta',
            query: {
              numeroBoleta: contadorBoletas,
              nombre: this.nombre,
              apellido: this.apellido,
              ruc: this.ruc,
              direccion: this.direccion,
              tipoMembresia: this.tipoMembresia,
              tipoTarjeta: this.tipoTarjeta,
            },
          });
        }, ); // Simula una solicitud al servidor después de 2 segundos.
      }
    },
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
  align-items: flex-start; /* Alinea el contenido en la parte superior */
  max-width: 800px; /* Ancho máximo del contenido */
  margin: 0 auto;
  padding: 20px;
}

/* Estilos para el formulario en la mitad izquierda */
.left-container {
  flex: 3; /* Ocupa el espacio disponible */
  background-color: #e8a300;
  border-radius: 10px;
  box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.2);
  padding: 60px;
  margin-right: 20px; /* Espacio entre el formulario y la imagen */
  margin-top: 20px; /* Agrega margen superior */
  margin-bottom: 20px; /* Agrega margen inferior */
}

/* Estilos para las etiquetas dentro del formulario */
.left-container label {
  font-weight: bold;
  margin-bottom: 10px; /* Reduce el margen inferior para alinearlas mejor */
  font-size: 15px;
  width: 90px; /* Ancho fijo para todas las etiquetas */
  display: inline-block; /* Alinea las etiquetas en línea */
}

input[type="text"] {
  width: 80%;
  padding: 10px;
  margin-bottom: 20px;
  border: 1px solid #ccc;
  border-radius: 5px;
  font-size: 12px;
}

input[type="number"] {
  width: 80%;
  padding: 10px;
  margin-bottom: 20px;
  border: 1px solid #ccc;
  border-radius: 5px;
  font-size: 12px;
}

/* Estilos para la imagen a la derecha */
.right-container {
  flex: 1; /* Ocupa el espacio disponible */
  text-align: center; /* Alinea el contenido en el centro horizontal */
  display: flex; /* Utiliza flexbox para centrar verticalmente */
  flex-direction: column; /* Alinea los elementos verticalmente */
  align-items: center; /* Centra verticalmente */
}

/* Estilos para la imagen */
.floating-image {
  width: 300px; /* Ajusta el ancho según tus necesidades */
  /*border-radius: 10px; /* Agrega bordes redondeados */
  /*box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.2); /* Agrega sombra */
  margin-top: 120px; /* Ajusta el margen superior para mover la imagen más abajo */
  height: 400px;
}

/* Estilos para el botón "Continuar" */
#submit {
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

#submit:hover {
  background-color: #ee8f00;
}
</style>
