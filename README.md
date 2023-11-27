# AutomationTemplate
## Requirements
 - Node v20 or above
 - Cypress v13 or above


## First Steps
### Clone Repository
```
git clone https://github.com/membersuite-private/AutomationTemplate.git
```
### Install dependencies
```
npm install  --legacy-peer-deps
```


### Define which environment do you want to run the tests

On file `cypress.config.js` you can define what environment the tests are going to run.
To do that you need to change the config `baseUrl`

## How to run tests
 
 ```
npx cypress open
```

