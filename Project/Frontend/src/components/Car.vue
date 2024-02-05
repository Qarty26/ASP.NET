<script setup lang="ts">
import type { ICar } from '@/models/Car'


const props = defineProps<{
  cars: ICar
}>();

const emits = defineEmits<{
  (e: 'car-delete', payload: {
    carId: string
  }): void
}>();


</script>

<template>
  <div class="bg-gray-200 text-gray-900 p-4 rounded-3xl shadow-md">
    <div class="mb-4">
      <div class="flex-1 justify-between">
          <ul class = "font-extrabold">
            <li class="mb-1"><strong class="text-red-800 font-extrabold">Make:</strong> {{ cars.make }}</li>
            <li class="mb-1"><strong class="text-red-800 font-extrabold">Model:</strong> {{ cars.model }}</li>
            <li class="mb-1"><strong class="text-red-800 font-extrabold">Year:</strong> {{ cars.year }}</li>
            <li class="mb-1"><strong class="text-red-800 font-extrabold">Color:</strong> {{ cars.color}}</li>
          </ul>
      </div>
    </div>
  </div>
</template>