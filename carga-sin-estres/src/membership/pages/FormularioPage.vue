<template>
  <div>
    <toolbar-company></toolbar-company>
    <br><br><br>
  </div>

  <div>
    <div class="container1">
      <form @submit.prevent="submitForm" id="customer-info" class="left-container">
        <label for="tipoUsuario">Seleccione el tipo de usuario:</label><br>
        <input type="radio" id="cliente" value="cliente" v-model="tipoUsuario" required>
        <label for="cliente">Cliente</label>
        <input type="radio" id="empresa" value="empresa" v-model="tipoUsuario" required>
        <label for="empresa">Empresa</label>
        <br><br>

        <!-- Campos para cliente -->
        <div v-if="tipoUsuario === 'cliente' ">
          <label for="nombre">Nombres:</label><br>
          <input type="text" v-model="nombre" required><br>
          <label for="apellido">Apellidos:</label><br>
          <input type="text" v-model="apellido" required><br>
          <label for="dni">DNI:</label><br>
          <input type="text" v-model="dni" required><br>
        </div>

        <!-- Campos para empresa -->
        <div v-if="tipoUsuario === 'empresa'">
          <label for="nombreEmpresa">Nombre de Empresa:</label><br>
          <input type="text" v-model="nombreEmpresa" required><br>
          <label for="ruc">RUC:</label><br>
          <input type="text" v-model="ruc" required><br>
        </div>

        <!-- Campos comunes -->
        <label for="direccion">Dirección:</label><br>
        <input type="text" v-model="direccion" required><br>
        <label for="tipoMembresia">Tipo de membresía:</label>
        <select v-model="tipoMembresia" required>
          <option value="35">1 Mes</option>
          <option value="95">3 Meses</option>
          <option value="365">1 Año</option>
        </select><br>
        <label for="tipoTarjeta">Tipo de tarjeta:</label>
        <select v-model="tipoTarjeta" required>
          <option value="visa">Visa</option>
          <option value="mastercard">MasterCard</option>
        </select><br><br>
        <button type="submit">Continuar</button>
      </form>
      <div class="right-container">
        <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Proyecto/image/Cargalogo.png?raw=true" alt="Imagen" class="floating-image">
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
      tipoUsuario: '',
      nombre: '',
      apellido: '',
      dni: '',
      nombreEmpresa: '',
      ruc: '',
      direccion: '',
      tipoMembresia: '',
      tipoTarjeta: '',
    };
  },
  methods: {
    submitForm() {
      // Crear un objeto para almacenar los datos del formulario
      const formData = {
        tipoUsuario: this.tipoUsuario,
        direccion: this.direccion,
        tipoMembresia: this.tipoMembresia,
        tipoTarjeta: this.tipoTarjeta,
      };
      console.log(formData)
      if (this.tipoUsuario === 'cliente') {
        // Agregar datos específicos del cliente
        formData.nombre = this.nombre;
        formData.apellido = this.apellido;
        formData.dni = this.dni;
        console.log("cliente",this.nombre)
      } else if (this.tipoUsuario === 'empresa') {
        // Agregar datos específicos de la empresa
        formData.nombreEmpresa = this.nombreEmpresa;
        formData.ruc = this.ruc;
        console.log("empresa",this.nombreEmpresa)
      }

      // Redirigir al usuario a la página de la boleta con los datos del formulario
      this.$router.push({
        path: '/boleta',
        query: formData,
      });
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