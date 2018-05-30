<template>
    <div class="container">
        <div class="row">
            <br>
            <div class="col-md-6 col-md-offset-3">
                <h2 class="title">You have been subscribed using the email {{ $route.params.email }}!</h2>
                    <p class="subtitle">
                    Thank you for keeping in touch with us.
                    </p>
            </div>
        </div>
        <div class="col-md-6 col-md-offset-3">
            <hr>
            <div class="row">
                <button class="btn btn-primary" @click.prevent="backHome">Back to home</button>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    methods: {
        backHome: function() {
            this.$router.push({ name: 'home' });
        }
    }
}
</script>

