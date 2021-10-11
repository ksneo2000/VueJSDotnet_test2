<template>
    <button class="btn"  v-on:click="clicklettor" :value="modelValue">
        <slot></slot>
    </button>
</template>

<script>
export default {
        name: 'my-button-letter',
        data() {
            return {
                

            }
        },
        props: {
            modelValue: [String, Number]
        },
        methods: {
            clicklettor() {
                this.$emit('clicklettor', event.target.value)

            }

        }
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
    .btn:focus {
        background: #bdbebd;
    }
</style>