<script setup lang="ts">
import type {ITrack} from "@/models/Track"
import { onMounted } from "vue";
import L from "leaflet";


const props = defineProps<{
  tracks: ITrack
}>();

onMounted(() => {

  try{

    const map = L.map("trackMap").setView(
        [props.tracks.relations.map.startLatitude, props.tracks.relations.map.startLongitude],
        13
    );

    L.tileLayer("https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png").addTo(map);

    L.marker([
      props.tracks.relations.map.startLatitude,
      props.tracks.relations.map.startLongitude,
    ]).addTo(map);

  } catch (error)
  {
      console.error('Error initializing Leaflet map:', error);
  }

});


</script>

<template>
  <div class="bg-gray-200 p-4 rounded shadow-md">
    <div class="mb-4">

      <div id="trackMap" class="h-48 w-full mb-2"></div>


      <div class="flex justify-between">
        <div>
          <h2 class="text-xl font-bold mb-2">{{ tracks.name }}</h2>
          <ul>
            <li class="mb-1"><strong class="text-gray-800">ID:</strong> {{ tracks.id }}</li>
            <li class="mb-1"><strong class="text-gray-800">XP:</strong> {{ tracks.xp }}</li>
            <li><strong class="text-gray-800">Confirmed:</strong> {{ tracks.confirmed ? 'Yes' : 'No' }}</li>
          </ul>
        </div>
      </div>
    </div>
  </div>
</template>