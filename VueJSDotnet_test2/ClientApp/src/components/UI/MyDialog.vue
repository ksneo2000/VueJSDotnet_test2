﻿<template>
    <div class="dialog" v-if="show" @click.stop="hideDialog">
        <div @click.stop class="dialig__content">
            <slot></slot>
        </div>

    </div>

</template>

<script>
    export default {
        name: 'my-dialog',
        props: {
            show: {
                type: Boolean,
                default: false,
            }

        },
        methods: {
            hideDialog() {
                this.$emit('update:show', false)
            }
        }
    }

</script>

<style>
    .dialog{
        top:0;
        bottom:0;
        right:0;
        left:0;
        background:rgba(0, 0, 0, 0.5);
        position:fixed;
        display:flex;
    }
    .dialig__content{
        margin:auto;
        background:white;
        border-radius:12px;
        padding:20px;
    }

</style>