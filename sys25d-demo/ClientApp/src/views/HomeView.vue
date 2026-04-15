<script setup lang="ts">
import {onMounted, ref} from "vue";
import {useRouter} from "vue-router";
import {useAuthStore} from "@/stores/auth.ts";

const username = ref('');
const password = ref('');

const authStore = useAuthStore();

const router = useRouter();

if (import.meta.env.DEV) {
  username.value = 'admin';
  password.value = 'password123';
}

function loginUser(e: MouseEvent) {
  e.preventDefault();

  console.log('Login successful');

  authStore.logInUser();

  router.push('/dashboard');

  // fetch('/login', {
  //   method: 'POST',
  //   body: JSON.stringify({
  //     username: username.value,
  //     password: password.value,
  //   }),
  // })
  //   .then(res => res.json())
  //   .then(data => {
  //     console.log(data);
  //   });
}
</script>

<template>
  <main>
    <form>
      <label>
        <span>Användarnamn:</span>
        <input type="text" v-model="username">
      </label>

      <label>
        <span>Lösenord:</span>
        <input type="password" v-model="password">
      </label>

      <br>

      <button @click="loginUser">Login</button>
    </form>
  </main>
</template>

<style scoped>
@reference "../styles/style.css";

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
