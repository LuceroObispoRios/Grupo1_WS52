<script>
export default {
  name: "toolbar-client",
  data() {
    return {
      drawer: false,
      items: [
        { label: 'Editar Perfil', to: '/client-settings/:id' },
        { label: 'Busqueda de empresas', to: '/company-search' },
        { label: 'Historial de reserva', to: '/bookingHistory' },
        { label: 'Cerrar Sesion', to: '/home' },
      ],
    };
  },
}

</script>

<template>
  <div>
    <pv-toast></pv-toast>
    <header>
      <pv-toolbar class="bg-primary">
        <template #start>
          <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Proyecto/image/Cargalogo.png?raw=true" alt="Imagen" style="height: 70px">
        </template>
        <template #end>
          <div class="flex-column">
            <router-link
                v-for="item in items"
                :to="item.to"
                custom
                v-slot="{ navigate, href }"
                :key="item.label"
            >
              <template v-if="item.label === 'Cerrar Sesion'">
                <pv-button
                    class="logout-button"
                    :href="href"
                    @click="navigate"
                >
                  {{ item.label }}
                </pv-button>
              </template>
              <template v-else>
                <pv-button
                    class="p-button-text text-white"
                    :href="href"
                    @click="navigate"
                >
                  {{ item.label }}
                </pv-button>
              </template>
            </router-link>
          </div>
        </template>
      </pv-toolbar>
    </header>

    <RouterView />
  </div>
<br><br><br><br><br>
</template>

<style scoped>
.bg-primary {
  background-color: #282828 !important;
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  z-index: 1000;
}

.logout-button {
  background-color: #000000; /* Fondo blanco */
  border-color: white;
  color: #ffffff; /* Texto de color oscuro */
}

.logout-button:hover {
  background-color: #000000; /* Fondo blanco */
  border-color: white;
  color: #ffffff; /* Texto de color oscuro */
}
</style>
