<script>
  import { cargaSinEstresApiService } from "../services/cargaSinEstres-api.service";
  import { FilterMatchMode } from "primevue/api";
  import toolbarClient from "@/public/pages/toolbar-client.component.vue";
  export default{
    name: "company-list",
    components:{
      toolbarClient,
    },
    data(){
      return{
        companies: [],
        companyService: null,

        originalData: [],

        manualCompanyName: "",

        selectedServices: [],
        serviceOptions: [ // Opciones de servicios
          { label: 'Transporte', value: 'transporte' },
          { label: 'carga', value: 'carga' },
          { label: 'Embalaje', value: 'embalaje' },
          { label: 'Montaje', value: 'montaje' },
          { label: 'Desmontaje', value: 'desmontaje' }
        ],

        searchMethod: 'noFilter',
        searchOptions: [
          { label: 'Mi Ubicación', value: 'userLocation' },
          { label: 'Ubicación Manual', value: 'manualLocation' },
          { label: 'Sin filtro', value: 'noFilter' },
        ],
        manualLocation: '',
        userLocation: '', // Ubicación del usuario
      };
    },
    created() {
      this.companyService = new cargaSinEstresApiService();
      this.companyService.getAll()
          .then((response) => {
            const responseData = response.data;
            if (this.originalData.length === 0) {
              this.originalData = [...responseData];
            }
            this.companies = responseData;
            console.log('Original Data:', this.originalData);
          });

      this.getUserDistrict();
      this.searchByName();
      this.searchByServices();
      this.searchByLocation();

    },

    methods:{
      getUserDistrict() {
        //valor de ejemplo (editar cuando se tenga el id de usuario)
        this.userLocation = 'Miraflores';
        console.log('Distrito del usuario:', this.userLocation);
      },

      handleRowClick(event) {
        setTimeout(() => {
          const companyId = event.data.id;
          const companyData= JSON.stringify(event.data);
          this.$router.push({
            path: `/company/${companyId}`,
            name: "company-detail",
            params:{
              id: companyId,
            },
            query:{
              companyData,
            }
          });
        });
      },
      searchByName() {
        if (this.manualCompanyName.trim() === "") {
          // Si el campo de búsqueda está vacío, muestra todas las empresas originales
          this.companies = this.originalData;
        } else {
          this.companies = this.originalData.filter((company) => {
            return company.name.toLowerCase().includes(this.manualCompanyName.toLowerCase());
          });
        }
      },
      searchByServices() {
        if (this.selectedServices.length === 0) {
          this.companies = this.originalData;
        } else {
          this.companies = this.originalData.filter((company) => {
            return this.selectedServices.every((selectedService) => company[selectedService.value]);
          });
        }
      },

      searchByLocation() {
        if (this.searchMethod.value === 'userLocation') {
          this.companies = this.originalData.filter((company) => {
            return company.direccion.toLowerCase().includes(this.userLocation.toLowerCase());
          });
        } else if (this.searchMethod.value === 'manualLocation') {
          this.companies = this.originalData.filter((company) => {
            return company.direccion.toLowerCase().includes(this.manualLocation.toLowerCase());
          });
        } else {
          // Si se selecciona "Sin filtro", no se aplica ningún filtro
          this.companies = this.originalData;
          this.searchMethod = '';
        }
      },

    }
  }
</script>

