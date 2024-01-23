<!-- GoogleMap.vue -->
<template>
  <div>
    <iframe
        width="600"
        height="450"
        style="border:0"
        loading="lazy"
        allowfullscreen
        referrerpolicy="no-referrer-when-downgrade"
        :src="googleMapsEmbedUrl"
    ></iframe>
  </div>
</template>

<script>
export default {
  data() {
    return {
      googleMapsEmbedUrl: `https://www.google.com/maps/embed/v1/place?key=YOUR_GOOGLE_MAPS_API_KEY&q=Space+Needle,Seattle+WA`,
    };
  },
};
</script>

<style scoped>
/* Add any necessary styles for your component */
</style>
