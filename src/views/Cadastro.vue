<script>
import Footer from '../components/Footer.vue'
    import Input from "../components/Input.vue"

    export default {
        name: 'Cadastro',
        components: {
            Input,
            Footer
        },
        data() {

        },
        methods: {

        }
    }
</script>

<template>
    <div class="container-fluid">
        <!--<div><img src="/img/logo-2.png" alt=""></div>-->
        <div class="cadastro">
            <div class="w-50 mx-auto">
                
                <label class="">Nome:</label>
                <div class="input-group">
                    <input type="text" class="form-control" placeholder="Digite seu nome" />
                </div>

                <label class="mt-3">E-mail:</label>
                <div class="input-group">
                    <input :type="text" class="form-control" placeholder="Digite seu e-mail" />
                </div>

                <label class="mt-3">Senha:</label>
                <div class="input-group">
                    <input :type="password" class="form-control" placeholder="Digite sua senha" />
                </div>

                <label class="mt-3">Repita sua senha:</label>
                <div class="input-group">
                    <input :type="password" class="form-control" placeholder="Repita sua senha" />
                </div>

            </div>

            <div class="text-center mt-5">
              <button type="submit" class="btn btn-submit btn-lg btn-block px-5" @click="Login()">
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

    .input-group input {
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