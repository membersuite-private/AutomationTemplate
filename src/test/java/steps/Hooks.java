package steps;

import static utils.Utils.*;

import java.util.ArrayList;
import com.codeborne.selenide.Selenide;
import io.cucumber.java.AfterStep;
import io.qameta.allure.AllureLifecycle;
import io.qameta.allure.selenide.AllureSelenide;
import io.cucumber.java.After;
import io.cucumber.java.Before;
import io.cucumber.java.Scenario;
import org.junit.jupiter.api.BeforeAll;
import utils.ConfigurationReader;

import com.codeborne.selenide.logevents.SelenideLogger;

public class Hooks {
	@Before
	public void setUp(Scenario scenario) throws Exception {

		Selenide.open(ConfigurationReader.getProperty("url"));
		Selenide.sleep(5000);
//		Selenide.open("https://google.com/");
	}

	@BeforeAll
	static void setupAllureReports(){
		SelenideLogger.addListener("AllureSelenide", new AllureSelenide()
				.screenshots(true)
				.savePageSource(true)
		);
	}

	@AfterStep
	public void afterStep(Scenario context){
		capturarScreenshot(context);
//		byte[] content = capturarScreenshot();
//		new AllureLifecycle().addAttachment("Failed Screenshot", "application/png", content);
	}


	@After
	public void tearDown(Scenario scenario) throws Exception {
		Selenide.closeWebDriver();

	}

}
