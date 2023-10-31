const { defineConfig } = require("cypress");
const allureWriter = require('@shelex/cypress-allure-plugin/writer');


module.exports = defineConfig({
  projectId: "vjt9tx",
  chromeWebSecurity: false,
  env: {
    // url: "https://mrpbpap.users.purple.membersuite.com/home",
    // url:"https://mrpbpap.users.purple.membersuite.com",
  },

  reporter: 'cypress-mochawesome-reporter',
  reporterOptions: {
    charts: true,
    reportPageTitle: 'custom-title',
    embeddedScreenshots: true,
    inlineAssets: true,
    saveAllAttempts: false,
  },
  e2e: {
    setupNodeEvents(on, config) {
      allureWriter(on, config);
      require('cypress-mochawesome-reporter/plugin')(on);
      require('cypress-grep/src/plugin')(config);
      return config;
    },
    defaultCommandTimeout: 20000,
    numTestsKeptInMemory: 5,
    baseUrl: "https://mrpbpag.users.green.membersuite.com",
    // baseUrl:"https://mrpbpap.users.purple.membersuite.com",
    // baseUrl:"https://mrpbpap.users.membersuite.com",
    retries: {
      runMode: 3,
      openMode: 0,
    },
    specPattern: 'cypress/integration/*.spec.js'

  },

});
