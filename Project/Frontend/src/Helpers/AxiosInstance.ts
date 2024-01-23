import axios from 'axios'

export default axios.create({
    baseURL: 'https://localhost:7116/api',
    withCredentials: true
})