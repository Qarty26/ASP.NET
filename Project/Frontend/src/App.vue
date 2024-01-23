<!-- Your main Vue.js file -->
<template>
  <div id="app">
    <google-map></google-map>
  </div>
</template>

<script>
import GoogleMap from './components/GoogleMap.vue'; // Adjust the path based on your project structure

export default {
  components: {
    GoogleMap,
  },
};
</script>
