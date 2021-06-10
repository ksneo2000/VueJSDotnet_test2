<template>
    <h1>TEXT_TextWrite</h1>

    <p>TEXT_TextWrite</p>
    <p>{{TextWR}}</p>
  
    
    




</template>


<script>
    import axios from 'axios'

    export default {

        name: "TextWrite",
        props: {
           
        },
        data() {
            return {
                TextWR: String
            }
        },
        methods: {
            getTextWrite() {
                axios.get('/TextWrite')
                    .then((response) => {
                        console.log(response.data.textWR)
                        this.TextWR = response.data.textWR;
                    })
                    .catch(function (error) {
                        alert(error);
                    });
            }
        },
        mounted() {
            console.log("YYYYYY")
            this.getTextWrite();
        }
    }
</script>