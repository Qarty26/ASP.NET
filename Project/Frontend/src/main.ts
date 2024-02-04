import './assets/main.css'

import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import Toast, { type PluginOptions, POSITION } from 'vue-toastification'
import { defaultConfig, plugin } from '@formkit/vue'
import config from '../formkit.config'


const app = createApp(App)

const options: PluginOptions = {
    position: POSITION.BOTTOM_RIGHT
};

app.use(router)
app.use(Toast, options);
app.use(plugin, defaultConfig(config))
app.mount('#app')

