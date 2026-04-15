<script setup lang="ts">
import { RouterView } from 'vue-router';
</script>

<template>
  <h1>Bageri-dashboard</h1>

  <RouterView />
</template>

<style scoped>
@reference "./styles/style.css";

h1 {
  font-size: 3rem;
  font-weight: bold;
}
</style>
