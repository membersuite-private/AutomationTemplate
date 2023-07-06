package pages;

import com.codeborne.selenide.SelenideElement;
import org.openqa.selenium.By;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

import static com.codeborne.selenide.Selenide.$;

public class CertificationsPage{


    public SelenideElement firstArrowOnCategoriesOnCareerCenter = $(By.xpath("(//*[@class='btn btn-default col-md-offset-2 str vertical-spacing-5 sm-spacing col-md-8'])[1]"));
    public SelenideElement viewMyCeuCreditHistoryOnCertifications = $(By.xpath("(//*[contains(text(),'View My Credit History')])[1]"));
    public SelenideElement selfReportOnCertifications = $(By.xpath("(//*[contains(text(),'Report CEU Credits')])[1]"));
    public SelenideElement viewRenewOnCertifications = $(By.xpath("(//*[contains(text(),'View/Renew')])[1]"));
    public SelenideElement reportComponentOnCertifications = $(By.xpath("(//*[contains(text(),'Report Component')])[1]"));
    public SelenideElement viewMyCertificationComponentsOnCertifications = $(By.xpath("(//*[contains(text(),'View My Certification')])[1]"));
    public SelenideElement applyForOnCertifications = $(By.xpath("(//*[contains(text(),'Apply for Certification')])[1]"));
    public SelenideElement viewCertificationApplicationOnCertifications = $(By.xpath("(//*[contains(text(),'View My Certification History')])[1]"));
    public SelenideElement certificationsOnMainPage = $(By.xpath("//span[normalize-space()='Certifications']"));

}
