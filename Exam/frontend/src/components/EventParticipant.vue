<script setup lang="ts">
const props = defineProps<{
  idEv: string
  idPart: string
}>()
</script>

<template>
  <div class="flex flex-col justify-between">
    <h1>Id Participant: {{props.idPart }}</h1>
    <p>Id Event: {{ props.idEv }}</p>
  </div>
</template>