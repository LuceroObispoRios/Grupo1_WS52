<script>

export default {
  name: "toolbar-home",
  data() {
    return {
      drawer: false,
      items: [
        { label: "Inicio", to: "/" },
        { label: "Iniciar Sesion", to: "/login" },
        { label: "Registrar Cliente", to: "/register-client" },
        { label: "Registrar Empresa", to: "/register-company" },
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
          <h3>Carga Sin Estres</h3>
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

</template>

<style scoped>

</style>