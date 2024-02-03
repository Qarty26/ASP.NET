<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
</script>

<template>

  <div class="flex flex-row items-center justify-between p-2 px-10">
    <RouterLink to="/home">
      <font-awesome-icon icon="fa-solid fa-house"
                         class="text-textHeading dark:text-textHeading"
                         size="xl"
      />
    </RouterLink>
  </div>

</template>

<style scoped>

</style>
