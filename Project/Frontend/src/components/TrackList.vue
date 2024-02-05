<script setup lang="ts">
import type {ITrack} from "@/models/Track";
import Track from "@/components/Track.vue";


const props = defineProps<{
  tracks: ITrack[]
}>();

const emits = defineEmits<{
  (e: 'track-delete', payload: {
    trackId: string
  }): void
}>();

const handleTrackDeleteEmit = (payload: any) => {
  emits('track-delete', payload);
}


</script>

<template>
<!--  <div class="overflow-x-scroll">-->
    <Track v-for = "(track, index) in props.tracks"
           :key = "index"
           :tracks = "track"
           @track-delete = "handleTrackDeleteEmit"
    />
<!--    </div>-->

</template>