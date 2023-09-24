<template>
  <div>
    <h2>Boleta de Compra</h2>
    <div class="boleta">
      <img src="public/Cargalogo.png" alt="Imagen" style="height: 200px"><br><br>
      <table class="info">
        <tr>
          <td><strong>Nombres:</strong></td>
          <td>{{ nombre }}</td>
        </tr>
        <tr>
          <td><strong>Apellidos:</strong></td>
          <td>{{ apellido }}</td>
        </tr>
        <tr>
          <td><strong>RUC:</strong></td>
          <td>{{ ruc }}</td>
        </tr>
        <tr>
          <td><strong>Dirección:</strong></td>
          <td>{{ direccion }}</td>
        </tr>
        <tr>
          <td><strong>Tipo de Tarjeta:</strong></td>
          <td>{{ tipoTarjeta }}</td>
        </tr>
        <tr>
          <td><strong>Precio de Membresía:</strong></td>
          <td>{{ tipoMembresia }}</td>
        </tr>
      </table>
      <button @click="descargarBoleta">Descargar Boleta</button>
    </div>
  </div>
</template>

<script>
import JsPDF from 'jspdf';  // Importar JsPDF como un módulo ES6

export default {
  name: 'BoletaModal',
  props: {
    nombre: String,
    apellido: String,
    ruc: Number,
    direccion: String,
    tipoMembresia: Number,
    tipoTarjeta: String,
    // numeroBoleta: String,
  },
  methods: {
    descargarBoleta() {
      // Aquí implementamos la lógica para generar y descargar la boleta en PDF con JsPDF

      const doc = new JsPDF();

      // Definir los estilos para el título y el contenido
      const estiloTitulo = { fontSize: 18, fontStyle: 'bold', marginBottom: 10 };
      const estiloContenido = { fontSize: 14, marginBottom: 5 };
      // Agregar el título y el contenido a la boleta
      doc.text('Boleta de Compra', 20, 20);
      doc.text('Nombre:', 20, 40);
      doc.text(this.nombre, 70, 40, estiloContenido);
      doc.text('Apellido:', 20, 55);
      doc.text(this.apellido, 70, 55, estiloContenido);
      doc.text('RUC:', 20, 70);
      doc.text(this.ruc.toString(), 70, 70, estiloContenido);
      doc.text('Dirección:', 20, 85);
      doc.text(this.direccion, 70, 85, estiloContenido);
      doc.text('Tipo de Tarjeta:', 20, 100);
      doc.text(this.tipoTarjeta, 70, 100, estiloContenido);
      doc.text('Precio de Membresía:', 20, 115);
      doc.text(this.tipoMembresia.toString(), 80, 115, estiloContenido);

      // Descargar la boleta como un archivo PDF.
      doc.save('boleta_compra.pdf');
    },
  },
};
</script>

<style scoped>
h2 {
  color: #181818;
  font-size: 24px;
  text-align: center;
}

.boleta {
  text-align: center;
  background-color: #fff;
  border: 1px solid #ccc;
  border-radius: 10px;
  padding: 20px;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
  margin: 20px auto;
  max-width: 400px;
}

.info {
  width: 100%;
}

.info td {
  padding: 10px;
  border-bottom: 1px solid #ccc;
  text-align: left;
}

button {
  background-color: #ee8f00;
  color: #fff;
  padding: 10px 20px;
  border: none;
  border-radius: 5px;
  font-size: 18px;
  cursor: pointer;
  transition: background-color 0.3s ease;
  margin-top: 20px;
  display: block;
  margin-left: auto;
  margin-right: auto;
}

button:hover {
  background-color: #ee8f00;
}
</style>
