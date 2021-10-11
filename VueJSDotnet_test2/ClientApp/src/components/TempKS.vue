<template>
    <h1>
        Это временная страница для рабочих экспериментов
    </h1>

    <my-input-alphabet v-model="mystring" disabled>{{mystring}}</my-input-alphabet>
    <br />
    <div v-for="alf in alfs" v-bind:key="alf">
        <my-button-letter v-for="cols in alf"
                          v-bind:key="cols"
                          v-model="cols.a"
                          v-on:clicklettor="clickKS">
            {{cols.a}}
        </my-button-letter>
    </div>


</template>

<script>
    import MyInputAlphabet from './UI/MyInputAlphabet.vue';
    import MyButtonLetter from './UI/MyButtonLetter.vue';


    export default {
        name: "Alphabet",
        components: {
            //MyButton,
            MyInputAlphabet,
            MyButtonLetter,
        },
        data() {
            return {
                alfs: [
                    [{ a: 'ё' }, { a: '1' }, { a: '2' }, { a: '3' }, { a: '4' }, { a: '5' }, { a: '6' }, { a: '7' }, { a: '8' }, { a: '9' }, { a: '0' }, { a: '-' }, { a: '=' }],
                    [{ a: 'q' }, { a: 'w' }, { a: 'e' }, { a: 'r' }, { a: 't' }, { a: 'y' }, { a: 'u' }, { a: 'i' }, { a: 'o' }, { a: 'p' }, { a: '[' }, { a: ']' }],
                    [{ a: 'a' }, { a: 's' }, { a: 'd' }, { a: 'f' }, { a: 'g' }, { a: 'h' }, { a: 'j' }, { a: 'k' }, { a: 'l' }, { a: ';' }, { a: '' }],
                    [{ a: 'z' }, { a: 'x' }, { a: 'c' }, { a: 'v' }, { a: 'b' }, { a: 'n' }, { a: 'm' }, { a: ',' }, { a: '.' }, { a: '/' }]
                ],
                letter: '',
                mystring: '',

            }
        },

        methods: {
            clickKS(value) {
                this.letter = value;
                this.mystring = this.mystring + this.letter;
                console.log(this.letter);
            },
            

            
            
            
        },
        created() {
            window.addEventListener('keydown', (e) => {
                if (e.key == "q") {
                    this.letter = "q";
                    this.mystring = this.mystring + this.letter;
                    console.log(this.letter);
                }
                if (e.key == "w") {
                    this.letter = "w";
                    this.mystring = this.mystring + this.letter;
                    console.log(this.letter);
                }
                if (e.key == "e") {
                    this.letter = "e";
                    this.mystring = this.mystring + this.letter;
                    console.log(this.letter);
                }
            })
        }
    }

</script>

<style>
    
</style>