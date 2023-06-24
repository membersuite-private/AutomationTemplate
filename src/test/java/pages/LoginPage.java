package pages;

import com.codeborne.selenide.*;
import org.openqa.selenium.By;

import static com.codeborne.selenide.Condition.*;
import static com.codeborne.selenide.Selenide.*;

public class LoginPage {

    public SelenideElement inputUsername = $(By.xpath("//input[@id='ctl00_body_TextBox1']"));
    public SelenideElement inputPassword = $(By.xpath("//input[@id='ctl00_body_TextBox2']"));
    public SelenideElement btnLogin = $(By.xpath("//a[@id='ctl00_body_lb_Login']"));
    public SelenideElement perfilBtn = $(By.xpath("//span[.='Login to MemberSuite']"));
    public SelenideElement WelcomeBanner = $(By.xpath("//h1[.='Welcome!']"));
    public SelenideElement message = $(By.xpath("//div[@id='ctl00_divMessage']"));
    public SelenideElement nameHead = $(By.xpath("//span[.=' Hi, Levi Santos ']"));

}
