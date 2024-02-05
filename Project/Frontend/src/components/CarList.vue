<script setup lang="ts">
import type {ICar} from "@/models/Car";
import Car from "@/components/Car.vue";

const props = defineProps<{
  cars: ICar[]
}>();

const emits = defineEmits<{
  (e: 'car-delete', payload: {
    carId: string
  }): void
}>();

const handleCarDeleteEmit = (payload: any) => {
  emits('car-delete', payload);
}

</script>

<template>

  <div class="overflow-x-auto">
    <Car v-for = "(car, index) in props.cars"
         :key = "index"
         :cars = "car"
         @car-delete = "handleCarDeleteEmit"
    />
  </div>
</template>