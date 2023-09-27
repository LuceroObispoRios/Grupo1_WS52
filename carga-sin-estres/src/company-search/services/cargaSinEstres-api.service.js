import http from '../../shared/services/http-common';

export class cargaSinEstresApiService{
    getAll() {
        return http.get('/companies');
    }

    getAllBookings() {
        return http.get('/bookingHistory');
    }
    getById(id) {
        return http.get(`/companies/${id}`);
    }

    getClientsForLogin(email, password){
        return http.get( `/clients?email=${email}&password=${password}`);
    }
    getCompaniesForLogin(email, password){
        return http.get( `/companies?email=${email}&password=${password}`);
    }

    createReservation(data) {
        return http.post('/bookingHistory', data);
    }

    createClient(data){
        return http.post('/clients', data);
    }

    createCompany(data){
        return http.post('/companies', data);
    }

    updateClient(id, data) {
        return http.put(`/clients/${id}`, data);
    }

    delete(id) {
        return http.delete(`/companies/${id}`);
    }
    findByTitle(title) {
        return http.get(`/companies?title=${title}`);
    }
}
