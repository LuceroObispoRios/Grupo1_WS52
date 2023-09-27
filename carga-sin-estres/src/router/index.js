import CompanyRegistrationForm from '../user-management/pages/CompanyRegistrationForm.vue'
import CompanySettingsForm from '../user-management/pages/CompanySettingsForm.vue'
import ClientSettingsForm from '../user-management/pages/ClientSettingsForm.vue'
import HomeView from "../public/pages/HomeView.component.vue";
import FormularioPage from "../membership/pages/FormularioPage.vue";
import BoletaModal from "../membership/pages/BoletaModal.vue";
import bookingList from "../bookingHistory/pages/booking-list.component.vue";

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [
        { path: '/', redirect: 'home'},
        { path: '/**', redirect: 'home'},
        { path: '/home', name: 'home', component: HomeView},
        { path: '/company-search', name: 'company-search', component: CompanyList},
        { path: '/company/:id', name: 'company-detail', component: CompanyDetail, props: true},
        { path: '/login', name: 'login', component: LoginForm},
        { path: '/register-client', name: 'register-client', component: ClientRegistrationForm},
        { path: '/register-company', name: 'register-company', component: CompanyRegistrationForm},
        { path: '/company-settings/:id', name: 'company-settings', component: CompanySettingsForm, props:true},
        { path: '/client-settings/:id', name: 'client-settings', component: ClientSettingsForm, props: true},
        { path: '/bookingHistory', name: 'bookingHistory', component: bookingList},
        { path: '/formulario', component: FormularioPage },
        { path: '/boleta',
            component: BoletaModal,
            props: (route) => ({
                tipoUsuario: route.query.tipoUsuario,
                nombre: route.query.tipoUsuario === 'cliente' ? route.query.nombre : '',
                apellido: route.query.tipoUsuario === 'cliente' ? route.query.apellido : '',
                dni: route.query.tipoUsuario === 'cliente' ? route.query.dni : '',
                nombreEmpresa: route.query.tipoUsuario === 'empresa' ? route.query.nombreEmpresa : '',
                ruc: route.query.tipoUsuario === 'empresa' ? route.query.ruc : '',
                direccion: route.query.direccion,
                tipoMembresia: route.query.tipoMembresia,
                tipoTarjeta: route.query.tipoTarjeta,
                numeroBoleta: route.query.numeroBoleta,
            })
        }
    ]
})
export default router
