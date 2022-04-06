<script>
import Footer from "../components/Footer.vue";

export default {
  name: "HomeView",
  components: {
    Footer,
  },
  data() {
    return {
      showPassword: false,
      inputPasswordType: "password",
      iconPassword: ["fas", "eye"],
    };
  },
  methods: {
    showPass() {
      this.iconPassword = this.showPassword
        ? ["fas", "eye"]
        : ["fas", "eye-slash"];
      this.showPassword = !this.showPassword;
      this.inputPasswordType = this.showPassword ? "text" : "password";
    },
    Login() {
      //chamada back-end/autent
    }
  },
};
</script>

<template>
  <div class="container-fluid">
    <div class="row">
      <div class="col-lg-6 no-padding bg-image"></div>

      <div class="col-lg-6">
        <div class="container w-75 margin-top">
          <img
            src="/img/logo-2.png"
            alt=""
            class="d-block mx-auto img-fluid w-75 px-5"
          />

          <div class="w-75 mx-auto">
            <label class="mt-5">Usuário:</label>
            <div class="input-group">
              <input
                type="text"
                class="form-control"
                placeholder="Digite o usuário"
              />
            </div>
            <label class="mt-3">Senha:</label>
            <div class="input-group">
              <input
                :type="inputPasswordType"
                class="form-control"
                placeholder="Digite o senha"
              />
              <span class="input-group-text" @click="showPass()"
                ><font-awesome-icon :icon="iconPassword"
              /></span>
            </div>
            <div class="text-center mt-5">
              <button
                type="submit"
                class="btn btn-submit btn-lg btn-block px-5" @click="Login()"
              >
                Entrar
              </button>
            </div>
          </div>
          <div class="text-center mt-3">
            <a href="#Registrar"
              ><b>Registre-se aqui</b></a
            >
          </div>
        </div>

        <Footer />
      </div>
    </div>
  </div>
</template>

<style scoped>
label {
  font-weight: bold;
}

.no-padding {
  padding: 0;
  margin: 0;
  box-sizing: border-box;
}

.margin-top {
  margin-top: 20%;
}

.bg-image {
  background-image: url(https://intranet.pge.se.gov.br/Imagens/fachada-PGE.png);
  background-repeat: no-repeat;
  background-position: center center;
  background-size: 100% 100%;
  flex: 1;
  height: 100vh;
}

.input-group input {
  background-color: #efefef;
  color: #555;
  padding: 10px 20px;
}

.btn-submit {
  background-color: #0263b0;
  color: white;
}
</style>