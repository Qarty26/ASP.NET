<script setup lang="ts">
import type {ICar} from "@/models/Car";
import Car from "@/components/Car.vue";

const props = defineProps<{
  cars: ICar[]
}>();

</script>

<template>

  <div class="overflow-x-auto">
    <Car v-for = "(car, index) in props.cars"
           :key = "index"
           :cars = "car"
    />
  </div>
</template>