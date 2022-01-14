<template>
    <h1>
        Вывод основного окна программмы
    </h1>
    <div>
        <my-button v-on:click="clickLoadingText">
            Загрузка текста
        </my-button>
    </div>
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
    import axios from 'axios';
    import MyButton from './UI/MyButton.vue';
    import MyInputAlphabet from './UI/MyInputAlphabet.vue';
    import MyButtonLetter from './UI/MyButtonLetter.vue';


    export default {
        name: "Alphabet",
        components: {
            MyButton,
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
                nameText: 'neo2000',
                texts: [],

            }
        },

        methods: {
            clickKS(value) {
                this.letter = value;
                this.mystring = this.mystring + this.letter;
                console.log(this.letter);
            },

            clickLoadingText() {
                //todo функция должна получать текст из базы

                const article = { name: this.nameText };

                axios({
                    method: 'Post',
                    url: '/Text/TextExport',
                    data: article

                })
                    .then((response) => {
                        this.texts = response.data;
                        this.mystring = this.texts.conText;

                    })
                    .catch(function (error) {
                        console.log(error);
                    });


                console.log(article);

            },


        },
        created() {
            window.addEventListener('keydown', (e) => {

                if (e.key == 'Escape') {
                    this.letter == "";
                    this.mystring = "";
                }

                if (e.key == this.mystring[0]) {

                    this.mystring = this.mystring.substr(1);
                    console.log(this.mystring);
                }
                else {
                    console.log(this.mystring);
                }

            })
        }

    }

</script>

<style>
   
</style>