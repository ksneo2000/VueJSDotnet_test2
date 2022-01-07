<template>
    <h1>Личный кабинет</h1>
    <h2>Измени меня белый господин </h2>
    <form @submit.prevent>
        <div>
            <div>
                <h2><strong>Имя: </strong>{{users.name}}</h2>
            </div>
            <div>
                <my-input v-model="users.name"
                          type="text">

                </my-input>
            </div>
        </div>
        <div>
            <div>
                <h2><strong>Фамилия: </strong>{{users.surname}}</h2>
            </div>
            <div>
                <my-input v-model="users.surname"
                          type="text">

                </my-input>
            </div>
        </div>
        <div>
            <div>
                <h2><strong>E-mail: </strong>{{users.email}}</h2>
            </div>
            <div>
                <my-input v-model="users.email"
                            type="text">

                </my-input>
            </div>
        </div>
        <div>
            <my-button @click="Alteration_Edit">Сохранить</my-button>
        </div>
        
    </form>


</template>

<script>
    import axios from 'axios';
    import router from "../router/index.js";
    import MyInput from './UI/MyInput.vue';
    import MyButton from './UI/MyButton.vue';
    

    export default {
        name: "Edit",
        components: {
           
            MyInput,
            MyButton,
            
        },
        data() {
            return {
                id: 0,
                vrID: 0,
                users: [],
               
                
            }
            
        },
        methods: {
            AllEdit() {
                var vrID = parseInt(this.$route.params.id);
                const article = { id: vrID };
                axios({
                    method: 'Post',
                    url: '/UserRegistration/Edit',
                    data: article

                })
                    .then((response) => {
                        this.users = response.data;


                    })
                    .catch(function (error) {
                        console.log(error);
                    });
                console.log(article);

            },
            Alteration_Edit() {
                var article = this.users;
                axios({
                    method: 'Post',
                    url: '/UserRegistration/Alteration_Edit',
                    data: article

                })
                    .then((response) => {
                        this.users = response.data;
                        router.push({ path: '/Answer/' + response.data})
                        console.log(response.data);


                    })
                    .catch(function (error) {
                        console.log(error);
                    });
                console.log(article);

            }

           
        },
        mounted() {
            this.AllEdit();
        }

    }
</script>

<style>
    .my-frame {
        margin: 10px;
        border: 2px solid teal
    }

</style>



