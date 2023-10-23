// Importing the Axios library for making HTTP requests
const axios = require('axios');

// Define the endpoint URL for retrieving the list of companies.
// As a good practice, constants are usually named using UPPERCASE.
const ENDPOINT = "https://services.promostandards.org/WebServiceRepository/WebServiceRepository.svc/json/companies";

/**
 * FetchCompanies - Function to retrieve and display a list of companies.
 */
const fetchCompanies = async () => {
    try {
        // Sending a GET request to the defined endpoint
        const response = await axios.get(ENDPOINT);

        // Extract the list of companies from the response data
        const companies = response.data;

        // Log each company details to the console
        companies.forEach(company => {
            console.log(company);
        });
    } catch (error) {
        // Handle any errors that occur during the HTTP request
        console.error(`An error occurred while fetching companies: ${error.message}`);
    }
}

// Execute the function to fetch and display the list of companies
fetchCompanies();
