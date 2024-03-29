import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import NotFound from '@/views/404PageView.vue'
import RegisterView from "@/views/RegisterView.vue";
import LoginView from "@/views/LoginView.vue";
import CarsView from "@/views/CarsView.vue";


const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/home',
      name: 'home',
      component: HomeView,
      meta: { requiresAuth: false }
    },
    {
      path: '/cars',
      name: 'cars',
      component: CarsView,
      meta: { requiresAuth: false }
    },
    {
      path: '/register',
      name: 'register',
      component: RegisterView,
      meta: { requiresAuth: false }
    },
    {
      path: '/login',
      name: 'login',
      component: LoginView,
      meta: { requiresAuth: false }
    },
    {
      path: '/:pathMatch(.*)*',
      name: 'NotFound',
      component: NotFound,
      meta: { requiresAuth: false }
    }
  ]
})

export default router
