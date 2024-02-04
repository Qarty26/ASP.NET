<script setup lang="ts">
import type {IHashtag} from "@/models/Hashtag";
import Hashtag from "@/components/Hashtag.vue";

const props = defineProps<{
  tags: IHashtag[]
}>();

</script>

<template>

  <div class="overflow-y-scroll">
    <Hashtag v-for = "(tag, index) in props.tags"
         :key = "index"
         :tags = "tag"
    />
  </div>
</template>