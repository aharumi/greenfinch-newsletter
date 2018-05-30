<template>
        <div class="row">
                <router-view name="header-top"></router-view>
                <div class="container">
                    <router-view></router-view>
                </div>
        </div>
</template>

<script>
    import Header from './components/Header.vue';
    export default {
        components: {
            appHeader: Header
        }
    }
</script>

<style>
</style>
