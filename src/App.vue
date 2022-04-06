<script setup>
import { RouterLink, RouterView } from "vue-router";
import Login from "./views/Login.vue";
</script>

<template>
  <Login />
  <RouterView />
</template>

<style>
@import url('https://fonts.googleapis.com/css2?family=Open+Sans:wght@400;500;600&display=swap');

* {
  font-family: Arial, Helvetica, sans-serif;
  font-size: 14px;
}
</style>
