<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import axios from "./helpers/AxiosInstance";
import { getMessaging, getToken, onMessage } from 'firebase/messaging'
import { initializeApp } from 'firebase/app'
import { store } from './helpers/Authenticated'
import { useToast } from 'vue-toastification'

const toast = useToast();

// ============ FIREBASE ============
// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
  apiKey: "AIzaSyDLTJBG2SJyI0zbU3qob92loVWMfpkgRLs",
  authDomain: "roads-26.firebaseapp.com",
  projectId: "roads-26",
  storageBucket: "roads-26.appspot.com",
  messagingSenderId: "127773741795",
  appId: "1:127773741795:web:c5fcc9d63b575e0010ebd6",
  measurementId: "G-GPSMH3S6MV"
};



// Initialize Firebase
const app = initializeApp(firebaseConfig)
const messaging = getMessaging()

onMessage(messaging, (payload) => {
  toast.info(payload.notification?.body);
})


getToken(messaging, {
  vapidKey:
      'BCtxWVvAUcwHcunz-dcX-cek_3l6dsqNawBarMbQFWcC1AlaVWNItND25NFID9KBeQhA8g5sPAkBw1GdTNzdKV8'
})
    .then((currentToken) => {
      if (currentToken) {
        if (store.isAuthenticated === true) {
          axios.patch(`User/device-token/${currentToken}`);
          localStorage.setItem('device_token',currentToken);
        }
      } else {
        console.log('No registration token available. Request permission to generate one.')
      }
    })
    .catch((err) => {
      console.log('An error occurred while retrieving token. ', err)
    })


</script>

<template>

  <div class="flex flex-row items-center justify-between p-2 px-10">
    <RouterLink to="/home">
      Home
    </RouterLink>
  </div>

</template>

<style scoped>

</style>
