<script setup lang="ts">
import {useAuthStore} from "@/stores/auth.ts";
import {useRouter} from "vue-router";

const authStore = useAuthStore();
const router = useRouter();

function logout() {
  authStore.logOutUser();

  router.push("/");
}
</script>

<template>
  <div>
    <h2>Dashboard</h2>

    <button @click="logout">Logga ut</button>
  </div>
</template>

<style scoped>
@reference "../styles/style.css";

button {
  @apply bg-orange-400 text-white font-bold px-4 py-2 rounded;
}
</style>
