<script>

export default {
  name: "toolbar-company",
  data() {
    return {
      drawer: false,
      userId: '',
      userType: '',
    };
  },
  created() {
    console.log('this route is: ',this.$route);

    // Obtiene el id del usuario
    const userId = this.$route.params.id;
    this.userId = userId;
    console.log('User id:', this.userId);

    // Obtiene el tipo de usuario
    const routeParts = this.$route.path.split('/');
    this.userType = routeParts[1];
    console.log('User type:', this.userType);
  },
  methods: {
    goToMembershipForm() {
      this.$router.push({
        path: `/company/${this.userId}/formulario`,
        name: 'FormularioPage',
        params: {
          id: this.userId,
        },
      });
    },
    goToCompanySettings() {
      this.$router.push({
        path: `/company/${this.userId}/company-settings`,
        name: 'company-settings',
        params: {
          id: this.userId,
        },
      });
    },
    logOut() {
      this.$router.push({
        path: '/home',
        name: 'home',
      });
    },
  }
}

</script>

<template>
  <div>
    <pv-toast></pv-toast>
    <header>
      <pv-toolbar class="bg-black">
        <template #start>
          <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Proyecto/image/Cargalogo.png?raw=true" alt="Imagen" style="height: 70px">
        </template>
        <template #end>
          <div class="flex-column">
            <pv-button @click="goToMembershipForm" class="p-button-text text-white">Membresia</pv-button>
            <pv-button @click="goToCompanySettings" class="p-button-text text-white">Editar Perfil</pv-button>
            <pv-button @click="logOut" class="p-button-text text-white">Cerrar Sesion</pv-button>
          </div>
        </template>
      </pv-toolbar>
    </header>
  </div>
  <router-view></router-view>
  <br><br>
</template>

<style scoped>
.bg-black {
  background-color: #1f1e1e;
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  z-index: 1000;
}
</style>
