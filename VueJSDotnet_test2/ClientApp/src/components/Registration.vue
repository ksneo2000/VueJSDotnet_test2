<template>

    <div class="hello">

        <h1>Registration</h1>

        <form action="UserRegistration"  method="get">
            <p><b>ЛОГИН:</b><br></p>
            <input type="text" id="name" name="name" size="40" />
            <p><b>Password:</b><br></p>
            <input type=password id="password" name="password" size="38" />
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
    

export default {
  name: 'Registration',
  components: {
      
  },
  props: {
      
  },
  methods: {
      clickone: function () {
          console.log("YYYYYY");
          
          
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
