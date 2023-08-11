class Utils {
    wait(timer){
        cy.wait(timer)
    }

    createMail(){
      const currentDate = new Date();

      // Extract various components of the date and time
      const year = currentDate.getFullYear();      // e.g., 2023
      const month = currentDate.getMonth();        // 0 (January) to 11 (December)
      const day = currentDate.getDate();           // e.g., 2
      const hours = currentDate.getHours();        // e.g., 14 (24-hour format)
      const minutes = currentDate.getMinutes();    // e.g., 30
      const seconds = currentDate.getSeconds();    // e.g., 45

      const mail = month+day+year+hours+minutes;
      return mail+"@yopmail.com"
    }
}

export default new Utils
