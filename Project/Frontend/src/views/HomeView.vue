<script setup lang="ts">
import TrackList from "@/components/TrackList.vue";
import { ref } from 'vue';
import type {ITrack} from "@/models/Track";
import {Track} from "@/models/Track";


const trackWorker = new Track();
const trackList = ref<ITrack[]>([]);
const areTracksLoaded = ref(false);
const fetchTracks = async() => {
  trackList.value = await trackWorker.all_map();
  areTracksLoaded.value = true;
}
fetchTracks();

</script>

<template>
  <TrackList v-if="areTracksLoaded"
             :tracks = "trackList"/>
</template>
