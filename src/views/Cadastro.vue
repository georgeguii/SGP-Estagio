<script>
import Footer from "../components/Footer.vue";
import Input from "../components/Input.vue";
import Users from "../services/Users.js";

export default {
  name: "Cadastro",
  components: {
    Input,
    Footer
  },
  data() {
    return {
      name: "",
      email: "",
      role: "",
      password: "",
      confirmPassword: "",
    };
  },
  methods: {
    signUp() {
      console.log(this.role);
      var result = this.comparePassword();
      if (!result) {
        console.log("Senhas diferentes.");
        this.$notify({
          title: "Senhas difentes",
          type: "warn",
          text: "As senhas digitadas não equivalem!",
        });
      } else {
        var role = this.role == "Empregado" ? 0 : 1;

        Users.signUp({
          name: this.name,
          email: this.email,
          role,
          password: this.password,
        });

        //setTimeout(function() {window.location.href = "http://localhost:3000/"}, 4500);
        
      }
    },
    comparePassword() {
      return this.password == this.confirmPassword;
    },
  },
};
</script>

<template>
  <div class="container-fluid">
    <div class="cadastro">
      <div class="w-50 mx-auto">
        <div>
          <img
            src="/img/logo-2.png"
            alt=""
            class="d-block mx-auto img-fluid w-50 px-5"
          />
        </div>

        <label class="">Nome:</label>
        <div class="input-group">
          <input
            type="text"
            class="form-control"
            v-model="name"
            placeholder="Digite seu nome"
          />
        </div>

        <label class="mt-3">E-mail:</label>
        <div class="input-group">
          <input
            type="text"
            class="form-control"
            v-model="email"
            placeholder="Digite seu e-mail"
          />
        </div>

        <label class="mt-3">Cargo:</label>
        <div>
          <select class="form-control" v-model="role">
            <option>Empregado</option>
            <option>Gerente</option>
          </select>
        </div>

        <label class="mt-3">Senha:</label>
        <div class="input-group">
          <input
            type="password"
            class="form-control"
            v-model="password"
            placeholder="Digite sua senha"
          />
        </div>

        <label class="mt-3">Repita sua senha:</label>
        <div class="input-group">
          <input
            type="password"
            class="form-control"
            v-model="confirmPassword"
            placeholder="Repita sua senha"
          />
        </div>
      </div>

      <div class="text-center mt-5">
        <button
          type="submit"
          class="btn btn-submit btn-lg btn-block px-5"
          @click="signUp()"
        >
          Cadastrar
        </button>
      </div>
    </div>

    <div class="text-center mt-3">
      <a href="/"><b>Já tenho um login</b></a>
    </div>

    <Footer />
  </div>
</template>

<style scoped>
label {
  font-weight: bold;
}

.input-group input,
.form-control,
option {
  background-color: #efefef;
  color: #555;
  padding: 10px 20px;
}

.cadastro {
  align-items: center;
  justify-content: center;
  margin-top: 4%;
}

.btn-submit {
  background-color: #0263b0;
  color: white;
}

button:hover {
  color: white;
}
</style>