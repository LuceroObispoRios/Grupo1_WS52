<template>
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
                placeholder="Nombre"
                v-model="nombre"
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
                placeholder="Correo electrónico"
                v-model="correo"
            />
            <input
                type="password"
                placeholder="Contraseña"
                v-model="contrasena"
            />
            <input
                type="password"
                placeholder="Repetir contraseña"
                v-model="confirmarContrasena"
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
export default {
  name: "ClientRegistrationForm",

  data() {
    return {
      nombre: '',
      apellidoMaterno: '',
      apellidoPaterno: '',
      celular: '',
      direccion: '',
      correo: '',
      contrasena: '',
      confirmarContrasena: '',
      errorMessage: '',
    };
  },
  methods: {
    onSubmit() {
      this.errorMessage = '';
      const formData = {
        nombre: this.nombre,
        apellidoMaterno: this.apellidoMaterno,
        apellidoPaterno: this.apellidoPaterno,
        celular: this.celular,
        direccion: this.direccion,
        correo: this.correo,
        contrasena: this.contrasena,
        confirmarContrasena: this.confirmarContrasena,
      };

      let warnings = '';

      if (
          !formData.nombre ||
          !formData.apellidoMaterno ||
          !formData.apellidoPaterno ||
          !formData.celular ||
          !formData.direccion ||
          !formData.correo ||
          !formData.contrasena ||
          !formData.confirmarContrasena
      ) {
        warnings += 'Todos los campos son obligatorios. <br>';
      }

      if (!formData.celular || !/^\d+$/.test(formData.celular)) {
        warnings += 'El celular debe contener solo dígitos enteros.<br>';
      }

      if (
          !formData.correo ||
          !/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(formData.correo)
      ) {
        warnings += 'El correo electrónico no es válido.<br>';
      }

      if (
          !formData.contrasena ||
          !/^(?=.*[A-Z])(?=.*\d).{12,}$/.test(formData.contrasena)
      ) {
        warnings +=
            'La contraseña debe tener al menos una letra en mayúscula, 12 caracteres y al menos 2 números.<br>';
      }

      if (formData.contrasena !== formData.confirmarContrasena) {
        warnings += 'Las contraseñas no coinciden.<br>';
      }

      this.errorMessage = warnings;

      /*if (!this.errorMessage) { //pasar info del nuevo usuario a JSON*/
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