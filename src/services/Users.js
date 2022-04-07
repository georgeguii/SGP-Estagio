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
                    title: "Authorization",
                    text: "You have been logged in!",
                  });
            })
            .catch((error) => {
                console.log(error);
                notify({
                    title: "Authorization",
                    type: "warn",
                    text: "NEGAAAAAAAAAAADO!"
                  });
            });
    }
}