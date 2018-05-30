<template>
    <div>
        <h1>Greenfinch Newsletter test</h1>
        <hr>
        <p>Just a sample form using Vue.JS, VueRouter, vee-validate and Axios.</p>
        <hr>
        <button class="btn btn-primary" @click.prevent="submitted">Subscribe!</button>
    </div>
</template>

<script>
export default {
    methods: {
        submitted: function() {
            this.$router.push({ name: 'newsletter' });
        }
    }
}
</script>