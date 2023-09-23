<script>
  import { cargaSinEstresApiService } from "../services/cargaSinEstres-api.service";
  import { FilterMatchMode } from "primevue/api";
  export default{
    name: "company-list",
    data(){
      return{
        companies: [],
        company: {},
        companyService: null,
        filters: {},
      };
    },
    created(){
      this.companyService = new cargaSinEstresApiService();
      this.companyService.getAll()
          .then((response) => {
            this.companies = response.data;
            console.log("Companies:");
            console.log(this.companies);
      });
      this.initFilters();
    },
    methods:{
      initFilters(){
        this.filters = {
          global:{
            value: null,
            matchMode: FilterMatchMode.CONTAINS,
          }
        }
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
      }
    }
  }
</script>

<template>
  <div>
    <div class="card">
      <pv-toolbar class="mb-4">
        <template #start>
        </template>

        <template #end>
        </template>
      </pv-toolbar>

      <pv-data-table ref="dt" :value="companies" dataKey="id"
                     :paginator="true" :rows="10"
                     :filters="filters"
                     paginatorTemplate="FirstPageLink PrevPageLink PageLinks NextPageLink LastPageLink CurrentPageReport RowsPerPageDropdown"
                     :rowsPerPageOptions="[5, 10, 25]"
                     currentPageReportTemplate="Se muestra {first} - {last} de {totalRecords} empresas"
                     responsiveLayout="scroll"
                     @row-click="handleRowClick"
      >

        <template #header>
          <div class="table-header flex flex-column md:flex-row md:justify-content-between">
            <h5 class="mb-2 md:m-0 p-as-md-center text-xl">Busqueda de empresas</h5>
            <span class="p-input-icon-left">
              <i class="pi pi-search" />
              <pv-input-text v-model="filters['global'].value" placeholder="Buscar..."/>
            </span>
          </div>
        </template>

        <pv-column field="id" header="Id" :sortable="true" style="min-width: 12rem"></pv-column>
        <pv-column field="name" header="Nombre" :sortable="true" style="min-width: 15rem"></pv-column>
        <pv-column field="services" header="Servicios" :sortable="true" style="min-width: 30rem"></pv-column>

        <pv-column field="photo" header="Logo" style="min-width: 12rem">
          <template #body="slotProps">
            <img :src="slotProps.data.photo" alt="Logo" class="w-4 h-4 rounded-full">
          </template>
        </pv-column>

      </pv-data-table>
    </div>
  </div>
</template>


<style scoped>

</style>