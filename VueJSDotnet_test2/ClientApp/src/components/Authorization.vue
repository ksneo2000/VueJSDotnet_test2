<template>
    <div class="hello">

        <h1>Authorization</h1>

       
        <p><b>Введите логин:</b><br></p>
        <input v-model="name" type="text" id="name" name="name" size="40" />
        <p><b>Введите пароль:</b><br></p>
        <input v-model="password" type=password id="password" name="password" size="38" />
        <input type="button" value=" ">
        <p><b>Если нет учетной записи пройдите регистрацию:</b><br></p>
        <p><b><a href="Registration">ТУТ</a></b><br></p>
        <br>
        <br>
        <button v-on:click="clickone">OK</button>
       

        <br>

        <img src="../assets/logo.png" />


    </div>
</template>

<script>
    import axios from 'axios'
    import router from "../router/index.js";


 export default {


  name: 'Autorization',
  components: {
      
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
                  router.push({ path: '/' })
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
</style>
