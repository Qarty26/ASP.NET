<script setup lang="ts">

import {Car, ICar} from "@/models/Car";
import {ref} from "vue";
import axios from "@/helpers/AxiosInstance";
import TrackList from "@/components/TrackList.vue";
import CarList from "@/components/CarList.vue";


/*ALL*/
const carWorker = new Car();
const carList = ref<ICar[]>([]);
const areCarsLoaded = ref(false);
const fetchCars = async() => {
  carList.value = await carWorker.all();
  console.log(carList.value);
  areCarsLoaded.value = true;
}
fetchCars();
/*ALL BETWEEN*/

const carWorkerBetween = new Car();
const carListBetween = ref<ICar[]>([]);
const areCarsLoadedBetween = ref(false);
const fetchCarsBetween = async(start: number, end: number) => {
    carListBetween.value = await carWorkerBetween.all_between(start, end);
    console.log(carListBetween.value);
    areCarsLoadedBetween.value = true;
}

const intervalHandler = async (data, node) => {
  // Access the values from the submitted form data
  const from = data.from;
  const to = data.to;

  // Call your function with the extracted values
  await fetchCarsBetween(from, to);
};



</script>

<template>

  <CarList v-if="areCarsLoaded"
           :cars = "carList"/>
  <div v-else>Error in fetching cars</div>
  
  <FormKit type="form" @submit="intervalHandler" submit-label="Cars Between">
    <FormKit
        type="text"
        name="from"
        label="from"
        placeholder="from"
        validation="required"
        validation-visibility="live"
    />
    <FormKit
        type="text"
        name="to"
        label="to"
        placeholder="to"
        validation="required"
        validation-visibility="live"
    />
  </FormKit>



    <CarList v-if="areCarsLoadedBetween"
             :cars = "carListBetween"/>
    <div v-else>Error in fetching cars</div>

</template>






