<template>
    <my-button-letter>Привет</my-button-letter>
    <my-button-letter>Привет2</my-button-letter>


</template>

<script>
    import MyButtonLetter from './UI/MyButtonLetter.vue';


export default {
        name: 'my-buttons-alphaber',
        components: {
            MyButtonLetter,

        },

        


    }

</script>

<style scoped>
    .btn {
        margin:10px;
        padding: 10px 15px;
        background: none;
        color: teal;
        border: 1px solid teal;
    }
</style>