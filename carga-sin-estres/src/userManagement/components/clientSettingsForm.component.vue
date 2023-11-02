<script>
import { HttpCommonService } from "@/services/http-common.service.js";

export default {
  name: "clientSettingsForm",
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
      apiService: new HttpCommonService(),
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
      // Validación para name, apellidoMaterno y apellidoPaterno
      if (!formData.name.trim() || formData.name.trim().length < 3) {
        warnings += 'El nombre debe tener al menos 3 letras.<br>';
      }
      if (!formData.apellidoMaterno.trim() || formData.apellidoMaterno.trim().length < 3) {
        warnings += 'El apellido materno debe tener al menos 3 letras.<br>';
      }

      if (!formData.apellidoPaterno.trim() || formData.apellidoPaterno.trim().length < 3) {
        warnings += 'El apellido paterno debe tener al menos 3 letras.<br>';
      }

      if (!formData.celular || !/^\d+$/.test(formData.celular) || formData.celular.length > 11) {
        warnings += 'El número de celular debe contener solo dígitos y tener un máximo de 11 dígitos.<br>';
      }
      // Validación para direccion
      if (!formData.direccion.trim().length < 6) {
        warnings += 'La dirección no debe estar en blanco y tener al menos 6 letras.<br>';
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
        this.updateClient(); // Actualizar con los datos del formulario
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

    cancel(){
      this.$router.push({
        path: `/company/${this.id}/company-search`,
        name: 'company-search',
        params: {
          id: this.id,
        },
      });
    }

  },
};
</script>

<template>
  <div class="container">
    <div class="container-back">
      <div class="user-info">
        <form @submit.prevent="onSubmit" id="settings">
          <h2>Editar datos de Perfil de Cliente</h2>
          <div class="right-section">
            <input type="text" placeholder="Name" v-model="formData.name" /> <!--falta id?-->
            <input type="text" placeholder="Apellido Materno" v-model="formData.apellidoMaterno" />
            <input type="text" placeholder="Apellido Paterno" v-model="formData.apellidoPaterno"  />
            <input type="text" placeholder="Celular" v-model="formData.celular"  />
            <input type="text" placeholder="Dirección" v-model="formData.direccion" />
          </div>
          <div class="right-section">
            <input class="text-xs" type="email" placeholder="Email" v-model="formData.email" />
            <input class="text-xs" type="password" placeholder="Contraseña" v-model="formData.password"  />
            <input class="text-xs" type="password" placeholder="Repetir contraseña" v-model="formData.confirmarpassword"  />
          </div>
          <button id="submitButton" type="submit">Guardar cambios</button>
          <button id="cancelButton" type="button" @click="cancel">Cancelar</button>
          <div id="errorMessages" class="error-messages" v-html="errorMessage"></div>
        </form>
      </div>
    </div>
  </div>

</template>



<style scoped>
body {
  font-family: Arial, sans-serif;
  background-color: #ffffff;
  margin: 0;
  padding: 0;
}

.container {
  max-width: 1000px;
  margin: 5rem auto;
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
