import { createWebHistory, createRouter } from "vue-router";
import Home from "@/components/Home.vue";
import Counter from "@/components/Counter.vue";
import FetchData from "@/components/FetchData.vue";
import Smile from "@/components/Smile.vue";
import TextWrite from "@/components/TextWrite.vue";
import TextDataWrite from "@/components/TextDataWrite.vue";
import Registration from "@/components/Registration.vue";
import RegistrationTest from "@/components/RegistrationTest.vue";






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
        path: "/Smile",
        name: "Smile",
        component: Smile,
    },
    {
        path: "/TextWrite",
        name: "TextWrite",
        component: TextWrite,
    },
    {
        path: "/TextDataWrite",
        name: "TextDataWrite",
        component: TextDataWrite,
    },
    {
        path: "/Registration",
        name: "Registration",
        component: Registration,

    },
    {
        path: "/RegistrationTest",
        name: "RegistrationTest",
        component: RegistrationTest,

    }
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;