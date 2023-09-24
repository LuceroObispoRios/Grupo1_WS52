<script>
export default {
  name: "footer-content",
  data() {
    return {
      precioMembresia1: 35, // Precio de membresía para 1 mes
      precioMembresia2: 95, // Precio de membresía para 3 meses
      precioMembresia3: 365, // Precio de membresía para 1 año
    };
  },
  methods: {
    redirectToForm(membresiaType) {
      this.$router.push({ path: '/formulario', query: { type: membresiaType } });
    },
  },
}
</script>

<template>
  <footer>
    <div class="container">
      <div class="row">
        <div class="col-md-3">
          <a href="#page" style="color: white;">CARGA SIN ESTRÉS</a><br>
          <img src="/visa-icon.png" alt="Visa" style="width: 50px">
          <img src="/mastercard-icon.png" alt="Mastercard" style="width: 57px">
        </div>
        <div class="col-md-3">
          <a href="#aboutus" style="color: white;">Sobre Nosotros</a><br>
          <a href="#" style="color: white;">Preguntas Frecuentes</a>
        </div>
        <div class="col-md-3">
          <a href="#" style="color: white;">Mi Cuenta</a><br>
          <a href="#" style="color: white;">Registrarse</a>
        </div>
        <div class="col-md-3">
          <p>Contacto: <br> +51 123-456-789</p>
          <p>Lima, Perú</p>
          <a href="#"><img src="/facebook-icon.webp" alt="Facebook"></a>
          <a href="#"><img src="/instagram-icon.webp" alt="Instagram"></a>
          <a href="#"><img src="/linkedin-icon.png" alt="LinkedIn"></a>
          <a href="#"><img src="/youtube-icon.png" alt="YouTube"></a>
        </div>
      </div>
    </div>
  </footer>
</template>

<style scoped>
/* Estilos para el footer */
footer {
  background-color: #1f1e1e;
  color: #fff;
  padding: 30px 0;
}

footer img {
  margin-right: 10px;
}

footer a img {
  max-width: 30px;
  max-height: 30px;
}

</style>
