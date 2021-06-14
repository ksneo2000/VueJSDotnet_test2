import { createWebHistory, createRouter } from "vue-router";
import Home from "@/components/Home.vue";
import Counter from "@/components/Counter.vue";
import FetchData from "@/components/FetchData.vue";
import Registration from "@/components/Registration.vue";
import Authorization from "@/components/Authorization.vue";


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

    }
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;