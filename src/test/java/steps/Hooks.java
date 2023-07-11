package steps;

import static utils.Utils.*;

import java.util.ArrayList;

import com.codeborne.selenide.Configuration;
import com.codeborne.selenide.Selenide;
import io.cucumber.java.AfterStep;
import io.qameta.allure.selenide.AllureSelenide;
import io.cucumber.java.After;
import io.cucumber.java.Before;
import io.cucumber.java.Scenario;
import org.junit.BeforeClass;
import utils.ConfigurationReader;

import com.codeborne.selenide.logevents.SelenideLogger;

public class Hooks {
	@Before
	public void setUp(Scenario scenario) throws Exception {

//		Configuration.browser = "safari";
		Configuration.headless= false;
		Selenide.open(ConfigurationReader.getProperty("url"));
		Selenide.clearBrowserLocalStorage();
		Selenide.clearBrowserCookies();

	}

	@BeforeClass
	static void setupAllureReports(){
		SelenideLogger.addListener("AllureSelenide", new AllureSelenide()
				.screenshots(true)
				.savePageSource(true)
		);
	}

	@AfterStep
	public void afterStep(Scenario context){
		capturarScreenshot(context);


	}


	@After
	public void tearDown(Scenario scenario) throws Exception {
		Selenide.closeWebDriver();

	}



}
