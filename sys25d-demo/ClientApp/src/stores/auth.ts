import { ref, computed } from 'vue'
import { defineStore } from 'pinia'

export const useAuthStore = defineStore('auth', () => {
  const isLoggedIn = ref(false);

  function logInUser() {
    isLoggedIn.value = true;
  }

  function logOutUser() {
    isLoggedIn.value = false;
  }

  function isUserLoggedIn() {
    return isLoggedIn.value;
  }

  return { logInUser, logOutUser, isUserLoggedIn };
})
