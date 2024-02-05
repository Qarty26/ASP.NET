<script setup lang="ts">
import type {IHashtag} from "@/models/Hashtag";
import Hashtag from "@/components/Hashtag.vue";

const props = defineProps<{
  tags: IHashtag[]
}>();

const emits = defineEmits<{
  (e: 'tag-delete', payload: {
    tagId: string
  }): void
}>();

const handleTagDeleteEmit = (payload: any) => {
  emits('tag-delete', payload);
}

</script>

<template>

  <div class="overflow-y-scroll">
    <Hashtag v-for = "(tag, index) in props.tags"
         :key = "index"
         :tags = "tag"
         @tag-delete = "handleTagDeleteEmit"
    />
  </div>
</template>