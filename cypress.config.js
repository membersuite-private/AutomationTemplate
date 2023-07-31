const { defineConfig } = require("cypress");
const preprocessor = require("@badeball/cypress-cucumber-preprocessor");
const browserify = require("@badeball/cypress-cucumber-preprocessor/browserify");

async function setupNodeEvents(on, config) {
  // This is required for the preprocessor to be able to generate JSON reports after each run, and more,
  await preprocessor.addCucumberPreprocessorPlugin(on, config);

  on("file:preprocessor", browserify.default(config));

  // Make sure to return the config object as it might have been modified by the plugin.
  return config;
}

module.exports = defineConfig({
  env: {
    // url: "https://mrpbpap.users.purple.membersuite.com/home",
    url:"https://mrpbpag.users.green.membersuite.com/home",
  },

  e2e: {
    defaultCommandTimeout: 10000,
    setupNodeEvents,
    // baseUrl: "https://mrpbpap.users.purple.membersuite.com/home",
    baseUrl:"https://mrpbpag.users.green.membersuite.com/home",
    specPattern: 'cypress/integration/features/*.feature'
  },
});
