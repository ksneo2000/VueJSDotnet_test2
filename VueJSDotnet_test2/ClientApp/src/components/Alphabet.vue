<template>
    <h1>
        Вывод основного окна программмы
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
    //import MyButton from './UI/MyButton.vue';
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
            }


        },
        created() {
            window.addEventListener('keydown', (e) => {
                this.mystring = this.mystring + this.letter;
                if (e.key == 'Escape') {
                    this.mystring = "";
                }

                if (e.key == "ё") {
                    this.letter = "ё";
                }
                if (e.key == "1") {
                    this.letter = "1";
                }
                if (e.key == "2") {
                    this.letter = "2";
                }
                if (e.key == "3") {
                    this.letter = "3";
                }
                if (e.key == "4") {
                    this.letter = "4";
                }
                if (e.key == "5") {
                    this.letter = "5";
                }
                if (e.key == "6") {
                    this.letter = "6";
                }
                if (e.key == "7") {
                    this.letter = "7";
                }
                if (e.key == "8") {
                    this.letter = "8";
                }
                if (e.key == "9") {
                    this.letter = "9";
                }
                if (e.key == "0") {
                    this.letter = "0";
                }
                if (e.key == "-") {
                    this.letter = "-";
                }
                if (e.key == "=") {
                    this.letter = "=";
                }
                if (e.key == "q") {
                    this.letter = "q";
                }
                if (e.key == "w") {
                    this.letter = "w";
                }
                if (e.key == "e") {
                    this.letter = "e";
                }
                if (e.key == "r") {
                    this.letter = "r";
                }
                if (e.key == "t") {
                    this.letter = "t";
                }
                if (e.key == "y") {
                    this.letter = "y";
                }
                if (e.key == "u") {
                    this.letter = "u";
                }
                if (e.key == "i") {
                    this.letter = "i";
                }
                if (e.key == "o") {
                    this.letter = "o";
                }
                if (e.key == "p") {
                    this.letter = "p";
                }
                if (e.key == "[") {
                    this.letter = "[";
                }
                if (e.key == "]") {
                    this.letter = "]";
                }
                if (e.key == "a") {
                    this.letter = "a";
                }
                if (e.key == "s") {
                    this.letter = "s";
                }
                if (e.key == "d") {
                    this.letter = "d";
                }
                if (e.key == "f") {
                    this.letter = "f";
                }
                if (e.key == "g") {
                    this.letter = "g";
                }
                if (e.key == "h") {
                    this.letter = "h";
                }
                if (e.key == "j") {
                    this.letter = "j";
                }
                if (e.key == "k") {
                    this.letter = "k";
                }
                if (e.key == "l") {
                    this.letter = "l";
                }
                if (e.key == ";") {
                    this.letter = ";";
                }
                if (e.key == "") {
                    this.letter = "";
                }
                if (e.key == "z") {
                    this.letter = "z";
                }
                if (e.key == "x") {
                    this.letter = "x";
                }
                if (e.key == "c") {
                    this.letter = "c";
                }
                if (e.key == "v") {
                    this.letter = "v";
                }
                if (e.key == "b") {
                    this.letter = "b";
                }
                if (e.key == "n") {
                    this.letter = "n";
                }
                if (e.key == "m") {
                    this.letter = "m";
                }
                if (e.key == ",") {
                    this.letter = ",";
                }
                if (e.key == ".") {
                    this.letter = ".";
                }
                if (e.key == "/") {
                    this.letter = "/";
                }


            })
        }

    }

</script>

<style>
   
</style>