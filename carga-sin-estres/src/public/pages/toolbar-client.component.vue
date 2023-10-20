<script>
export default {
  name: "toolbar-client",
  data() {
    return {
      drawer: false,
      items: [
        { label: 'Editar Perfil', to: '/client/:id/client-settings/' },
        { label: 'Busqueda de empresas', to: '/client/:id/company-search' },
        { label: 'Historial de reserva', to: '/client/:id/client-booking-history' },
        { label: 'Cerrar Sesion', to: '/home' },
      ],
      userId: '',
      userType: '',
    };
  },
  created() {
    console.log('this route is: ',this.$route);

    // Obtiene el id del usuario
    this.userId = this.$route.params.id;
    console.log('User id:', this.userId);

    // Obtiene el tipo de usuario
    const routeParts = this.$route.path.split('/');
    this.userType = routeParts[1];
    console.log('User type:', this.userType);
  }
}

</script>

<template>
  <div>
    <pv-toast></pv-toast>
    <header>
      <pv-toolbar class="navbar navbar-expand-md navbar-light fixed-top">
        <template #start>
          <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Proyecto/image/Cargalogo.png?raw=true" alt="Imagen" style="height: 40px">
          <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
          </button>
        </template>
        <template #end>
          <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav ml-auto">
              <li class="nav-item"><router-link :to="'/client/'+ this.userId + '/client-settings'" class="nav-link">Editar Perfil</router-link></li>
              <li class="nav-item"><router-link :to="'/client/' + this.userId + '/company-search'" class="nav-link">Búsqueda de Empresas</router-link></li>
              <li class="nav-item"><router-link :to="'/client/' + this.userId + '/client-booking-history'" class="nav-link">Historial de reserva</router-link></li>
              <li class="nav-item"><router-link to="/home" class="btn btn-outline-dark">Cerrar Sesión</router-link></li>
            </ul>
          </div>
        </template>
      </pv-toolbar>
    </header>
    <br><br><br>
    <RouterView />
  </div>
  <br><br><br><br><br>
</template>

<style scoped>
/* Estilos para la barra de navegación */
.navbar {
  background-color: #1f1e1e;
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  z-index: 1000;
}

.navbar-toggler {
  background-color: #ffffff !important;
  margin-left:300px;
}

.navbar-toggler-icon {
  color: #ffffff !important;
}

.navbar-nav .nav-item {
  margin-right: 20px;
}

.nav-link {
  color: #ffffff !important;
}

.btn-outline-dark {
  color: #ffffff;
  width:150px;
  background-color: #000000;
  border-color: #000000;
  margin-left: 20px;
}

.btn-outline-dark:hover {
  color: #ffffff;
  background-color: #ff8800;
  border-color: #ffffff;
}
</style>
