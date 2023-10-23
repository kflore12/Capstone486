//axios needed for requests
const axios = require('axios');

//endpoint for companies as a test
const endpoint = "https://services.promostandards.org/WebServiceRepository/WebServiceRepository.svc/json/companies";


//GET request
axios.get(endpoint)
.then(response => {
    //'companies' gets the response from api
    const companies = response.data;
    companies.forEach(company => { //loop through
        console.log(company);
    });
})
//error
.catch(error => {
    console.error(`Error: ${error}`);
});









