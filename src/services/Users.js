import axios from "axios";
import { notify } from "@kyvg/vue3-notification";

const link = "http://localhost:5000/users"



export default {
    signUp: (data) => {
        console.log(data);
        axios
            .post(link, data)
            .then(() => {
                console.log('Usuário cadastrado com sucesso')
                notify({
                    title: "Cadastrado!",
                    type: "success",
                    text: "Usuário cadastrado com sucesso!",
                    speed: 500
                });
            })
            .catch((error) => {
                console.log(error);

                switch (error) {
                    case 400:
                        console.log('Oranges are $0.59 a pound.');
                        break;
                    case "":
                        break;
                    case "":
                        console.log("");
                        break;
                    default:
                        console.log("");
                }

                notify({
                    title: "Usuário não cadastrado",
                    type: "error",
                    text: "Erro ao cadastrar usuário",
                    speed: 500
                });
            });
    }
}