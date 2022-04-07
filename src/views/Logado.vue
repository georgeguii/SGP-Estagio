<script>
export default {
  name: "Logado",
};
</script>

<template>
  <div class="container-fluid w-50">

    <div id=" signIn">

        <div id="signIn">
          <img src="/img/logo-2.png" alt="" class="d-block mx-auto img-fluid w-50 px-5" />
        </div>

        <div id="signIn">
          <h1>Bem vindo ao Sistema de gestão de Procuradoria de Sergipe</h1>
        </div>

        <div id="signIn">
          <button class="btn btn-submit btn-lg btn-block" @click="Logado()">
            Logout
          </button>
        </div>
    </div>
  </div>
</template>

<style scoped>
#signIn {
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 2%;
  margin-top: 4%;
}

h1{
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