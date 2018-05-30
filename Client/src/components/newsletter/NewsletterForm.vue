<template>
    <div>
        <form>
            <div class="row">
                <div class="form-group" v-bind:class="{'has-error': errors.has('email')}">
                    <label for="email">Email</label>
                    <input name="email" data-vv-validate-on="blur" v-validate="'required|email'" type="email" id="email" class="form-control" v-model="newsletterData.email">
                    <small class="text-danger" v-show="errors.has('email')">*{{ errors.first('email') }}</small>
                    <small class="text-danger" v-show="existentEmail && newsletterData.email === existentEmail">*This Email already is receiving our newslatter.</small>
                </div>
            </div>
            <div class="row">
                <div class="form-group">
                    <label for="priority">Where did you heard about us?</label>
                    <select id="priority" class="form-control" v-model="placeHeard">
                        <option v-for="(place, key) in newsletterData.placesHeard">{{ place }}</option>
                    </select>
                </div>
            </div>
            <div class="row">
                <div class="form-group">
                    <label for="message">Reason to sign up</label>
                    <br>
                    <textarea id="message" rows="5" class="form-control" v-model="newsletterData.reason" placeholder="Reason to sign up"></textarea>
                </div>
            </div>
            <hr>
            <div class="row">
                <button class="btn btn-primary" @click.prevent="submitted">Submit!</button>
            </div>
        </form>
    </div>
</template>

<script>
    import axios from 'axios';

    export default {
        data () {
            return {
                newsletterData: {
                    email: '',
                    reason: '',
                    placesHeard: ['Advert', 'Word of Mouth', 'Other'],
                },
                placeHeard: 'Advert',
                isSubmitted: false,
                existentEmail: ''
            }
        },
        methods: {
          submitted: async function() {
            let validateForm = await this.$validator.validateAll();
            if(!validateForm) {
                return;
            }
            
            try{
                let subscribeResult = await axios.post('/newsletter', 
                    { 
                        email: this.newsletterData.email, 
                        heard: this.placeHeard,
                        reason: this.newsletterData.reason 
                    });
                if(subscribeResult) {
                    this.$router.push({ name: 'success' , params: {email: this.newsletterData.email}});
                }
            }
            catch(error) {
                if(error.response.status === 409) {
                    this.existentEmail = this.newsletterData.email;
                }
            }
          }
        },
    }
</script>

<style>
</style>
