import http from '../../shared/services/http-common';

export class cargaSinEstresApiService{
    getAll() {
        return http.get('/companies');
    }
    getById(id) {
        return http.get(`/companies/${id}`);
    }
    // booking history
    getAllBookings() {
        return http.get('/bookingHistory');
    }
    getBookingsByClient(id) {
        return http.get(`/bookingHistory?idClient=${id}`);
    }
    getBookingsByCompany(id) {
        return http.get(`/bookingHistory?idCompany=${id}`);
    }
    getMessages() {
        return http.get('/chat');
    }
    updateBooking(id, data) {
        return http.put(`/bookingHistory/${id}`, data);
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

    updateCompany(id, data) {
        return http.put(`/companies/${id}`, data); // no lo lee
    }

    delete(id) {
        return http.delete(`/companies/${id}`);
    }
    findByTitle(title) {
        return http.get(`/companies?title=${title}`);
    }
}
