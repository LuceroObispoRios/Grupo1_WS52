<template>
  <div>
    <toolbar-home></toolbar-home>
  </div>
  
  <div class="container">
    <div class="container-back">
      <div class="user-info">
        <div class="left-section">
          <img src="image/logo2.png" alt="Avatar" />
          <h5>Carga sin Estres</h5>
        </div>
        <form @submit.prevent="onSubmit" id="myForm">
          <div class="right-section">
            <input
                type="text"
                placeholder="nombre"
                v-model="name"
            />
            <input
                type="text"
                placeholder="Apellido Materno"
                v-model="apellidoMaterno"
            />
            <input
                type="text"
                placeholder="Apellido Paterno"
                v-model="apellidoPaterno"
            />
            <input
                type="text"
                placeholder="Celular"
                v-model="celular"
            />
            <input
                type="text"
                placeholder="Dirección"
                v-model="direccion"
            />
          </div>
          <div class="right-section">
            <input
                type="email"
                placeholder="email electrónico"
                v-model="email"
            />
            <input
                type="password"
                placeholder="Contraseña"
                v-model="password"
            />
            <input
                type="password"
                placeholder="Repetir contraseña"
                v-model="confirmarpassword"
            />
          </div>
          <button id="registrarButton" type="submit">Registrar ➜</button>
          <button id="cancelButton" type="button" @click="cancel">Cancelar</button>
          <div
              id="errorMessages"
              class="error-messages"
              v-html="errorMessage"
          ></div>
        </form>
      </div>
    </div>
  </div>
</template>

<script>
import { cargaSinEstresApiService } from "@/company-search/services/cargaSinEstres-api.service.js";
import ToolbarHome from "@/public/pages/toolbar-home.component.vue";
export default {
  name: "ClientRegistrationForm",
  components: {ToolbarHome},
  data() {
    return {
      name: '',
      apellidoMaterno: '',
      apellidoPaterno: '',
      celular: '',
      direccion: '',
      email: '',
      password: '',
      confirmarpassword: '',
      errorMessage: '',
      apiService: new cargaSinEstresApiService(),
    };
  },
  methods: {
    async onSubmit() {
      this.errorMessage = '';
      const formData = {
        name: this.name,
        apellidoMaterno: this.apellidoMaterno,
        apellidoPaterno: this.apellidoPaterno,
        celular: this.celular,
        direccion: this.direccion,
        email: this.email,
        password: this.password,
        confirmarpassword: this.confirmarpassword,
      };

      let warnings = '';

      if (
          !formData.name ||
          !formData.apellidoMaterno ||
          !formData.apellidoPaterno ||
          !formData.celular ||
          !formData.direccion ||
          !formData.email ||
          !formData.password ||
          !formData.confirmarpassword
      ) {
        warnings += 'Todos los campos son obligatorios. <br>';
      }

      if (!formData.celular || !/^\d+$/.test(formData.celular)) {
        warnings += 'El celular debe contener solo dígitos enteros.<br>';
      }

      if (
          !formData.email ||
          !/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(formData.email)
      ) {
        warnings += 'El email electrónico no es válido.<br>';
      }

      if (formData.password.length < 6) {
        warnings += 'La contraseña debe tener al menos 6 caracteres <br>';
      }

      if (formData.password !== formData.confirmarpassword) {
        warnings += 'Las contraseñcas no coinciden.<br>';
      }

      this.errorMessage = warnings;


      /*if (!this.errorMessage) { //pasar info del nuevo usuario a JSON*/

      if (!this.errorMessage) {
        // Datos del nuevo cliente a registrar
        const clientData = {
          name: this.name,
          apellidoMaterno: this.apellidoMaterno,
          apellidoPaterno: this.apellidoPaterno,
          celular: this.celular,
          direccion: this.direccion,
          email: this.email,
          password: this.password,
        };

        try {
          // Envía la solicitud para registrar al cliente
          const response = await this.apiService.createClient(clientData);

          // Verifica si el registro fue exitoso (puedes ajustar la lógica según tu API)
          if (response.status === 201) {
            this.$router.push('/login');
          } else {
            this.errorMessage = 'Error al registrar al cliente. Intente nuevamente.';
          }
        } catch (error) {
          console.error(error);
          this.errorMessage = 'Ocurrió un error al registrar al cliente. Intente nuevamente.';
        }
      }

    },

    cancel() {
      // Lógica para cancelar el registro
    },
  },
};
</script>

<style scoped>
body {
  font-family: Arial, sans-serif;
  background-color: #ffffff;
  margin: 0;
  padding: 0;
}

.container {
  max-width: 1000px;
  margin: 5rem auto auto auto;
  padding: 20px;
  background-color: #d9d9d9;
  border-radius: 10px;
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
  position:relative;
}

.container-back {
  max-width: 900px;
  margin: 0 auto;
  padding: 20px;
  background-color: #fff9f9;
  border: 2px solid #000000;
  border-radius: 20px;
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
  display: flex;
  justify-content: center;
  align-items: center;
}


.options h3 {
  margin-right: 30px;
}

.radio-option input[type="radio"] {
  margin-right: 5px;
}

.user-info {
  display: flex;
  /*align-items: center;*/
  margin-top: 10px;
  margin-bottom: 10px;
  align-items: flex-start;
}

.left-section img {
  max-width: 150px;
  border-radius: 50%;
}

.left-section h5 {
  text-align: center;
  margin-top: 2px;
}

.right-section {
  flex: 1;
  padding-left: 40px;
}

input[type="text"],
input[type="password"],
input[type="email"],
select {
  width: 90%;
  padding: 10px;
  margin-bottom: 10px;
  margin-top: 10px;
  border: 1px solid #FDAE39;
  border-radius: 5px;
}

button{
  position: relative;
  width: 150px;
  background-color: #000000;
  color: #fff;
  font-size: 18px;
  padding: 5px 10px;
  cursor: pointer;
  align-self: flex-start;
  margin-top: 10px;
  margin-right: 10px;
  border: 1px solid #FDAE39;
  border-radius: 4px;
}

button:hover {
  background-color: #FDAE39;
}

.error-messages {
  color: #ff0000;
  font-weight: bold;
  margin-top: 10px;
}
</style>
