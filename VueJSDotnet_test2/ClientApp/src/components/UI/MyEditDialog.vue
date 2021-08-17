<template>
    <h1>Личный кабинет</h1>
    <h2>О мой белый госпадин Вы успешно изменили эту проклятую запись</h2>
    <form @submit.prevent>
        <div class="my-div-centr">
            <div>
                <my-button @click="clickEditOk">Ок</my-button>
            </div>
            
        </div>
    </form>


</template>
<script>
    
    import MyButton from './MyButton.vue'

    export default {
        name: "my-edit-dialog",

        components: {

            MyButton,

        },
        props: {
            show: {
                type: Boolean,
                default: false,
            }
        },
        methods: {
            clickEditOk() {
                this.$emit('update:show', false);
            }
        }
    }
</script>
<style>
    .my-div-centr {
        display: flex;
        justify-content: center;
    }
</style>