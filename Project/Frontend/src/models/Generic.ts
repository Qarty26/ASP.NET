import axios from '@/helpers/AxiosInstance'
export abstract class Generic {
    protected routeName: string = '';

    public all = async (params: string = '') => {
        return await axios.get(`${this.routeName}/get_all${params}`)
            .then((response) => response.data)
            .catch((error) => {
                if (error.response.status == 404) {
                    console.log(error.response.data.message);
                }
                console.error(error.response);
                return [];
            });
    }

    public create = async (payload: any) => {
        return await axios.post(`${this.routeName}/create`, payload)
            .then((response) => response.data)
            .catch((error) => {
                console.error(error.response);
                throw error.response.data.title;
            })
    }
}