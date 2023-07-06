package runners;

import org.junit.AfterClass;
import com.codeborne.selenide.Selenide;
import io.cucumber.junit.Cucumber;
import io.cucumber.junit.CucumberOptions;
import io.cucumber.junit.CucumberOptions.SnippetType;
import org.junit.runner.RunWith;

@RunWith(Cucumber.class)
@CucumberOptions(
        plugin = {"pretty",
        "io.qameta.allure.cucumber6jvm.AllureCucumber6Jvm"
        },
        features = "classpath:features",
        glue = {"steps"},
//        tags = "@Signup or @Subscriptions or @LoginIndividualPositive or @CareerCenter or @Committees or @Competitions or @Discussions or @Events",
        tags = "@signupNewUserNotAffiliated",
        snippets = SnippetType.CAMELCASE,
        monochrome = true,
        publish = true,
        dryRun = false
       )

public class RunnerTest {

    @AfterClass
    public static void tearDown() {

//        Selenide.closeWebDriver();
    }

}
