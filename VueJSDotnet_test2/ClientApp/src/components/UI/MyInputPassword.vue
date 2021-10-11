<template>
    <div>
        

        <div class="my-div-centr">
            
            <input class="my-inp"
            position="relative"
            :value="modelValue"
           @input="updateInput"
            type="password"
            placeholder="Пароль" />

            <div>
                <button class="my-btn">🔍</button>
            </div>

        </div>
    </div>

</template>

<script>
    export default {
        name: "my-input-password",
        props: {
            modelValue: [String, Number]
        },
        methods: {
            updateInput(event) {
                this.$emit('update:modelValue', event.target.value)
            }
        }
    }

</script>

<style>
    .my-div-centr {
        display: flex;
        margin: 0 auto;
        padding: 0px;
        justify-content: left;
        border: 1px solid teal;
        width: 70%;
    }

    .my-btn {
        margin: 0px;
        width: 100%;
        padding: 10px 15px;
        background: none;
        color: teal;
        border: 1px solid teal;
    }

    .my-inp {
        margin-top: 0px;
        width: 100%;
        border: none;
    }

    .my-div-inp {
        margin: 0 auto;
        padding: 0px;
    }
</style>