package steps;

import pages.CertificationsPage;
import pages.MainPage;
import utils.BrowserUtils;
import io.cucumber.java.en.And;
import io.cucumber.java.en.Then;

public class CertificationsStepDefs {

    MainPage mainPage=new MainPage();
    CertificationsPage certificationsPage= new CertificationsPage();

    @Then("user should be able to click Certifications")
    public void user_should_be_able_to_click_Certifications() {
        certificationsPage.certificationsOnMainPage.click();
        BrowserUtils.wait(3);


    }

    @Then("user should be able to click and see My CEU Credit History")
    public void user_should_be_able_to_click_and_see_My_CEU_Credit_History() {

        certificationsPage.viewMyCeuCreditHistoryOnCertifications.click();
        BrowserUtils.wait(4);
    }

    @Then("user should be able to click and see Report Edit CEU Credits")
    public void user_should_be_able_to_click_and_see_Report_Edit_CEU_Credits() {

        certificationsPage.selfReportOnCertifications.click();
        BrowserUtils.wait(3);
    }



    @And("user should be able to click and see view Renew my Certifications")
    public void userShouldBeAbleToClickAndSeeViewRenewMyCertifications() {
        certificationsPage.viewRenewOnCertifications.click();
        BrowserUtils.wait(4);

    }

    @Then("user should be able to click and see Report Component Attendance")
    public void user_should_be_able_to_click_and_see_Report_Component_Attendance() {
        certificationsPage.reportComponentOnCertifications.click();
        BrowserUtils.wait(4);
    }

    @Then("user should be able to click and see View My Certification Components")
    public void user_should_be_able_to_click_and_see_View_My_Certification_Components() {

        certificationsPage.viewMyCertificationComponentsOnCertifications.click();
        BrowserUtils.wait(3);
    }

    @Then("user should be able to click and see Apply for Certification")
    public void user_should_be_able_to_click_and_see_Apply_for_Certification() {

        certificationsPage.applyForOnCertifications.click();
        BrowserUtils.wait(4);
    }

    @Then("user should be able to click and see View Certification Application History")
    public void user_should_be_able_to_click_and_see_View_Certification_Application_History() {

        certificationsPage.viewCertificationApplicationOnCertifications.click();
        BrowserUtils.wait(4);
    }


}
