import Newsletter from './components/newsletter/Newsletter.vue';
import Form from './components/newsletter/NewsletterForm.vue';
import Success from './components/newsletter/Success.vue';
import Home from './components/Home.vue';
import Header from './components/Header.vue';

export const routes = [
    { path: '', name: 'home', components: {
        default: Home,
        'header-top': Header
    } },
    { path: '/newsletter', components: {
        default: Newsletter,
        'header-top': Header
    }, children: [
        { path: '', name: 'newsletter', component: Form }
    ] },
    { path: '/success', name: 'success', components: {
        default: Success,
        'header-top': Header
    }, props: true },
    { path: '/redirect-me', redirect: { name: 'home' } },
    { path: '*', redirect: '/' }
];