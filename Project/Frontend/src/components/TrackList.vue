<script setup lang="ts">
import type {ITrack} from "@/models/Track";
import Track from "@/components/Track.vue";


const props = defineProps<{
  tracks: ITrack[]
}>();


</script>

<template>
  <div class="overflow-x-scroll">
    <Track v-for = "(track, index) in props.tracks"
    :key = "index"
    :tracks = "track"
    />
    </div>

</template>