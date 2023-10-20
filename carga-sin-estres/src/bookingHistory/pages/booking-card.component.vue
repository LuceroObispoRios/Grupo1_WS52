<script>
export default {
  name: "booking-card",
  props: {
    bookingHistory: null
  },
  data() {
    return {
      dialogVisible: false,
      message: {},
      submitted: false,
      chatHeader: '',
    }
  },
  methods: {
    openChat() {
      this.dialogVisible = true;
      this.chatHeader = `Chat con ${this.bookingHistory.hiredCompany.name}`;
      console.log(`this.dialogVisible: ${this.dialogVisible}`)
    },
    hideDialog() {
      this.dialogVisible = false;
      this.submitted = false;
    }
  }
}

</script>

<template>
  <div class="card">
    <pv-panel unstyled class="mr-3 ml-3">
      <template #header>
        <div class="header">{{bookingHistory.id}}. Reserva {{bookingHistory.bookingDate}}</div>
      </template>
      <div class="panel-content p-3">
        <div class="panel-left flex flex-wrap">
          <div class="col">
            <div class="mt-2"><span class="font-bold">Fecha de mudanza: </span>{{bookingHistory.movingDate}}</div>
            <div class="mt-2"><span class="font-bold">Estado de reserva: </span>{{bookingHistory.status}}</div>
            <div class="mt-3"><span class="font-bold">Dirección de recojo: </span>{{bookingHistory.pickupAddress}}</div>
            <div class="mt-1"><span class="mt-3 pt-7 font-bold">Dirección de entrega: </span>{{bookingHistory.destinationAddress}}</div>
            <div class="flex ml-6 mt-3">
              <pv-button v-if="bookingHistory.status ==='En curso'" class="btn-chat hover:bg-gray-300" @click="openChat">
                <div class="pi pi-comment font-bold"></div>&nbsp;<p>chat</p>
              </pv-button>
            </div>
          </div>
          <div class="col">
            <div class="mt-3"><span class="font-bold">Pago total: </span>S/.{{bookingHistory.payment.totalAmount}}</div>
            <div class="mt-2"><span class="font-bold">Empresa contratada: </span>{{bookingHistory.hiredCompany.name}}</div>
          </div>

        </div>
        <div class="panel-right bg-white">
          <img :src="bookingHistory.hiredCompany.logo" :alt="bookingHistory.hiredCompany.name"
               class="lg:border-round" width="150" height="150">
        </div>

        
      </div>
    </pv-panel>
    <div>
      <pv-dialog
          v-model:visible="dialogVisible"
          :style="{ width: '450px' }"
          :header="chatHeader"
          :modal="true"
          class="p-fluid">
        <div class="flex align-content-center justify-content-center bg-white">
          <img :src="bookingHistory.hiredCompany.logo" :alt="bookingHistory.hiredCompany.name"
               class="lg:border-round" width="150" height="150">
        </div>

        <div class="field">
        <span class="p-float-label">
          <pv-textarea
              id="content"
              v-model="message.content"
              placeholder="Escriba aquí su mensaje..."
              autofocus
              required="false"
              rows="5"
              cols="20"
          />
          <label for="description"></label>
        </span>
        </div>
        <template #footer>
          <pv-button
              :label="'cancelar'.toUpperCase()"
              icon="pi pi-times"
              class="p-button-text"
              @click="hideDialog"/>
          <pv-button
              :label="'Enviar'.toUpperCase()"
              icon="pi pi-check"
              class="p-button-text"/>
        </template>

      </pv-dialog>
    </div>

  </div>

</template>

<style scoped>
.card {
  margin-top: 20px;
  font-family: sans-serif;
}

.header {
  font-weight: bold;
  font-size: 18px;
  background-color: #D9D9D9;
  padding: 10px;
  border-radius: 5px 5px 0 0;
}

.panel-content {
  display: flex;
  justify-content: space-between;
  align-items: center;
  background-color: #FFF9F9;
  border-radius: 0 0 5px 5px;
}

.panel-left {
  flex: 1;
  font-size: 15px;
}

.panel-right {
  margin-left: 20px;
}
.btn-chat {
  font-family: sans-serif;
  background-color: #FDAE39;
  padding: 0 25px;
}
</style>
