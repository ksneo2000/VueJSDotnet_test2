<template>
    <h1>Личный кабинет</h1>
    <h2>Приветствуем тебя белый господин  {{users.name}}</h2>
    <button v-on:click="clickEdit">Редактировать</button>
    <button v-on:click="clickDelete">Удалить</button>



</template>

<script>
    import axios from 'axios'

    export default {
        name: "Answer",
        data() {
            return{
                id: 0,
                vrID: 0,
                users: []
            }
            
        },
        methods: {
            rForecasts: function () {
                var vrID = parseInt(this.$route.params.id);
                const article = { id: vrID };
                axios({
                    method: 'Post',
                    url: '/UserRegistration/Answer',
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
            clickEdit: function () {
                var vrID = parseInt(this.$route.params.id);
                const article = { id: vrID };
                axios({
                    method: 'Post',
                    url: '/UserRegistration/AnswerEdit',
                    data: article

                })
                    .then(function (response) {
                        console.log(response.data);

                    })
                    .catch(function (error) {
                        console.log(error);
                    });
                console.log(article);

            },
            clickDelete: function () {
                var vrID = parseInt(this.$route.params.id);
                const article = { id: vrID };
                axios({
                    method: 'Post',
                    url: '/UserRegistration/AnswerDelete',
                    data: article

                })
                    .then(function (response) {
                        console.log(response.data);

                    })
                    .catch(function (error) {
                        console.log(error);
                    });
                console.log(article);

            }
        },
        mounted() {
            this.rForecasts();
        }

    }
</script>