<template>
  <div>
    <div>
      <toolbar-client></toolbar-client>
    </div>

    <div><h1 class="title flex justify-content-center">Búsqueda de empresas</h1></div>
    <br><br>

    <div class="card">

      <pv-data-table ref="dt" :value="companies" dataKey="id"
                     :paginator="true" :rows="10"
                     paginatorTemplate="FirstPageLink PrevPageLink PageLinks NextPageLink LastPageLink CurrentPageReport RowsPerPageDropdown"
                     :rowsPerPageOptions="[5, 10, 25]"
                     currentPageReportTemplate="Se muestra {first} - {last} de {totalRecords} empresas"
                     responsiveLayout="scroll"
                     @row-click="handleRowClick"
      >

        <template #header>
          <div class="table-header flex flex-column md:flex-row md:justify-content-between">

            <!--Buscar por nombre de empresa-->
            <div class="p-input-icon-left p-field p-fluid">
              <i class="pi pi-search" />
              <pv-input-text v-model="manualCompanyName" @input="searchByName" placeholder="Nombre" />
            </div>

            <!--Buscar por servicios de empresa-->
            <div class="p-field p-fluid">
              <pv-multiselect
                  v-model="selectedServices"
                  :options="serviceOptions"
                  optionLabel="label"
                  placeholder="Selecciona servicios"
                  class="w-full md:w-20rem"
                  @change="searchByServices"
              ></pv-multiselect>
            </div>

            <!-- Selector para elegir método de búsqueda -->
            <div class="p-field p-fluid">
                <pv-dropdown
                    v-model="searchMethod"
                    @change="searchByLocation"
                    class="w-full md:w-14rem"
                    :options="searchOptions"
                    optionLabel="label"
                    placeholder="Selecciona ubicación"
                />
            </div>

            <!-- Buscar por ubicación -->
            <div class="p-field p-fluid" v-if="searchMethod.value === 'manualLocation'">
              <div class="p-input-icon-left ">
                <i class="pi pi-search" />
                <pv-input-text v-model="manualLocation" @input="searchByLocation" placeholder="Dirección"></pv-input-text>
              </div>
            </div>

          </div>
        </template>

        <pv-column field="id" header="Id" :sortable="true" style="min-width: 10rem"></pv-column>
        <pv-column field="name" header="Nombre" :sortable="true" style="min-width: 12rem"></pv-column>
        <pv-column field="services" header="Servicios" style="min-width: 20rem">
          <template #body="slotProps">
            <span v-show="slotProps.data.transporte">Transporte, </span>
            <span v-show="slotProps.data.carga">Carga, </span>
            <span v-show="slotProps.data.embalaje">Embalaje, </span>
            <span v-show="slotProps.data.montaje">Montaje, </span>
            <span v-show="slotProps.data.desmontaje">Desmontaje</span>
          </template>
        </pv-column>
        <pv-column field="direccion" header="Dirección" :sortable="true" style="min-width: 12rem"></pv-column>


        <pv-column field="photo" header="Logo" style="min-width: 20rem">
          <template #body="slotProps">
            <img :src="slotProps.data.photo" alt="Logo" class="w-4 h-4 rounded-full">
          </template>
        </pv-column>

      </pv-data-table>
    </div>
  </div>
</template>


<style scoped>
/*Titulo*/
.title {
  color: #FDAE39;
  font-family: sans-serif;
}

/* Contenedor principal */
.table-header {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
  padding: 1rem;
  background-color: #f4f4f4;
  border-radius: 5px;
}

/* Estilo común para campos de búsqueda */
.p-field.p-fluid {
  margin: 0.5rem;
  display: inline-block;
}

/* Botón de búsqueda */
.pi-search {
  font-size: 1.2rem;
  color: #666;
}

/* Campo de texto */
.p-inputtext {
  font-size: 1rem;
  border: none;
  border-bottom: 2px solid #333;
  border-radius: 0;
  padding: 0.5rem;
  background-color: transparent;
  color: #333;
  transition: border-color 0.3s;
}

/* Cambiar color de la línea inferior en el enfoque */
.p-inputtext:focus {
  border-color: #007BFF;
}

/* Menú desplegable */
.p-dropdown .p-dropdown-label {
  background-color: transparent;
  border: none;
  border-bottom: 2px solid #333;
  border-radius: 0;
  color: #333;
}

/* Cambiar color de la línea inferior en el enfoque */
.p-dropdown .p-dropdown-label:focus {
  border-color: #007BFF;
}

/* Botón de búsqueda */
.p-multiselect .p-multiselect-label {
  font-size: 1rem;
  color: #333;
  background-color: transparent;
  border: none;
  border-bottom: 2px solid #333;
  border-radius: 0;
}

/* Cambiar color de la línea inferior en el enfoque */
.p-multiselect .p-multiselect-label:focus {
  border-color: #007BFF;
}

.card {
  margin: 0 auto;
  width: 80%;
}
</style>
