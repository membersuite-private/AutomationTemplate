class DiscussionsPage {
    checkDiscussionBoard(){
        cy.get("h4").contains("MRP BluePay Automation Purple Discussion Board").should("be.visible")
        cy.get("p").contains("You may have to register before you can post. To start viewing messages, select the forum that you want to visit from the selection below.").should("be.visible")
        cy.get("a").contains("What color is best?").should("be.visible")
        cy.get("a").contains("Favorite hobby").should("be.visible")
    }

    clickWhatsColorIsTheBest(){
        cy.get("a").contains("What color is best?").click()
    }

    clickSubscribeWhatsColorIsTheBest(){
        cy.get("a").contains("Subscribe").eq(0).click()
    }

    checkDiscussionForum(){
        cy.get("h4").contains("What color is best? Discussion Forum").should("be.visible")
        cy.get("h4").contains("Discussion Forum Tasks").should("be.visible")
        cy.get("span").contains("Create New Topic").should("be.visible")
        cy.get("span").contains("Subscribe to this Forum").should("be.visible")
    }

    checkMyTopicSubscriptions(){
        cy.get("h4").contains("My Topic Subscriptions").should("be.visible")
        // cy.get("span").contains("MRP BluePay Automation Purple").should("be.visible")
    }


}

export default new DiscussionsPage