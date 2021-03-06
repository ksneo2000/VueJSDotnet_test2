import { createWebHistory, createRouter } from "vue-router";
import Home from "@/components/Home.vue";
import Counter from "@/components/Counter.vue";
import FetchData from "@/components/FetchData.vue";
import Registration from "@/components/Registration.vue";
import Authorization from "@/components/Authorization.vue";
import Answer from "@/components/Answer.vue";
import Edit from "@/components/Edit.vue";
import Alphabet from "@/components/Alphabet.vue";
import TempKS from "@/components/TempKS.vue";
import EditText from "@/components/EditText.vue";




const routes = [
    {
        path: "/",
        name: "Home",
        component: Home,
    },
    {
        path: "/Counter",
        name: "Counter",
        component: Counter,
    },
    {
        path: "/FetchData",
        name: "FetchData",
        component: FetchData,
    },
    {
        path: "/Registration",
        name: "Registration",
        component: Registration,

    },
    {
        path: "/Authorization",
        name: "Authorization",
        component: Authorization,

    },
    {
        path: "/Answer/:id",
        name: "Answer",
        component: Answer,

    },
    {
        path: "/Edit/:id",
        name: "Edit",
        component: Edit,

    },
    {
        path: "/Alphabet",
        name: "Alphabet",
        component: Alphabet,
    },
    {
        path: "/TempKS",
        name: "TempKS",
        component: TempKS,
    },
    {
        path: "/EditText",
        name: "EditText",
        component: EditText,
    }

    
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;