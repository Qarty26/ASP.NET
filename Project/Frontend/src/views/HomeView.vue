<script setup lang="ts">
import { ref } from 'vue';
import TrackList from "@/components/TrackList.vue";
import type {ITrack} from "@/models/Track";
import {Track} from "@/models/Track";

import CarList from "@/components/CarList.vue";
import type {ICar} from "@/models/Car";
import {Car} from "@/models/Car";

import HashtagList from "@/components/HashtagList.vue";
import type {IHashtag} from "@/models/Hashtag";
import {Hashtag} from "@/models/Hashtag";


// Tracks
const trackWorker = new Track();
const trackList = ref<ITrack[]>([]);
const areTracksLoaded = ref(false);
const fetchTracks = async() => {
  trackList.value = await trackWorker.all_map();
  console.log(trackList.value);
  areTracksLoaded.value = true;
}
fetchTracks();

// Cars
const carWorker = new Car();
const carList = ref<ICar[]>([]);
const areCarsLoaded = ref(false);
const fetchCars = async() => {
  carList.value = await carWorker.all();
  console.log(carList.value);
  areCarsLoaded.value = true;
}
fetchCars();

// Hashtags

const tagWorker = new Hashtag();
const tagList = ref<IHashtag[]>([]);
const areTagsLoaded = ref(false);
const fetchTags = async() => {
  tagList.value = await tagWorker.all();
  console.log(tagList.value);
  areTagsLoaded.value = true;
}
fetchTags();

</script>

<template>

    <TrackList v-if="areTracksLoaded"
               :tracks = "trackList"/>
    <div v-else>Error in fetching tracks</div>

  <CarList v-if="areCarsLoaded"
             :cars = "carList"/>
  <div v-else>Error in fetching cars</div>

  <HashtagList v-if="areTagsLoaded"
           :tags = "tagList"/>
  <div v-else>Error in fetching tags</div>

</template>

