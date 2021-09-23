<template>
    <h1>
        Вывод основного окна программмы
    </h1>
    <my-input></my-input>
    <br />
    <div v-for="alf in alfs" v-bind:key="alf">
        <my-button v-for="cols in alf" v-bind:key="cols">{{cols.a}} </my-button>
    </div>
    


</template>

<script>
    //import axios from 'axios'
    import MyButton from './UI/MyButton.vue';
    import MyInput from './UI/MyInput.vue';






    export default {
        name: "Alphabet",
        components: {
            MyButton,
            MyInput,
            


        },
        data() {

            return {
                alfs: [
                    [{ a: 'ё' }, { a: '1' }, { a: '2' }, { a: '3' }, { a: '4' }, { a: '5' }, { a: '6' }, { a: '7' }, { a: '8' }, { a: '9' }, { a: '0' }, { a: '-' }, { a: '=' }],
                    [{ a: 'q' }, { a: 'w' }, { a: 'e' }, { a: 'r' }, { a: 't' }, { a: 'y' }, { a: 'u' }, { a: 'i' }, { a: 'o' }, { a: 'p' }, { a: '[' }, { a: ']' }],
                    [{ a: 'a' }, { a: 's' }, { a: 'd' }, { a: 'f' }, { a: 'g' }, { a: 'h' }, { a: 'j' }, { a: 'k' }, { a: 'l' }, { a: ';' }, { a: '' }],
                    [{ a: 'z' }, { a: 'x' }, { a: 'c' }, { a: 'v' }, { a: 'b' }, { a: 'n' }, { a: 'm' }, { a: ',' }, { a: '.' }, { a: '/' }]
                ]
                

            }

        },
        methods: {
           
            },

        

    }
    
</script>

<style>
   
</style>