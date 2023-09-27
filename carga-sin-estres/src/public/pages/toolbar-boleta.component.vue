<script>

export default {
  name: "toolbar-boleta",
  data() {
    return {
      drawer: false,
      items: [
        { label: "Inicio", to: "/" },
        { label: 'Editar Perfil', to: '/client-settings/:id' },
      ],
    };
  },
}

</script>

<template>
  <div>
    <pv-toast></pv-toast>
    <header>
      <pv-toolbar class="bg-black">
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
              <pv-button
                  class="p-button-text text-white"
                  :href="href"
                  @click="navigate">
                {{ item.label }}
              </pv-button>
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
.bg-black {
  background-color: #1f1e1e;
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  z-index: 1000;
}
</style>
