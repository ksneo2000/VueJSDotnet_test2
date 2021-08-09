<template>
    <div class="hello">

        <h1>Authorization</h1>

       
        <p><b>Введите логин:</b><br></p>
        <input class="input" v-model="name" type="text" id="name" name="name" />
        <p><b>Введите пароль:</b><br></p>
        <input class="input" v-model="password" type=password id="password" name="password" size="38" />
        <my-button>O</my-button>
        <p><b>Если нет учетной записи пройдите регистрацию:</b><br></p>
        <p><b><a href="Registration">ТУТ</a></b><br></p>
        <br>
        <br>
        <my-button v-on:click="clickone">OK</my-button>
       

        <br>

        <img src="../assets/logo.png" />


    </div>
</template>

<script>
    import axios from 'axios'
    import router from "../router/index.js";
    import MyButton from './UI/MyButton.vue'

 export default {


  name: 'Autorization',
        components: {

            MyButton,
         },
  props: {
      
  },
  methods: {
      clickone: function () {
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
    .input {
        width: 50%;
        border: 1px solid teal;
        padding: 10px 15px;
        margin-top: 15px;
    }
</style>
