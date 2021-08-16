<template>
    <h1>Личный кабинет</h1>
    <h2>Измени меня белый господин </h2>

    <div>
        <div>
            <h2><strong>Имя: </strong>{{users.name}}</h2>
        </div>
        <div>
            <my-input placeholder="неполучается">

            </my-input>
        </div>
    </div>
    <div>
        <div>
            <h2><strong>Фамилия: </strong>{{users.surname}}</h2>
        </div>
        <div>
            <my-input placeholder="неполучается">

            </my-input>
        </div>
    </div>
    <div>
        <div>
            <h2><strong>E-mail: </strong>{{users.email}}</h2>
        </div>
        <div>
            <my-input placeholder="неполучается">

            </my-input>
        </div>
    </div>
    <div>
        <my-button>Сохранить</my-button>
    </div>


</template>

<script>
    import axios from 'axios';
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



