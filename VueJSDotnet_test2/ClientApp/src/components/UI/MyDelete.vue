<template>
    <h1>Личный кабинет</h1>
    <h2>О мой белый госпадин неужели вы хотете все удалить пожалейте меня</h2>
    <form @submit.prevent>
        <div class="my-div-centr">
            <div>
                <my-button @click ="clickYes">Да</my-button>
            </div>
            <div>
                <my-button @click ="clickNo">Нет</my-button>
            </div>
        </div>
    </form>


</template>

<script>
    import axios from 'axios'
    import router from '../../router/index.js';
    import MyButton from './MyButton.vue'

    export default {
        name: "my-delete",

        components: {

            MyButton,
            

        },
        props: {
            show: {
                type: Boolean,
                default: true,
            }
        },
        data() {
            return {

            }

        },
        methods: {
            
            clickYes: function () {
                var vrID = parseInt(this.$route.params.id);
                const article = { id: vrID };
                axios({
                    method: 'Post',
                    url: '/UserRegistration/AnswerDelete',
                    data: article

                })
                    .then(function (response) {
                        console.log(response.data);
                        router.push('/Authorization')

                    })
                    .catch(function (error) {
                        console.log(error);
                    });
                console.log(article);

            },
            clickNo() {
                this.$emit('update:show', false)
            },

         

            
        }
        

    }
</script>

<style>
    .my-div-centr {
        display: flex;
        justify-content: center;
    }
</style>


