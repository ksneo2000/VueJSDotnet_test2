﻿<template>
    <div class="hello">

        <h1>Authorization</h1>
            <form @submit.prevent>
                <div>
                    <div>

                        <div>
                            <p><b>Введите логин:</b><br></p>
                        </div>
                        <div>
                            <my-input v-model="name"
                                      type="text"
                                      placeholder="Имя" />
                        </div>

                    </div>
                    <div>
                        <div>
                            <p><b>Введите пароль:</b><br></p>
                        </div>

                        <my-input-password v-model="password" />
                        
                    </div>
                        <p><b>Если нет учетной записи пройдите регистрацию:</b><br></p>
                    <p><b><a href="Registration">ТУТ</a></b><br></p>
                    <br>
                    <br>
                    <my-button v-on:click="clickone">OK</my-button>
                </div>
                

            </form>

            <br>

            <img src="../assets/logo.png" />


    </div>
</template>

<script>
    import axios from 'axios'
    import router from "../router/index.js";
    import MyButton from './UI/MyButton.vue';
    import MyInput from './UI/MyInput.vue';
    import MyInputPassword from './UI/MyInputPassword';
    

    export default {


        name: 'Autorization',

        components: {
            MyButton,
            MyInput,
            MyInputPassword,
           
        },

        
        data() {
            return {
                name: '',
                password: ''
            }
        },

        methods: {
            clickone() {
                const article = { name: this.name, password: this.password };
         
                axios({
                    method: 'Post',
                    url: '/UserRegistration/Autorization',
                    data: article

                })
                    .then(function (response) {
                        console.log(response.data);

                        router.push({ path: '/Answer/' + response.data})
                    })
                    .catch(function (error) {
                        console.log(error);
                    });

                console.log(article);

            }
          
        }
        
  

    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    h3 {
      margin: 40px 0 0;
    }
    ul {
      list-style-type: none;
      padding: 0;
    }
    li {
      display: inline-block;
      margin: 0 10px;
    }
    a {
        color: #42b983;
    }

    .my-div-centr {
        display: flex;
        margin: 0 auto;
        justify-content: center;
        border: 1px solid teal;
        width: 70%;
    }
    .my-btn{
        margin-top:5px;
    }

    .my-inp {
        margin-top: 5px;
        border: none;
        
    }
</style>
