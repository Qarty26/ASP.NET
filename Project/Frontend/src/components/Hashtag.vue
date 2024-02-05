<script setup lang="ts">
import type {IHashtag} from "@/models/Hashtag";


const props = defineProps<{
  tags: IHashtag
}>();

const emits = defineEmits<{
  (e: 'tag-delete', payload: {
    tagId: string
  }): void
}>();


</script>

<template>
  <div class="bg-gray-200 p-4 rounded shadow-md">
    <div class="mb-4">
      <div class="flex justify-between">
        <ul>
          <li class="mb-1"><strong class="text-gray-800">Id:</strong> {{ tags.id }}</li>
          <li class="mb-1"><strong class="text-gray-800">Tag:</strong> {{ tags.tag }}</li>
          <li class="mb-1"><strong class="text-gray-800">Xp:</strong> {{ tags.xp }}</li>
        </ul>
      </div>
    </div>
  </div>
</template>