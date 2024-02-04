<script setup lang="ts">
import axios from '../Helpers/AxiosInstance'
import {RouterLink, useRoute, useRouter} from 'vue-router'
import { store } from '@/Helpers/Authenticated'
import { useToast } from 'vue-toastification'

const route = useRoute();
const router = useRouter();
const toast = useToast();

const loginHandler = async (credentials: any) => {
  try {
    let response = await axios.post('User/login', credentials);
    axios.patch(`User/device-token/${localStorage.getItem('device_token')}`);
    store.isAuthenticated = true;
    store.userId = response.data.id;

    const redirectPath = route.query.redirect || '/home'

    router.push({ path: redirectPath });
  } catch (error) {
    toast.error(error?.response.data.message);
  }
}
</script>

<template>
  <header>
    <h1 class="text-2xl text-textLight dark:text-textDark mb-8">Login</h1>
  </header>


  <FormKit type="form" submit-label="Login">
    <FormKit
        type="email"
        name="email"
        label="Email"
        placeholder="client@gmail.com"
        validation="email|required"
        validation-visibility="live"
    />

    <FormKit
        type="password"
        name="password"
        label="Password"
        placeholder="password"
        validation="required|length:8"
        validation-visibility="live"
    />
    <p class="text-textLight dark:text-textDark mb-4 text-xs">
      Don't have an account?
      <RouterLink to="/register" class="underline text-purple-800 dark:text-purple-400"
      >Sign up</RouterLink
      >
    </p>
  </FormKit>

</template>