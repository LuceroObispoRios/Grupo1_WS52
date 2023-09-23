
<template>
  <div>
    <pv-menubar class="sticky bg-primary" aria-label="Toolbar">
      <template #start>
        <pv-button label="Carga sin Estres" icon="pi pi-bars" @click="" aria-label="Sidebar button"></pv-button>
      </template>
      <template #end></template>
    </pv-menubar>
  </div>

  <div class="container">
    <div class="container-back">
      <div class="user-info">
        <form @submit.prevent="onSubmit" id="settings">
          <h2>Editar datos de Perfil de Cliente</h2>
          <div class="right-section">
            <input type="text" placeholder="name" v-model="formData.name"  />
            <input type="text" placeholder="Apellido Materno" v-model="formData.apellidoMaterno" />
            <input type="text" placeholder="Apellido Paterno" v-model="formData.apellidoPaterno"  />
            <input type="text" placeholder="Celular" v-model="formData.celular"  />
            <input type="text" placeholder="Dirección" v-model="formData.direccion" />
          </div>
          <div class="right-section">
            <input type="email" placeholder="email electrónico" v-model="formData.email" />
            <input type="password" placeholder="Contraseña" v-model="formData.password"  />
            <input type="password" placeholder="Repetir contraseña" v-model="formData.confirmarpassword"  />
          </div>
          <button id="submitButton" type="submit">Guardar cambios</button>
          <button id="cancelButton" type="button" @click="cancel">Cancelar</button>
          <div id="errorMessages" class="error-messages" v-html="errorMessage"></div>
        </form>
      </div>
    </div>
  </div>

  <footer class ="public-footer" aria-label="footer">
    <p> Copyright <span>&copy;</span> Carga sin Estres, All rights reserved.</p>
    <br>
    <p>   Developed by Eric Cuevas - U202112766   </p>
  </footer>
</template>

<script>
import { cargaSinEstresApiService } from "@/company-search/services/cargaSinEstres-api.service.js";
export default {
  name: "ClientSettingsForm",

  data() {
    return {
      client: {
        name: '',
        apellidoMaterno: '',
        apellidoPaterno: '',
        celular: '',
        direccion: '',
        email: '',
        password: '',
        id: '',
      },
      confirmarpassword: '',
      errorMessage: '',
      id: null,
      formData: {
        name: '',
        apellidoMaterno: '',
        apellidoPaterno: '',
        celular: '',
        direccion: '',
        email: '',
        password: '',
        confirmarpassword: '',
      },
      apiService: new cargaSinEstresApiService(),
    };
  },
  created() {
    this.id = this.$route.params.id;
    console.log("id cliente settings:", this.id);
  },
  methods: {
    onSubmit() {
      this.errorMessage = '';
      const formData = {
        name: this.formData.name,
        apellidoMaterno: this.formData.apellidoMaterno,
        apellidoPaterno: this.formData.apellidoPaterno,
        celular: this.formData.celular,
        direccion: this.formData.direccion,
        email: this.formData.email,
        password: this.formData.password,
        confirmarpassword: this.formData.confirmarpassword,
      };

      let warnings = '';

      if (
          !formData.celular ||
          !/^\d+$/.test(formData.celular)
      ) {
        warnings += 'El nuevo celular debe contener solo dígitos enteros.<br>';
      }

      if (
          !formData.email ||
          !/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(formData.email)
      ) {
        warnings += 'La nueva dirección de email electrónico no es válida.<br>';
      }

      if (formData.password.length < 6) {
        warnings += `La nueva contraseña no es válida <br>`;
      }

      if (this.formData.password !== this.formData.confirmarpassword) {
        warnings += 'La confirmación de la nueva contraseña no coincide.<br>';
      }


      this.errorMessage = warnings;

      if (!this.errorMessage) {
        console.log('Nuevos ajustes de usuario: ', formData);
        this.updateClient(); // Aquí puedes agregar la lógica para guardar los cambios en el objeto JSON correspondiente

      }
    },

    updateClient() {
      // Actualizar con los datos del formulario
      this.client.name = this.formData.name;
      this.client.apellidoMaterno = this.formData.apellidoMaterno;
      this.client.apellidoPaterno = this.formData.apellidoPaterno;
      this.client.celular = this.formData.celular;
      this.client.direccion = this.formData.direccion;
      this.client.email = this.formData.email;
      this.client.password = this.formData.password;
      this.client.id = this.id;

      this.saveUpdatedClientDataToServer();

      //this.$router.push('/client-settings');  //Ajustar a la ruta donde quieras ir

    },

    async saveUpdatedClientDataToServer() {
      try {
        const response = await this.apiService.updateClient(this.client.id , this.client);

        if (response.status === 200) {
          console.log('Datos del cliente actualizados con éxito:', response.data);

        } else {
          console.error('Error al actualizar los datos del cliente:', response.data);
        }
      } catch (error) {
        console.error('Error al actualizar los datos del cliente:', error);
      }
    },

    cancel() {
      // Lógica para cancelar la edición
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
  margin: 3rem 5rem 3rem 5rem;
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

.user-info {
  display: flex;
  align-items: center;
  margin-top: 10px;
  margin-bottom: 10px;
  /*align-items: flex-start;*/
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

button {
  width: 180px;
  background-color: #000000;
  color: #fff;
  font-size: 18px;
  padding: 5px 10px;
  border: none;
  border-radius: 5px;
  cursor: pointer;
  align-self: flex-start;
  margin-top: 10px;
  margin-right: 10px;
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