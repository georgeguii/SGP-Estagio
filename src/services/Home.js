import axios from "axios";
import { notify } from "@kyvg/vue3-notification";

const link = "http://localhost:5000/home"
const config = {
    headers: { Authorization: `Bearer ${localStorage.getItem("token")}` }
};

export default {
    isManager: () => {
        axios
            .get(link+"/manager", config)
            .then(() => {
                notify({
                    title: "Autorizado",
                    type: "success",
                    text: "Acesso de gerente confirmado!",
                    speed: 500
                });
            })
            .catch(() => {
                notify({
                    title: "Não Autorizado",
                    type: "error",
                    text: "Acesso de gerente negado!",
                    speed: 500
                });
            });
    },
    isEmployee: () => {
        axios
            .get(link+"/employee", config)
            .then(() => {
                notify({
                    title: "Autorizado",
                    type: "success",
                    text: "Acesso de empregado confirmado!",
                    speed: 500
                });
            })
            .catch(() => {
                notify({
                    title: "Não Autorizado",
                    type: "error",
                    text: "Acesso de empregado negado!",
                    speed: 500
                });
            });
    }
}