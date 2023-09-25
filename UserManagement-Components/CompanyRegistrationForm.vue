<template>
  <div class="container">
    <div class="container-back">
      <div class="user-info">
        <form @submit.prevent="onSubmit" id="registro">
          <h2>Registrar Cuenta de Empresa</h2>
          <img src="image/Cargalogo.png" alt="Logo de Carga sin estres" class="logo" />

          <div class="right-section">
            <input type="text" placeholder="Nombre de la empresa" v-model="companyName" id="nombre" />
            <input type="text" placeholder="Correo" v-model="correo" id="correo" />
            <input type="text" placeholder="Dirección" v-model="direccion" id="direccion" />
            <input type="text" placeholder="Teléfono" v-model="numeroContacto" id="numeroContacto" />
            <input type="password" placeholder="Contraseña" v-model="contrasena" id="contrasena" />
            <input type="password" placeholder="Confirmar contraseña" v-model="confirmarContrasena" id="confirmarContrasena" />
          </div>

          <div class="service-boxes">
            <p>Marque los servicios que ofrece su empresa:</p>
            <div class="checkboxes col">
              <div class="check row-1">
                <input type="checkbox" v-model="transporte" value="transporte" id="transporte" />
                <label for="transporte">Transporte</label>
              </div>

              <div class="check row-1">
                <input type="checkbox" v-model="carga" value="carga" id="carga" />
                <label for="carga">Carga</label>
              </div>

              <div class="check row-1">
                <input type="checkbox" v-model="embalaje" value="embalaje" id="embalaje" />
                <label for="embalaje">Embalaje</label>
              </div>

              <div class="check row-1">
                <input type="checkbox" v-model="montaje" value="montaje" id="montaje" />
                <label for="montaje">Montaje</label>
              </div>

              <div class="check row-1">
                <input type="checkbox" v-model="desmontaje" value="desmontaje" id="desmontaje" />
                <label for="desmontaje">Desmontaje</label>
              </div>
            </div>
          </div>

          <div class="description-box">
            <label for="description">Descripción corta de la empresa:</label>
            <textarea v-model="description" rows="6" id="description"></textarea>
          </div>

          <button id="registro-button" type="submit">Registrar Empresa</button>
          <button id="cancel-button" type="button" @click="cancel">Cancelar</button>
          <div id="errorMessages" class="error-messages" v-html="errorMessage"></div>
        </form>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'CompanyRegistrationForm',

  data() {
    return {
      companyName: '',
      correo: '',
      direccion: '',
      numeroContacto: '',
      contrasena: '',
      confirmarContrasena: '',
      transporte: false,
      carga: false,
      embalaje: false,
      montaje: false,
      desmontaje: false,
      description: '',
      errorMessage: ''
    };
  },
  methods: {
    onSubmit() {
      this.errorMessage = '';
      const formData = {
        companyName: this.companyName,
        correo: this.correo,
        direccion: this.direccion,
        numeroContacto: this.numeroContacto,
        contrasena: this.contrasena,
        confirmarContrasena: this.confirmarContrasena,
        transporte: this.transporte,
        carga: this.carga,
        embalaje: this.embalaje,
        montaje: this.montaje,
        desmontaje: this.desmontaje,
        description: this.description
      };

      let warnings = '';

      if (formData.companyName.length < 1) {
        warnings += 'El nombre no es válido <br>';
      }

      if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(formData.correo)) {
        warnings += 'El correo no es válido <br>';
      }

      if (formData.direccion.length < 1) {
        warnings += 'La dirección no es válida <br>';
      }

      if (!/^\d+$/.test(formData.numeroContacto)) {
        warnings += 'El número de contacto no es válido <br>';
      }

      if (formData.contrasena.length < 6) {
        warnings += 'La contraseña debe tener al menos 6 caracteres <br>';
      }

      if (formData.contrasena !== formData.confirmarContrasena) {
        warnings += 'Las contraseñas no coinciden <br>';
      }

      if (!formData.transporte && !formData.carga && !formData.embalaje && !formData.montaje && !formData.desmontaje) {
        warnings += 'Debe seleccionar al menos un servicio <br>';
      }

      if (formData.description.length < 1) {
        warnings += 'La descripción no es válida <br>';
      }

      this.errorMessage = warnings;

      if (!this.errorMessage) {
        // Lógica para enviar el nuevo usuario a JSON
        console.log(formData);
      }
    },

    cancel() {
      // Lógica para cancelar el registro y volver a LandingPage
    }
  }
};
</script>

<style scoped>
html {
  overflow-y: scroll;
}

body {
  font-family: Arial, sans-serif;
  background-color: #ffffff;
  margin: 0;
  padding: 0;
}

.container {
  max-width: 1000px;
  margin: 3rem 3rem 3rem 3rem;
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

h2 {
  text-align: center;
  margin-bottom: 20px;
}

.user-info {
  display: flex;
  margin-top: 10px;
  margin-bottom: 10px;
  align-items: flex-start;
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

.service-boxes{
  max-width: 80%;
  margin: auto auto 20px auto;
  display: flex;
  flex-direction: column;
}

.service-boxes .checkboxes{
  border-radius: 5px;
  border: 1px solid #FDAE39;
  background-color: white;
  display: flex;
  flex-direction: column;
}

.description-box{
  display: flex;
  flex-direction: column;
}

.description-box label{
  margin-left: 10%;
}

.description-box #description{
  margin: auto;
  border-radius: 5px;
  border: 1px solid #FDAE39;
  width: 80%;
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
  margin-top: 25px;
  margin-right: 15px;
}

button:hover {
  background-color: #FDAE39;
}

.error-messages {
  color: #ff0000;
  font-weight: bold;
  margin-top: 10px;
}

.logo {
  width: 200px;
  height: 200px;
  display: block;
  margin: auto;
}
</style>