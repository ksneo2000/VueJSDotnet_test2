<template>
    <div class="hello">

        <h1>Registration</h1>


        <p><b>Введите логин:</b><br></p>
        <input v-model="name" type="text" id="name" name="name" size="40" />
        <p><b>Введите пароль:</b><br></p>
        <input v-model="password" type=password id="password" name="password" size="38" />
        <input type="button" value=" ">
        <p><b>Введите повторно пароль:</b><br></p>
        <input v-model="password2" type=password id="password2" name="password2" size="38" />
        <input type="button" value=" ">
        <br>
        <br>
        <span id='hiddenTwoPassword' style="display: none">Введенные Вами пароли не совпадают.</span>
        <span id='hiddenNullName' style="display: none">Поле Имя не может быть пустым.</span>
        <span id='hiddenNullPassword' style="display: none">Поле Пароль не может быть пустым.</span>
        <br>
        <br>
        <button v-on:click="clickone">OK</button>


        <br>

        <img src="../assets/logo.png" />
        <br>



    </div>
</template>

<script>
    import axios from 'axios'
   // import router from "../router/index.js";


    export default {


        name: 'Registration',
        components: {

        },
        props: {

        },
        methods: {
            clickone: function () {
                // добавить проверку на пустоту полей name и password 
                var spTwoPassword = document.getElementById('hiddenTwoPassword');
                if (this.password != this.password2)
                {
                    
                    spTwoPassword.removeAttribute("style");
                }
                else {

                    sp.setAttribute('style',"display: none");
                    const article = { name: this.name, password: this.password, password2: this.password2 };


                    axios({
                        method: 'Post',
                        url: '/UserRegistration/Registration',
                        data: article

                    })
                        .then(function (response) {
                            console.log(response.data);
                         //   router.push({ path: '/Answer' })
                        })
                        .catch(function (error) {
                            console.log(error);
                        });

                    console.log(article);
                }

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
</style>
