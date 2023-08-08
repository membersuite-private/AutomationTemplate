const { defineConfig } = require("cypress");
const allureWriter = require('@shelex/cypress-allure-plugin/writer');


module.exports = defineConfig({
  projectId: "vjt9tx",
  env: {
    // url: "https://mrpbpap.users.purple.membersuite.com/home",
    url:"https://mrpbpap.users.purple.membersuite.com/home",
  },


  e2e: {
    setupNodeEvents(on, config) {
      allureWriter(on, config);
      return config;
    },
    defaultCommandTimeout: 20000,
    // baseUrl: "https://mrpbpap.users.purple.membersuite.com/home",
    baseUrl:"https://mrpbpap.users.purple.membersuite.com/home",
    retries:1,
    specPattern: 'cypress/integration/*.spec.js'
  },

});
