<template>
    <div class="hello">

        <h1>Registration</h1>

        <form method="post" name="test1">
            <p><b>Логин:</b><br></p>
            <input v-model="name" type="text" id="name" name="name" size="40" />
            <p><b>Password:</b><br></p>
            <input v-model="password" type=password id="password" name="password" size="38" />
            <input type="button" value=" ">
            <br>
            <br>
            <button v-on:click="clickone">OK</button>
        </form>

        <br>

        <img src="../assets/logo.png" />


    </div>
</template>

<script>
    import axios from 'axios'


 export default {


  name: 'Registration',
  components: {
      
  },
  props: {
      
  },
  methods: {
      clickone: function () {
          const article = { name: this.name, password: this.password };
          axios.post("/UserRegistrationTest", article)
              .then(response => this.articleId = response.data.id);
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
