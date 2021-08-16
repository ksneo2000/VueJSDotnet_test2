<template>
    <div>
        <div>
            <h1>Личный кабинет</h1>
        </div>
        <div>
            <h2>Приветствуем тебя белый господин</h2>
        </div>
        <div class="my-frame">
            <h2><strong>Имя: </strong>{{users.name}}</h2>
        </div>
        <div class="my-frame">
            <h2><strong>Фамилия: </strong>{{users.surname}}</h2>
        </div>
        <div class="my-frame">
            <h2><strong>E-mail: </strong>{{users.email}}</h2>
        </div>
        <form @submit.prevent>
            <div class="my-div-centr">
                <div>
                    <my-button v-on:click="clickEdit">Редактировать</my-button>
                </div>
                <div>
                    <my-button v-on:click="clickDelete">Удалить</my-button>
                </div>
            </div>
            <div>
                <my-dialog v-model:show="dialogVisible">
                    <my-delete v-model:show="dialogVisible">
                        
                    </my-delete>
                </my-dialog>
            </div>
        </form>
        <div>

        </div>
    </div>


</template>

<script>
    import axios from 'axios'
    import router from "../router/index.js";
    import MyButton from './UI/MyButton.vue'
    import MyDelete from './UI/MyDelete.vue'
    import MyDialog from './UI/MyDialog.vue'

    

    export default {
        name: "Answer",
        components: {
            MyButton,
            MyDelete,
            MyDialog,
        },
        data() {
            return{
                id: 0,
                vrID: 0,
                users: [],
                dialogVisible: false,
            }
            
        },
        methods: {
            AllAnswer() {

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

            
            clickEdit() {
                var vrID = parseInt(this.$route.params.id);
                const article = { id: vrID };
                axios({
                    method: 'Post',
                    url: '/UserRegistration/AnswerEdit',
                    data: article

                })
                    .then(function (response) {
                        console.log(response.data);
                        router.push({ path: '/Edit/' + response.data })

                    })
                    .catch(function (error) {
                        console.log(error);
                    });
                console.log(article);

            },

            clickDelete() {
                this.dialogVisible = true;

            }
        },
        mounted() {
            this.AllAnswer();
        }

    }
</script>
<style>
    
    .my-div-centr {
        display: flex;
        justify-content: center;
    }
    .my-frame {
        margin: 10px;
        border: 2px solid teal
    }

</style>




