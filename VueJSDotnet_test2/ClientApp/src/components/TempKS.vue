<template>
    <h1>
        Это временная страница для рабочих экспериментов
    </h1>
    <div>
        <my-button v-on:click ="clickLoadingText">
            Загрузка текста
        </my-button>
    </div>
    <my-input-alphabet v-model="mystring" disabled>{{mystring}}</my-input-alphabet>
    <br />
    <div v-for="alf in alfs" v-bind:key="alf">
        <my-button-letter v-for="cols in alf"
                          v-bind:key="cols"
                          v-model="cols.a"
                          v-on:clicklettor="clickKS"
                          >
            {{cols.a}}
        </my-button-letter>
    </div>


</template>

<script>
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
                //const article = { name: this.name, password: this.password };

                //axios({
                //    method: 'Post',
                //    url: '/UserRegistration/Autorization',
                //    data: article

                //})
                //    .then(function (response) {
                //        console.log(response.data);

                        
                //    })
                //    .catch(function (error) {
                //        console.log(error);
                //    });

                console.log("нажмалось");
            },
            

            
            
            
        },
        created() {
            window.addEventListener('keydown', (e) => {
                
                if (e.key == 'Escape') {
                    this.letter == "";
                    this.mystring = "";
                }

                if (e.key == "ё") {
                    this.mystring = this.mystring + "ё";
                }
                if (e.key == "1") {
                    this.mystring = this.mystring + "1";
                }
                if (e.key == "2") {
                    this.mystring = this.mystring + "2";
                }
                if (e.key == "3") {
                    this.mystring = this.mystring + "3";
                }
                if (e.key == "4") {
                    this.mystring = this.mystring + "4";
                }
                if (e.key == "5") {
                    this.mystring = this.mystring + "5";
                }
                if (e.key == "6") {
                    this.mystring = this.mystring + "6";
                }
                if (e.key == "7") {
                    this.mystring = this.mystring + "7";
                }
                if (e.key == "8") {
                    this.mystring = this.mystring + "8";
                }
                if (e.key == "9") {
                    this.mystring = this.mystring + "9";
                }
                if (e.key == "0") {
                    this.mystring = this.mystring + "0";
                }
                if (e.key == "-") {
                    this.mystring = this.mystring + "-";
                }
                if (e.key == "=") {
                    this.mystring = this.mystring + "=";
                }
                if (e.key == "q") {
                    this.mystring = this.mystring + "q";
                }
                if (e.key == "w") {
                    this.mystring = this.mystring + "w";
                }
                if (e.key == "e") {
                    this.mystring = this.mystring + "e";
                }
                if (e.key == "r") {
                    this.mystring = this.mystring + "r";
                }
                if (e.key == "t") {
                    this.mystring = this.mystring + "t";
                }
                if (e.key == "y") {
                    this.mystring = this.mystring + "y";
                }
                if (e.key == "u") {
                    this.mystring = this.mystring + "u";
                }
                if (e.key == "i") {
                    this.mystring = this.mystring + "i";
                }
                if (e.key == "o") {
                    this.mystring = this.mystring + "o";
                }
                if (e.key == "p") {
                    this.mystring = this.mystring + "p";
                }
                if (e.key == "[") {
                    this.mystring = this.mystring + "[";
                }
                if (e.key == "]") {
                    this.mystring = this.mystring + "]";
                }
                if (e.key == "a") {
                    this.mystring = this.mystring + "a";
                }
                if (e.key == "s") {
                    this.mystring = this.mystring + "s";
                }
                if (e.key == "d") {
                    this.mystring = this.mystring + "d";
                }
                if (e.key == "f") {
                    this.mystring = this.mystring + "f";
                }
                if (e.key == "g") {
                    this.mystring = this.mystring + "g";
                }
                if (e.key == "h") {
                    this.mystring = this.mystring + "h";
                }
                if (e.key == "j") {
                    this.mystring = this.mystring + "j";
                }
                if (e.key == "k") {
                    this.mystring = this.mystring + "k";
                }
                if (e.key == "l") {
                    this.mystring = this.mystring + "l";
                }
                if (e.key == ";") {
                    this.mystring = this.mystring + ";";
                }
                if (e.key == "") {
                    this.mystring = this.mystring + "";
                }
                if (e.key == "z") {
                    this.mystring = this.mystring + "z";
                }
                if (e.key == "x") {
                    this.mystring = this.mystring + "x";
                }
                if (e.key == "c") {
                    this.mystring = this.mystring + "c";
                }
                if (e.key == "v") {
                    this.mystring = this.mystring + "v";
                }
                if (e.key == "b") {
                    this.mystring = this.mystring + "b";
                }
                if (e.key == "n") {
                    this.mystring = this.mystring + "n";
                }
                if (e.key == "m") {
                    this.mystring = this.mystring + "m";
                }
                if (e.key == ",") {
                    this.mystring = this.mystring + ",";
                }
                if (e.key == ".") {
                    this.mystring = this.mystring + ".";
                }
                if (e.key == "/") {
                    this.mystring = this.mystring + "/";
                }
                
                

               
            })
        }
    }

</script>

<style>
    
</style>