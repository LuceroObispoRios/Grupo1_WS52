import axios from 'axios';

export default axios.create({
    baseURL: 'http://cargasinestres-001-site1.ftempurl.com/api/v1',
    headers: {'Content-type': 'application/json' }
});
