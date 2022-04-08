<script>
import Home from "../services/Home.js";

export default {
  name: "Home",
  methods: {
    isManager() {
      Home.isManager();
    },
    isEmployee() {
      Home.isEmployee();
    },
  },
};
</script>

<template>
  <div class="container-fluid w-50">
    <div class="center">
      <img
        src="/img/logo-2.png"
        alt=""
        class="d-block mx-auto img-fluid w-50 px-5"
      />
    </div>

    <div>
      <h1>Verifique seu nível de acesso:</h1>
    </div>

    <div class="center">
      <button
        class="btn btn-submit btn-lg btn-block px-5 mx-auto"
        @click="isManager()"
      >
        Gerente
      </button>
      <button
        class="btn btn-submit btn-lg btn-block px-5 mx-auto"
        @click="isEmployee()"
      >
        Empregado
      </button>
    </div>

      <h4 class="text-center mt-5">Tem uma conta? <router-link to="/">Login</router-link></h4>

      

  </div>
</template>

<style scoped>
.center {
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 2%;
  margin-top: 4%;
}

h1 {
  font-size: 40px;
  text-align: center;
}

.btn-submit {
  background-color: #0263b0;
  color: white;
}

button:hover {
  color: white;
}
</style>