<template>
    <h1>Личный кабинет</h1>
    <h2>Приветствуем </h2>
   

</template>

<script>
    import axios from 'axios'

    export default {
        name: "Answer",
        data() {
            return{
               id: 0
 
            }
            
        },
        methods: {
            rForecasts: function () {
                //undone необходимо в id сохранить int значение тогда не будет проблемы с запросом post answer
                const article = { id: + this.$route.params.id};
                //TODO добавить метод для отправки в usercontroller данных   
                axios({
                    method: 'Post',
                    url: '/UserRegistration/Answer',
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




