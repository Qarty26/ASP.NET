<script setup lang="ts">
import type { ICar } from '@/models/Car'


const props = defineProps<{
  cars: ICar
}>();


</script>

<template>
  <div class="bg-gray-200 p-4 rounded shadow-md">
    <div class="mb-4">
      <div class="flex justify-between">
          <ul>
            <li class="mb-1"><strong class="text-gray-800">Make:</strong> {{ cars.make }}</li>
            <li class="mb-1"><strong class="text-gray-800">Model:</strong> {{ cars.model }}</li>
            <li class="mb-1"><strong class="text-gray-800">Year:</strong> {{ cars.year }}</li>
            <li class="mb-1"><strong class="text-gray-800">Color:</strong> {{ cars.color}}</li>
          </ul>
      </div>
    </div>
  </div>
</template>