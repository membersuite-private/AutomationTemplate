package steps;

import utils.ConfigurationReader;
import utils.Driver;;
//import io.cucumber.core.api.Scenario;
import io.cucumber.java.After;
import io.cucumber.java.Before;
import io.cucumber.java.Scenario;
import org.openqa.selenium.OutputType;
import org.openqa.selenium.TakesScreenshot;

public class Hook {

//
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