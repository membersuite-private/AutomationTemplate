package utils;

import static com.codeborne.selenide.Condition.text;
import static com.codeborne.selenide.Selenide.$;
import static com.codeborne.selenide.Selenide.screenshot;
import static com.codeborne.selenide.Selenide.sleep;

import io.qameta.allure.Attachment;
import java.awt.AWTException;
import java.awt.Robot;
import java.awt.event.KeyEvent;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Iterator;
import java.util.List;
import java.util.Random;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.openqa.selenium.Keys;
import org.openqa.selenium.OutputType;
import org.openqa.selenium.WebDriver;

import com.codeborne.selenide.Conditional;
import com.codeborne.selenide.Selenide;

import io.cucumber.java.Scenario;
import io.qameta.allure.Allure;

public class Utils {
	
	private static Robot robot;
	private static String pathFeatureJson= "src/test/resources/dataTest/cards.json";
	public static String scenarioName;

	public static void capturarScreenshot(Scenario scenario) {
		try {
			byte[] tempShot = screenshot(OutputType.BYTES);
			scenario.attach(tempShot, "image/png", scenario.getName());
		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}



	@Attachment(value = "Page screenshot", type = "image/png")
	public byte[] saveScreenshot(byte[] screenShot) {
		return screenShot;
	}

	public static void filecreation(String phathFile, String contents) throws IOException {

		OutputStreamWriter bufferOut = new OutputStreamWriter(
				new FileOutputStream(phathFile), "UTF-8");

		bufferOut.write(contents);
		bufferOut.close();
	}

	public static void validateMessage(String message) {
		$("body").shouldHave(text(message));
	}

	public static void generatePendingTest(String message) throws Exception {
		Allure.addAttachment("", message);
		Allure.description(message);
		throw new io.cucumber.java.PendingException(message);
	}
	
	public static void setAllureDetailsAboutTest(String message) {
		Allure.addAttachment("", message);
		Allure.description(message);
	}	
	
	public static String generateRadomName() {
		String[] names = { "Steve Rogers", "Bucky Barnes", "Nick Fury", "Scott Lang", "Tony Stark", "Bruce Banner", "Natasha Romanoff", "Clint Barton" };
																									
		List<String> numberList = new ArrayList<String>();
		Random r = new Random();

		int i = r.nextInt(names.length);
		for (int j = 0; j < 50; j++) {
			numberList.add(Integer.toString(j));
		}

		return names[i];
	}

	public static String generateRadomMail() {
		String[] mails = { "bcljjywyaeinlybzyr", "ujbeukpbfjxnhifcig", "myjqynwrzqbrfvtdmo"};

		List<String> numberList = new ArrayList<String>();
		Random r = new Random();

		int i = r.nextInt(mails.length);
		for (int j = 0; j < 50; j++) {
			numberList.add(Integer.toString(j));
		}
		int j = r.nextInt(numberList.size());
		return mails[i]+j+"@tpwlb.com";

	}

	
	public static String getCurrentData() {
		DateFormat dateFormat = new SimpleDateFormat("dd/MM/yyyy HH:mm:ss");
		Date date = new Date();
		return dateFormat.format(date);
	}
    
}
