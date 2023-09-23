import { createRouter, createWebHistory } from 'vue-router'
import CompanyList from '../company-search/pages/company-list.component.vue'
import CompanyDetail from '../company-search/pages/detail-company.component.vue'
import LoginForm from '../user-management/pages/LoginForm.vue'
import ClientRegistrationForm from '../user-management/pages/ClientRegistrationForm.vue'
import CompanyRegistrationForm from '../user-management/pages/CompanyRegistrationForm.vue'
import CompanySettingsForm from '../user-management/pages/CompanySettingsForm.vue'
import ClientSettingsForm from '../user-management/pages/ClientSettingsForm.vue'


const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [
        { path: '/', redirect: 'company-search'},
        { path: '/company-search', name: 'company-search', component: CompanyList},
        { path: '/company/:id', name: 'company-detail', component: CompanyDetail, props: true},
        { path: '/login', name: 'login', component: LoginForm},
        { path: '/register-client', name: 'register-client', component: ClientRegistrationForm},
        { path: '/register-company', name: 'register-company', component: CompanyRegistrationForm},
        { path: '/company-settings', name: 'company-settings', component: CompanySettingsForm},
        { path: '/client-settings/:id', name: 'client-settings', component: ClientSettingsForm, props: true},
    ]
})
export default router