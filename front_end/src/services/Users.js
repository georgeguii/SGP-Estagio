import axios from "axios";
import { notify } from "@kyvg/vue3-notification";

const link = "http://localhost:5000/users"



export default {
    signUp: (data) => {
        axios
            .post(link, data)
            .then(() => {
                notify({
                    title: "Cadastrado!",
                    type: "success",
                    text: "Usuário cadastrado com sucesso!",
                    speed: 500
                });

                setTimeout(function () { window.location.href = "/" }, 4500);
            })
            .catch((error) => {
                notify({
                    title: "Usuário não cadastrado",
                    type: "error",
                    text: "Erro ao cadastrar usuário",
                    speed: 500
                });
            });
    },

    login: (data) => {
        axios
            .post(link + "/auth", data)
            .then((response) => {
                localStorage.setItem("token", response.data.token)
                window.location.href = "/home"
            })
            .catch((error) => {

            });
    }
}