const { defineConfig } = require("cypress");
const allureWriter = require('@shelex/cypress-allure-plugin/writer');


module.exports = defineConfig({
  projectId: "vjt9tx",
  env: {
    // url: "https://mrpbpap.users.purple.membersuite.com/home",
    url:"https://mrpbpap.users.purple.membersuite.com",
  },


  e2e: {
    setupNodeEvents(on, config) {
      allureWriter(on, config);
      return config;
    },
    defaultCommandTimeout: 20000,
    numTestsKeptInMemory: 5,
    // baseUrl: "https://mrpbpag.users.green.membersuite.com",
    baseUrl:"https://mrpbpap.users.purple.membersuite.com",
    retries: {
      runMode: 3,
      openMode: 0,
    },
    specPattern: 'cypress/integration/*.spec.js'

  },

});
