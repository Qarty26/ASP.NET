import axios from 'axios'

export default axios.create({
    baseURL: 'https://localhost:7196/api',
    withCredentials: true
})