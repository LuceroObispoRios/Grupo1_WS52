import { createRouter, createWebHistory } from 'vue-router'
import CompanyList from '../company-search/pages/company-list.component.vue'
import CompanyDetail from '../company-search/pages/detail-company.component.vue'
import LoginForm from '../user-management/pages/LoginForm.vue'
import ClientRegistrationForm from '../user-management/pages/ClientRegistrationForm.vue'
import CompanyRegistrationForm from '../user-management/pages/CompanyRegistrationForm.vue'
import CompanySettingsForm from '../user-management/pages/CompanySettingsForm.vue'
import ClientSettingsForm from '../user-management/pages/ClientSettingsForm.vue'
import HomeView from "../public/pages/HomeView.component.vue";
import FormularioPage from "../membership/pages/FormularioPage.vue";
import BoletaModal from "../membership/pages/BoletaModal.vue";
import bookingList from "../bookingHistory/pages/booking-list.component.vue";
import ToolbarClientComponent from "@/public/pages/toolbar-client.component.vue";
import ToolbarCompanyComponent from "@/public/pages/toolbar-company.component.vue";

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [
        { path: '/', redirect: 'home'},
        { path: '/home', name: 'home', component: HomeView},
        { path: '/login', name: 'login', component: LoginForm},
        { path: '/register-client', name: 'register-client', component: ClientRegistrationForm},
        { path: '/register-company', name: 'register-company', component: CompanyRegistrationForm},
        // Rutas para el cliente
        {
            path: '/client/:id', component: ToolbarClientComponent,
            children: [
                { path: 'client-settings', name: 'client-settings', component: ClientSettingsForm},
                { path: 'company-search', name: 'company-search', component: CompanyList},
                { path: 'client-booking-history', name: 'client-booking-history', component: bookingList},
                { path: 'company', name: 'company-detail', component: CompanyDetail, props: true},
            ]
        },

        // Rutas para la empresa
        {
            path: '/company/:id', component: ToolbarCompanyComponent,
            children: [
                { path: 'company-settings', name: 'company-settings', component: CompanySettingsForm},
                { path: 'company-booking-history', name: 'company-booking-history', component: bookingList},
                { path: 'formulary', name: 'formulary-company', component: FormularyCompany },
                { path: 'bolette', name: 'bolette-company',
                    component: BoletteCompany,
                    props: (route) => ({
                        nombreEmpresa: route.query.nombreEmpresa,
                        ruc: route.query.ruc,
                        direction: route.query.direction,
                        tipoMembresia: route.query.tipoMembresia,
                        tipoTarjeta: route.query.tipoTarjeta,
                    })
                }
            ]
        },
        { path: '/**', redirect: 'home'}
    ]
})
export default router
