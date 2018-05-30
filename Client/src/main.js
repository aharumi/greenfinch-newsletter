import Vue from 'vue'
import VueRouter from 'vue-router';
import App from './App.vue'
import { routes } from './routes';
import VeeValidate from 'vee-validate';
import axios from 'axios';

Vue.use(VueRouter);
Vue.use(VeeValidate);

axios.defaults.baseURL = 'http://localhost:5000/api';
axios.defaults.headers.common['Authorization'] = 'fasfdsa';
axios.defaults.headers.get['Accepts'] = 'application/json';

const router = new VueRouter({
  routes
});

new Vue({
  el: '#app',
  router,
  render: h => h(App)
})
