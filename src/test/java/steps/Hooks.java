package steps;

import static utils.Utils.*;

import java.util.ArrayList;

import com.codeborne.selenide.Configuration;
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

//		Configuration.browser = "safari";
		Configuration.headless= false;
		Selenide.open(ConfigurationReader.getProperty("url"));
		Selenide.clearBrowserLocalStorage();
		Selenide.clearBrowserCookies();

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


	}


	@After
	public void tearDown(Scenario scenario) throws Exception {
		Selenide.closeWebDriver();

	}

	//    @Before
//    public void setup(){
//        System.out.println("##############################");
//        System.out.println("MemberSuite Demo Started");
//        Driver.get().manage().window().maximize();
//
//        Driver.get().get(ConfigurationReader.getProperty("url"));
//    }
//
//    @After
//    public void teardown(Scenario scenario){
//        //if test failed - do this
//        if(scenario.isFailed()){
//            byte[] screenshot = ((TakesScreenshot)Driver.get()).getScreenshotAs(OutputType.BYTES);
////            scenario.embed(screenshot,"image/png","Screenshot");
//            //scenario.embed(screenshot, "image/png");
//            System.out.println("Test failed!");
//
//        }else{
//            System.out.println("Cleanup!");
//            System.out.println("Test completed!");
//        }
//        System.out.println("##############################");
//        //after every test, we gonna close browser
//        Driver.close();
//    }

}
