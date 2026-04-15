<script setup lang="ts">
import { RouterView } from 'vue-router';
import { ref } from "vue";

const username = ref('');
const password = ref('');

function loginUser(e: MouseEvent) {
  e.preventDefault();

  console.log('klickade på knappen');
  console.log(username.value);
  console.log(password.value);
}
</script>

<template>
  <h1>Hello World</h1>

  <form>
    <label>
      <span>Användarnamn:</span>
      <input type="text" v-model="username">
    </label>

    <label>
      <span>Lösenord:</span>
      <input type="password" v-model="password">
    </label>

    <button @click="loginUser">Login</button>
  </form>

  <RouterView />
</template>

<style scoped>
@reference "./styles/style.css";

h1 {
  font-size: 3rem;
  font-weight: bold;
}

label input {
  @apply border px-2;
}

button {
  @apply bg-orange-400 text-white font-bold px-4 py-2 rounded;

  /*
  background-color: orange;
  color: white;
  font-weight: bold;
  padding-inline: 8px;
  padding-block: 4px;
  border-radius: 8px;
   */
}
</style>
