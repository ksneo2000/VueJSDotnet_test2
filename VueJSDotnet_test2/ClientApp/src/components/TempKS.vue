<template>
    <h1>
        Это временная страница для рабочих экспериментов
    </h1>
    



</template>

<script>
    import MyInputPassword from './UI/MyInputPassword.vue';
    import MyInput from './UI/MyInput.vue';

     export default {
        name: "TempKS",
        components: {
            MyInputPassword,
            MyInput

        },
        data() {
            return {
                name: '',
                password: '',
            }
        },

        methods: {
            inputPassword(password) {
                console.log(password)

            }
        }

        }

</script>

<style>
    
</style>