import axios from 'axios'

export default axios.create({
    baseURL: 'http://localhost:7117/api'
})