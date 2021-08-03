<template>
    <h1>Личный кабинет</h1>
    <h2>Приветствуем тебя белый господин  {{users.name}}</h2>
   

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
                //undone необходимо в id сохранить int значение тогда не будет проблемы с запросом post answer
                const article = { id: vrID };
                //TODO добавить метод для отправки в usercontroller данных   
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
            }
        },
        mounted() {
            this.rForecasts();
        }

    }
</script>




