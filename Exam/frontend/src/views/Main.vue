<script setup lang="ts">
import axios from '../Helpers/AxiosInstance'
import { ref } from 'vue'
import EventComponent from '@/components/Event.vue'
import ParticipantComponent from '@/components/Participant.vue'
import EventParticipantComponent from '@/components/EventParticipant.vue'

const Events = ref<IEvent[]>([])
const Participants = ref<IParticipant[]>([])
const EventParticipants = ref<IEventParticipant[]>([])

const events = ref<IEvent[]>([])
const participants = ref<IParticipant[]>([])
const eventsParticipants = ref<IEventParticipant[]>([])

const areEventsLoaded = ref<boolean>(false)
const routeNameEvent = 'Event'

const areParticipantsLoaded = ref<boolean>(false)
const routeNameParticipants = 'Participant'

const areEventParticipantsLoaded = ref<boolean>(false)
const routeNameEventParticipants = 'eventsParticipant'

interface IEvent {
  nume: string
  id: string
}
interface IParticipant {
  nume: string
  id: string
}
interface IEventParticipant {
  idEv : string
  idPart: string
}
const fetchEvents = async () => {
  try {
    let response = await axios.get(`${routeNameEvent}/all1`)
    events.value = response.data
    areEventsLoaded.value = true
  } catch (error) {
    console.error(error)
  }
}
const fetchParticipants = async () => {
  try {
    let response = await axios.get(`${routeNameParticipants}/all2`)
    participants.value = response.data
    areParticipantsLoaded.value = true
  } catch (error) {
    console.error(error)
  }
}

const fetchEventParticipants = async () => {
  try {
    let response = await axios.get(`${routeNameEventParticipants}/alleventswithparti`)
    eventsParticipants.value = response.data
    areEventParticipantsLoaded.value = true
  } catch (error) {
    console.error(error)
  }
}

const createEvent = async (payload: any) => {
  try {
    await axios.post(`${routeNameEvent}/create`, payload);
  } catch (e) {
    console.error(e);
  }

  areEventsLoaded.value = false;
  await fetchEvents();
  areEventsLoaded.value = true;
}
//creates
const createParticipant = async (payload: any) => {
  try {
    await axios.post(`${routeNameParticipants}/create`, payload);
  } catch (e) {
    console.error(e);
  }

  areParticipantsLoaded.value = false;
  await fetchParticipants();
  areParticipantsLoaded.value = true;
}

const createEventParticipant = async (payload: any) => {
  try {
    await axios.post(`${routeNameEventParticipants}/create`, payload);
  } catch (e) {
    console.error(e);
  }

  areEventParticipantsLoaded.value = false;
  await fetchEventParticipants();
  areEventParticipantsLoaded.value = true;
}

//deletes

const deleteEvents = async (payload: any) => {
  try {
    await axios.delete(`${routeNameEvent}/delete/${payload.id}`);
  } catch (e) {
    console.error(e);
  }

  areEventsLoaded.value = false;
  await fetchEvents();
  areEventsLoaded.value = true;
}

const deleteParticipants = async (payload: any) => {
  try {
    await axios.delete(`${routeNameParticipants}/delete/${payload.id}`);
  } catch (e) {
    console.error(e);
  }

  areEventsLoaded.value = false;
  await fetchParticipants();
  areEventsLoaded.value = true;
}



</script>

<template>
  <button
      class="border border-purple-700 p-2 hover:cursor-pointer rounded-lg hover:backdrop-brightness-200"
      @click="fetchEvents" >Afiseaza Eventuri</button>
  <div v-if="areEventsLoaded">
    <TestComponent
        class="mb-2 border-b border-white p-2"
        v-for="item in events" :key="item.id" :id="item.id" :name="item.nume" />
  </div>

  <button
      class="border border-purple-700 p-2 hover:cursor-pointer rounded-lg hover:backdrop-brightness-200"
      @click="fetchParticipants" >Afiseaza Participanti</button>
  <div v-if="areParticipantsLoaded">
    <TestComponent
        class="mb-2 border-b border-white p-2"
        v-for="item in participants" :key="item.id" :id="item.id" :name="item.nume" />
  </div>

  <button
      class="border border-purple-700 p-2 hover:cursor-pointer rounded-lg hover:backdrop-brightness-200"
      @click="fetchEventParticipants" >Afiseaza Evenimentele cu Participanti</button>
  <div v-if="areEventParticipantsLoaded">
    <TestComponent
        class="mb-2 border-b border-white p-2"
        v-for="item in eventsParticipants" :key="item.id" :id="item.id" :name="item.nume" />
  </div>

  <FormKit>
    <FormKit type="text" />
  </FormKit>
</template>