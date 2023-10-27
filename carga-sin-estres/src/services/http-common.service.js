import http from '../shared/services/http-common';

export class HttpCommonService{
    getAll() {
        return http.get('/companies');
    }
    getById(id) {
        return http.get(`/companies/${id}`);
    }
    // booking history
    getWorkersById(id){
        return http.get(`/workers?id=${id}`);
    }

    updateWorkerComment(id, data) {
        return http.patch(`/workers/${id}`, data);
    }

    getAllBookings() {
        return http.get('/bookingHistory');
    }
    getBookingsByClient(id) {
        return http.get(`/bookingHistory?idClient=${id}`);
    }
    getBookingsByCompany(id) {
        return http.get(`/bookingHistory?idCompany=${id}`);
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
        return http.patch(`/clients/${id}`, data);
    }

    updateCompany(id, data) {
        return http.patch(`/companies/${id}`, data);
    }

    delete(id) {
        return http.delete(`/companies/${id}`);
    }
    findByTitle(title) {
        return http.get(`/companies?title=${title}`);
    }
    getClientById(id) {
        return http.get(`/clients/${id}`);
    }
    addReview(companyId, review) {

        review.companyId = companyId;
        return http.post(`/reviews`, review);
    }
    getReviews() {
        return http.get('/reviews')
    }

}
