# Greenfinch Newsletter Test

First of all, I've commited even the build files, just trying to make things a bit easier for who is going to run it.

I've decided to don't use `SSR`, so all the frontend are working apart from the server.

## Technologies Used

## Frontend:
- Vue.JS 2
- Vue-Router
- Axios
- Vee-Validate
- Webpack

## Backend:
- .NET Core 2.0
- EntityFramework 2
- .NET Core Built-in DI
- SQLServer

# How to run it?

## Front end
The Client already has been built using webpack, so just run `index.html` inside the `Client` folder. But the project are also there to look the font.

## Server
The files already have been published on `.\GreenfinchTest\bin\Debug\netcoreapp2.0\publish` just go there and execute `dotnet GreenfinchNewsletter.API.dll`. Since it's the default port of Kestrel and I didn't changed, the application will run on port `5000`

**Important:** The Client application is pointing to port 5000. The configuration is on `main.js`, I wasn't able to make in time it parameterizable and also work with `Webpack` after build.

You can also find the `migration sql script` in the repository.
