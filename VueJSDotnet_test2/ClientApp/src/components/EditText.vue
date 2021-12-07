<template>
    
    <h1>
        Форма для загрузки текста в базу
    </h1>
    <div>
        <div>
            <my-input v-model="myTextName"
                      type="myTextName"
                      placeholder="Введите название текста" />
        </div>
        <div>
            <my-input v-model="myTextContent"
                      type="myTextContent"
                      placeholder="Введите текст" />
        </div>
        <form @submit.prevent>
            <div>
                <my-button v-on:click="clickEditText">
                    Загрезка
                </my-button>
            </div>
        </form>
    </div>

</template>

<script>
    import MyButton from './UI/MyButton.vue';
    import MyInput from './UI/MyInput.vue';
    import axios from 'axios';
    /*import router from "../router/index.js";*/

    export default {


        name: 'EditText',

        components: {
            MyButton,
            MyInput,
            
        },
        data() {
            return {
                myTextName: '',
                myTextContent: '',
                
            }
        },

        methods: {
            clickEditText() {
                const article = {
                    
                    Name: this.myTextName,
                    MyContent: this.myTextContent
                };

                axios({
                    method: 'Post',
                    url: '/Text/TextInput',
                    data: article

                })
                    .then(function (response) {
                        console.log(response.data);

                        /*router.push({ path: '/Answer/' + response.data })*/
                    })
                    .catch(function (error) {
                        console.log(error);
                    });

                console.log(article);

            }

        }
    }
</script>
<style>
    
    

</style>




