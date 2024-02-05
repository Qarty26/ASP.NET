<script setup lang="ts">
import type {ITrack} from "@/models/Track"
import { onMounted } from "vue";
import L from "leaflet";


const props = defineProps<{
  tracks: ITrack
}>();

const emits = defineEmits<{
  (e: 'track-delete', payload: {
    trackId: string
  }): void
}>();

onMounted(() => {

  try{

    const map = L.map("trackMap").setView(
        [props.tracks.map.startLatitude, props.tracks.map.startLongitude],
        20
    );

    L.tileLayer("https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png").addTo(map);

    L.marker([
      props.tracks.map.startLatitude,
      props.tracks.map.startLongitude,
    ]).addTo(map);

/*    map.off();*/
/*    map.remove();*/


  } catch (error)
  {
      console.error('Error initializing Leaflet map:', error);
  }



});

</script>

<template>
<!--  <div class="bg-black p-4 rounded shadow-md">
    <div class="mb-4">




      <div class="flex justify-between">
        <div>-->
<!--          <div id="trackMap"></div>-->
          <h2 class="text-xl font-bold mb-2">{{ tracks.name }}</h2>
          <ul>
            <li class="mb-1"><strong class="text-gray-800">ID:</strong> {{ tracks.id }}</li>
            <li class="mb-1"><strong class="text-gray-800">XP:</strong> {{ tracks.xp }}</li>
            <li><strong class="text-gray-800">Confirmed:</strong> {{ tracks.confirmed ? 'Yes' : 'No' }}</li>
          </ul>
<!--        </div>
      </div>
    </div>
  </div>-->
</template>