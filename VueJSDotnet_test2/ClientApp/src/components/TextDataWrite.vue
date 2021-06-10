<template>
    <h1>TEXT_TextDataWrite</h1>

    <p>TEXT_TextDataWrite</p>
    <p>{{TextDataWR}}</p>
    <p>{{TextDataData}}</p>
    <TextWrite></TextWrite>






</template>


<script>
    import axios from 'axios'
    import TextWrite from './TextWrite.vue'
   
    export default {

        name: "TextDataWrite",
        components: {
            TextWrite
        },
        props: {
            TextWR: String
           
        },
        data() {
            return {
                TextDataWR: String,
                TextDataData: Date
                
            }
        },
        methods: {
            getTextDataWrite() {
                axios.get('/TextDataWrite')
                    .then((response) => {
                        
                        this.TextDataWR = response.data.textDataWR;
                        console.log(response.data.textDataData);
                        this.TextDataData = response.data.textDataData;

                       

                    })
                    .catch(function (error) {
                        alert(error);
                    });
            }
        },
        mounted() {
            
            this.getTextDataWrite();
        }

    }
</script>