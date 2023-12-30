/***************************
 * Assignment 2 - Part B
 * Course: CSCN72010-23F-Sec3 
 * Professor: Prashathan Cheluvasai Ranga
 * Date: October 21, 2023
 * By: Hangsihak Sin
 ***************************/

namespace SeleniumtestingA2
{

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;

    [TestClass]
    public class ProvinceDropMenu_UnitTest
    {
        // Store expected provinces in an array in an increasing alphabetical order from A - Z
        private string[] expectedAlphabeticalOrder = { "Alberta", "British Columbia", "New Brunswick", "Newfoundland", "Northwest Territories", "Nova Scotia", "Nunavut", "Ontario", "Price Edward Island", "Quebec", "Saskatchewan", "Yukon Terriotory" };

        IWebDriver driver;

        /* 13 Test case: (with different input data) to show the working for each option selected in the menu option (Province). Although the instructions mentioned that we just need to test the 12 test cases for provinces. With the permission from the professor, i am adding an additional one for Manitoba which makes up the total test cases to 34. */

        /* Some bugs uncoverd overviews: 
         * 1. Province drop menu lists are not in alphabetical order
           2. Alberta and British Columbia are not spelled correctly
           3. (111)111-111 phone number format is not supported, eventhough it is mentioned in the requirements along with (111)-111-1111 format
           4. Although, Manitoba is not part of the list but since it is missing is considered a bug because Canada has 13 provinces and territories in total and should have an option for the user to select.
        */

        // Test Method 1: Verify if the Alberta province upon filling all the info are able to successfuly reach the viewRegistration page. Within this we also perform a spelling check on the Alberta province name prior to performing a check for successful registration url and since there is a spelling mistake for Aberta instead of Alberta, the test will fail before it can perform URL check.

        [TestMethod]
        public void ProvinceDropMenu_Alberta_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Adaline");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Friesen");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("144 4 Ave SW #1600");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Calgary");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Alberta");           // Alberta is spelled Aberta in the actual province list. Thus, result in a fail test case
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("T2P 3N4");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("403-770-4979");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("afriesen7989@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("8");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day2");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Define actual and expected values for assertion
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

        // Test Method 2: Verify if the Britsh Columbia province upon filling all the info are able to successfuly reach the viewRegistration page. Within this we also perform a spelling check on the British Columbia province name prior to performing a check for successful registration url and since there is a spelling mistake for Columbia British instead of British Columbia, the test will fail before it can perform URL check.

        [TestMethod]
        public void ProvinceDropMenu_BritishColumbia_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Rebekah");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Hartmann");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("735 Goldstream Ave #121");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Victoria");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("British Columbia");          // British Columbia is spelled Columbia British in the actual province list. Thus, result in a fail test case
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("V9B 2X4");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("250-383-1269");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("rhartman01@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("9");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("both");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }


        // Test Method 3: Verify if the Manitoba province upon filling all the info are able to successfuly reach the viewRegistration page. Within this we also perform a spelling check on the Manitoba province name prior to performing a check for successful registration url but since Manitoba is missing from the provided list. Thereofre, this test is expected to fail.
        
        // Special Mention: This is an additional test case on top of the 12 test cases for provinces which makes it 13 and 34 test cases in total. I decided to add this with the permission from the professor. 
        [TestMethod]
        public void ProvinceDropMenu_Manitoba_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Dustin");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Monahan");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("1425 Regent Ave W");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Winnipeg");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Manitoba");          // Manitoba is missing from the province list and cannot be located, results in a fail test case
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("R2C 3B2");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("204-957-2500");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("dustin.monahan@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("5");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day1");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }




        // Test Method 4: Verify if the New Brunswick province upon filling all the info are able to successfuly reach the viewRegistration page. Within this we also perform a spelling check on the New Brunswick province name prior to performing a check for successful registration url. The test will pass since it met all the requirements mentioned.

        [TestMethod]
        public void ProvinceDropMenu_NewBrunswick_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Reggie");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Schumm");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("4 Park Dr");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Richibucto");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("New Brunswick");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("E4W 4G5");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("(506)524-9087");     // Eventhough this format is valid in the requirements but the actual website does not accept this format. THus, the test is expected to fail.
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("rschumm6391@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("5");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day2");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Define actual and expected values for assertion
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

        // Test Method 5: Verify if the Newfoundland province upon filling all the info are able to successfuly reach the viewRegistration page. Within this we also perform a spelling check on the Newfoundland province name prior to performing a check for successful registration url. Also, we are checking for increasing alphabetical order of Newfoundland between the expected and actual alphabetical order listed. The test shall fail since Newfoundland is not in the correct alphabetical order. 

        [TestMethod]
        public void ProvinceDropMenu_Newfoundland_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Hangsihak");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Sin");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("123 Harris Dr");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Marystown");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Newfoundland");
            Thread.Sleep(1000);

            // Get all the provinces options and store in an array
            string[] actualAlphabeticalOrder = provinceDropDown.Options.Select(option => option.Text).ToArray();

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("A0E 2M0");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("709-279-3753");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("hsin123@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("2");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day2");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            // Find the expected index of province aplhabetical order from the list of array
            int expectedIndex = Array.IndexOf(expectedAlphabeticalOrder, "Newfoundland");

            // Find the actual index of province alphabetical order from the list of array
            int actualIndex = Array.IndexOf(actualAlphabeticalOrder, "Newfoundland");

            /* Assert */

            // Define actual and expected values for assertion
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to verify increasing alphabetical order for the provinces dropdown menu
            Assert.AreEqual(expectedIndex, actualIndex);            // This will cause fail before it can get to URL assertion since actual alphabetical order index for Newfoundland province are not in the proper order as the expected alphabetical order index. In other word, it will fail because Newfoundland is not in proper alphabetical order.

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

        // Test Method 6: Verify if the NorthWest Territories province upon filling all the info are able to successfuly reach the viewRegistration page. Within this we also perform a spelling check on the NorthWest Territories province name prior to performing a check for successful registration url. The test will pass since it met all the requirements mentioned.

        [TestMethod]
        public void ProvinceDropMenu_NorthWestTerritories_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Marianne");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Davis");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("198 Mackenzie Rd");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Inuvik");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("NorthWest Territories");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("X0E 0T0");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("867-678-6300");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("mariannedavis8398@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("11");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day2");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

        // Test Method 7: Verify if the Nova Scotia province upon filling all the info are able to successfuly reach the viewRegistration page. Within this we also perform a spelling check on the Nova Scotia province name prior to performing a check for successful registration url. The test will pass since it met all the requirements mentioned.

        [TestMethod]
        public void ProvinceDropMenu_NovaScotia_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Emely");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("DuBuque");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("10 Beech St");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Lockeport");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Nova Scotia");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("B0T 1L0");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("902-656-2695");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("edubuque9821@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("4");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day1");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Define actual and expected values for assertion
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

        // Test Method 8: Verify if the Nunavut province upon filling all the info are able to successfuly reach the viewRegistration page. Within this we also perform a spelling check on the Nunavut province name prior to performing a check for successful registration url. The test will pass since it met all the requirements mentioned.

        [TestMethod]
        public void ProvinceDropMenu_Nunavut_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Madeira");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Stevenson");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("234 th Ave");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Hall Beach");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Nunavut");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("X0A 0K0");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("867-793-8142");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("madeira_stevenson123@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("12");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("both");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

        // Test Method 9: Verify if the Ontario province upon filling all the info are able to successfuly reach the viewRegistration page. Within this we also perform a spelling check on the Ontario province name prior to performing a check for successful registration url. The test will pass since it met all the requirements mentioned.

        [TestMethod]
        public void ProvinceDropMenu_Ontario_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Sierra");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Erbster");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("1385 Danforth Ave");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Toronto");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Ontario");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("M4J 1N2");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("416-454-2924");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("serbster123@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("1");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day1");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Define actual and expected values for assertion
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

        // Test Method 10: Verify if the Prince Edward Island province upon filling all the info are able to successfuly reach the viewRegistration page. Within this we also perform a spelling check on the Prince Edward Island province name prior to performing a check for successful registration url. The test will pass since it met all the requirements mentioned.

        [TestMethod]
        public void ProvinceDropMenu_PrinceEdwardIsland_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Ayana");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Olson");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("511 Notre Dame St");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Summerside");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Prince Edward Island");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("C1N 1T2");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("902-432-1234");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("ayanaolson3921@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("3");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("both");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Define actual and expected values for assertion
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

        // Test Method 11: Verify if the Quebec province upon filling all the info are able to successfuly reach the viewRegistration page. Within this we also perform a spelling check on the Quebec province name prior to performing a check for successful registration url. The test will pass since it met all the requirements mentioned.

        [TestMethod]
        public void ProvinceDropMenu_Quebec_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Naomi");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Oberbrunner");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("1390 Ste Catherine O");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Montréal");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Quebec");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("H3G 1P8");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("514-393-3458");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("naomi.oberbrunner123@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("6");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("both");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

        // Test Method 12: Verify if the Saskatchewan province upon filling all the info are able to successfuly reach the viewRegistration page. Within this we also perform a spelling check on the Saskatchewan province name prior to performing a check for successful registration url. The test will pass since it met all the requirements mentioned.

        [TestMethod]
        public void ProvinceDropMenu_Saskatchewan_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Hassan");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Schroeder");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("2062 100th St");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("North Battleford");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Saskatchewan");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("S9A 0X5");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("306-445-7283");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("schroeder.h5692@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("7");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day1");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

        // Test Method 13: Verify if the Yukon Territory upon filling all the info are able to successfuly reach the viewRegistration page. Within this we also perform a spelling check on the Yukon Territory name prior to performing a check for successful registration url. The test will pass since it met all the requirements mentioned.

        [TestMethod]
        public void ProvinceDropMenu_YukonTerritory_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Era");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Heidenreich");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("907 3 Ave");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Dawson");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Yukon Territory");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("Y0B 1G0");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("867-993-5170");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("e.heidenreich91@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("10");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day1");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }
    }

    [TestClass]
    public class Participants_UnitTest
    {
        /* 6 test cases: "How many participants?", Check for Number of Participants 1, 2, 3, 4, 5, 6 */

        /* Some bugs uncovered overviews:
         * No bugs uncovered for the requirements since it has been covered by other test cases
         */

        // Test Method 1: Verify Successfuly Registration for 1 Participant. Upon entering other valid data on the event page and after Register button is clicked shall open a view registration page. In this case, this test will pass.

        IWebDriver driver;
        [TestMethod]
        public void Participants_1_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Fraser");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Wright");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("1218 Pembroke St E");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Listowel");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("ON");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("K8A 7R9");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("613-732-4222");  
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("fraserwright989@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("1");        // In this case, set number of participants to 1
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day1");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }


        // Test Method 2: Verify Successfuly Registration for 2 Participants. Upon entering other valid data on the event page and after Register button is clicked shall open a view registration page. In this case, this test will pass.

        [TestMethod]
        public void Participants_2_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Mark");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Hall");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("1240 Hollis St");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Halifax");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("NS");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("B3J 1B3");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("902-404-3300");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("markhall8931@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("2");            // In this case, set number of participants to 2
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day2");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }


        // Test Method 3: Verify Successfuly Registration for 3 Participants. Upon entering other valid data on the event page and after Register button is clicked shall open a view registration page. In this case, this test will pass.

        [TestMethod]
        public void Participants_3_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Salma");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Denesik");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("153 Meadow Rd");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("White City");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("SK");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("S4L 0A2");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("306-552-8000");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("sdenesik01@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("3");                // In this case, set number of participants to 3
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day1");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);

            /* Assert */

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }


        // Test Method 4: Verify Successfuly Registration for 4 Participants. Upon entering other valid data on the event page and after Register button is clicked shall open a view registration page. In this case, this test will pass.
        [TestMethod]
        public void Participants_4_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Sienna");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Moore");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("565 Bernard Ave");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Saskatoon");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("SK");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("V1Y 6P2");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("250-712-0997");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("smoore01@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("4");                    // In this case, set number of participants to 4
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day1");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Define actual and expected values for assertion
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

        // Test Method 5: Verify Successfuly Registration for 5 Participants. Upon entering other valid data on the event page and after Register button is clicked shall open a view registration page. In this case, this test will pass.
        [TestMethod]
        public void Participants_5_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Bianka");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Wilkinson");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("3870 Boulevard de la Côte-Vertu");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Montréal");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("QC");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("H4R 1V4");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("514-507-5858");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("bianka.wilksinson123@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("5");                    // In this case, set number of participants to 5
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day2");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Define actual and expected values for assertion
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

        // Test Method 6: Verify Successfuly Registration for 6 Participants. Upon entering other valid data on the event page and after Register button is clicked shall open a view registration page. In this case, this test will pass.
        [TestMethod]
        public void Participants_6_Returns_SuccessfulViewRegistrationURL()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Jeffery");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Walter");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("11 East Lake Way NE");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Airdrie");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("AB");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("T4A 2J4");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("403-948-4848");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("jefferywalter99@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("6");                    // In this case, set number of participants to 6
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("both");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            /* Assert */

            // Define actual and expected values for assertion
            string expectedUrl = "https://localhost/register/viewRegistration.html";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

    }


    [TestClass]
    public class TotalCharge_UnitTest
    {
        /* 3 test cases: "Registrants attending Day 1 will be charged $450" */

        /* Bugs uncovered overviews: 
         * 1. Day 1 actual charge $350
         * 2. Day 2 actual charge $450
         * 3. Both days actual charge $7500 
         * 4. Price shown in view registration page added 0.67 cents on calculated price
         * 5. Day 2 after user submitted the register form displayed Day 3 instead of Day 2
         * 6. Ten Percent is calculated correctly since Day 1, Day 2, and Both Days charges at a different price than the given requirements 
  
         */

        IWebDriver driver;
        [TestMethod]

        // Test Method 1: Verify whether the price for 1 participant on Day 1 is calculated correctly as per the specified requirement, which states that the charge should be $450. However, this test will result in a fail as the actual charge is $350.67. 

        public void TotalCharge_RegistrationDay_1_Participants_1_Returns_Price_450()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Fraser");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Wright");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("1218 Pembroke St E");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Listowel");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("ON");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("K8A 7R9");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("613-732-4222");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("fraserwright989@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("1");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day1");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            // Wait for 5 seconds for the viewRegistration page to be fully loaded before performing other tasks
            Thread.Sleep(5000);

            /* Assert */

            // Locate the 'price' text box element 
            IWebElement priceField = driver.FindElement(By.Id("price"));

            // Define actual and expected values for assertion
            string actualValue = priceField.GetAttribute("value");
            string expectedValue = "$450";              // $450 * 1 Participants = $450

            // Assert to verify that the actual value being displayed matches the expected value
            Assert.AreEqual(expectedValue, actualValue);

            // Close driver windows
            driver.Close();
        }

        // Test Method 2: Verify whether the price for 2 Participant on Day 1 is calculated correctly as per the specified requirement, which states that the charge should be $900. However, this test will result in a fail as the actual charge is $700.67. 
        [TestMethod]
        public void TotalCharge_RegistrationDay_1_Participants_2_Returns_Price_900()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Afton");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Wilkinson");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("3280 Av de la Gare");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Mascouche");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("QC");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("J7K 3C1");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("450-474-4118");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("afonwilkinson123@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("2");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day1");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            // Wait for 5 seconds for the viewRegistration page to be fully loaded before performing other tasks
            Thread.Sleep(5000);

            /* Assert */

            // Locate the 'price' text box element 
            IWebElement priceField = driver.FindElement(By.Id("price"));

            // Define actual and expected values for assertion
            string actualValue = priceField.GetAttribute("value");
            string expectedValue = "$900";          // $450 * 2 Participants = $900

            // Assert to verify that the actual value being displayed matches the expected value
            Assert.AreEqual(expectedValue, actualValue);

            // Close driver windows
            driver.Close();
        }

        // Test Method 3: Verify whether the price for 3 participant on Day 1 is calculated correctly as per the specified requirement, which states that the charge should be $1350. However, this test will result in a fail as the actual charge is $1050.67. 

        [TestMethod]
        public void TotalCharge_RegistrationDay_1_Participants_3_Returns_Price_1350()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Salma");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Denesik");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("153 Meadow Rd");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("White City");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("SK");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("S4L 0A2");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("306-552-8000");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("sdenesik01@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("3");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day1");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            // Wait for 5 seconds for the viewRegistration page to be fully loaded before performing other tasks
            Thread.Sleep(5000);

            /* Assert */

            // Locate the 'price' text box element 
            IWebElement priceField = driver.FindElement(By.Id("price"));

            // Define actual and expected values for assertion
            string actualValue = priceField.GetAttribute("value");
            string expectedValue = "$1350";         // $450 * 3 Participants = $1350

            // Assert to verify that the actual value being displayed matches the expected value
            Assert.AreEqual(expectedValue, actualValue);

            // Close driver windows
            driver.Close();
        }

        /* 3 test cases: "Registrants attending Day 2 will be charged $350" */

        // Test Method 1: Verify whether the price for 1 participant on Day 2 is calculated correctly as per the specified requirement, which states that the charge should be $350. However, this test will result in a fail as the actual charge is $450.67. 

        [TestMethod]
        public void TotalCharge_RegistrationDay_2_Participants_1_Returns_Price_350()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Constance");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Abbott");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("129 Merrymeeting Rd");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("St John's");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("NL");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("A1C 2W3");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("709-722-5115");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("constance.abbott@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("1");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day2");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            // Wait for 5 seconds for the viewRegistration page to be fully loaded before performing other tasks
            Thread.Sleep(5000);

            /* Assert */

            // Locate the 'price' text box element 
            IWebElement priceField = driver.FindElement(By.Id("price"));

            // Define actual and expected values for assertion
            string actualValue = priceField.GetAttribute("value");
            string expectedValue = "$350";          // $350 * 1 Participants = $350

            // Assert to verify that the actual value being displayed matches the expected value
            Assert.AreEqual(expectedValue, actualValue);

            // Close driver windows
            driver.Close();
        }


        // Test Method 2: Verify whether the price for 2 participant on Day 2 is calculated correctly as per the specified requirement, which states that the charge should be $700. However, this test will result in a fail as the actual charge is $900.67. 

        [TestMethod]
        public void TotalCharge_RegistrationDay_2_Participants_2_Returns_Price_700()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Johnathan");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Boyle");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("1950 Lawrence Ave E");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Scarborough");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("ON");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("M1R 2Y9");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("416-967-1111");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("boyle.johathan123@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("2");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day2");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            // Wait for 5 seconds for the viewRegistration page to be fully loaded before performing other tasks
            Thread.Sleep(5000);

            /* Assert */

            // Locate the 'price' text box element 
            IWebElement priceField = driver.FindElement(By.Id("price"));

            // Define actual and expected values for assertion
            string actualValue = priceField.GetAttribute("value");
            string expectedValue = "$700";          // $350 * 2 Participants = $700

            // Assert to verify that the actual value being displayed matches the expected value
            Assert.AreEqual(expectedValue, actualValue);

            // Close driver windows
            driver.Close();
        }

        // Test Method 3: Verify whether the price for 3 participant on Day 3 is calculated correctly as per the specified requirement, which states that the charge should be $1050. However, this test will result in a fail because we are also checking there is a bug in the code that cause the Day 2 to be displayed as Day 3 as well as the actual charge is $1350.67. 

        [TestMethod]
        public void TotalCharge_RegistrationDay_2_Participants_3_Returns_Price_1050()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Maddison");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Pouros");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("58 Aero Dr NE");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Calgary");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("AB");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("T2E 8Z9");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("403-230-3009");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("madipouros9899@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("3");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day2");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            // Wait for 5 seconds for the viewRegistration page to be fully loaded before performing other tasks
            Thread.Sleep(5000);

            /* Assert */

            // Locate the 'day' text box element
            IWebElement dayField = driver.FindElement(By.Id("daysRegistered"));

            // Locate the 'price' text box element 
            IWebElement priceField = driver.FindElement(By.Id("price"));

            // Define actual and expect day for assertion
            string actualDay = new SelectElement(dayField).SelectedOption.Text;
            string expectedDay = "Day 2";        

            // Define actual and expected values for assertion
            string actualValue = priceField.GetAttribute("value");
            string expectedValue = "$1050";         // $350 * 3 Participants = $350

            // Assert to verify that actual value being displayed matches expected value for day
            Assert.AreEqual(expectedDay, actualDay);        // This test shall fail before it gets to check for price because it displayed Day 3 instead of Day 2 when the user select Day 2

            // Assert to verify that the actual value being displayed matches the expected value
            Assert.AreEqual(expectedValue, actualValue);

            // Close driver windows
            driver.Close();
        }


        /* 3 test cases: "Registrants attending Day 1 and Day 2 will be charged $750" */

        // Test Method 1: Verify whether the price for 1 participant on Both Day is calculated correctly as per the specified requirement, which states that the charge should be $750. However, this test will result in a fail as the actual charge is $7500.67. 

        [TestMethod]
        public void TotalCharge_RegistrationDay_BothDays_Participants_1_Returns_Price_750()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Dovie");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Mayer");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("18 Canterbury");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("St John");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("NB");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("E2L 2C4");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("506-634-7115");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("doviemayer101@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("1");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("both");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            // Wait for 5 seconds for the viewRegistration page to be fully loaded before performing other tasks
            Thread.Sleep(5000);

            /* Assert */

            // Locate the 'price' text box element 
            IWebElement priceField = driver.FindElement(By.Id("price"));

            // Define actual and expected values for assertion
            string actualValue = priceField.GetAttribute("value");
            string expectedValue = "$750";          // $750 * 1 Participants = $750

            // Assert to verify that the actual value being displayed matches the expected value
            Assert.AreEqual(expectedValue, actualValue);

            // Close driver windows
            driver.Close();
        }


        // Test Method 1: Verify whether the price for 2 participant on Both Day is calculated correctly as per the specified requirement, which states that the charge should be $1500. However, this test will result in a fail as the actual charge is $15000.67. 

        [TestMethod]
        public void TotalCharge_RegistrationDay_BothDays_Participants_2_Returns_Price_1500()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Ismael");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Howe");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("2884 Chamberland St");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Rockland");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("ON");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("K4K 5G9");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("613-446-2468");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("drismaelhowe@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("2");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("both");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            // Wait for 5 seconds for the viewRegistration page to be fully loaded before performing other tasks
            Thread.Sleep(5000);

            /* Assert */

            // Locate the 'price' text box element 
            IWebElement priceField = driver.FindElement(By.Id("price"));

            // Define actual and expected values for assertion
            string actualValue = priceField.GetAttribute("value");
            string expectedValue = "$1500";         // $750 * 2 Participants = $1500

            // Assert to verify that the actual value being displayed matches the expected value
            Assert.AreEqual(expectedValue, actualValue);

            // Close driver windows
            driver.Close();
        }

        // Test Method 1: Verify whether the price for 3 participant on Both Day is calculated correctly as per the specified requirement, which states that the charge should be $2250. However, this test will result in a fail as the actual charge is $22500.67. 
        // Bugs: days displayed on viewRegistration page for both days becomes day 3. 

        [TestMethod]
        public void TotalCharge_RegistrationDay_BothDays_Participants_3_Returns_Price_2250()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Cordelia");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Grady");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("555 W 12th Ave");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Vancouver");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("BC");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("V5Z 3X7");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("604-872-8762");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("gradycordelia123@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("3");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("both");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            // Wait for 5 seconds for the viewRegistration page to be fully loaded before performing other tasks
            Thread.Sleep(5000);

            /* Assert */

            // Locate the 'price' text box element 
            IWebElement priceField = driver.FindElement(By.Id("price"));

            // Define actual and expected values for assertion
            string actualValue = priceField.GetAttribute("value");
            string expectedValue = "$2250";             // $750 * 3 Participants = $2250

            // Assert to verify that the actual value being displayed matches the expected value
            Assert.AreEqual(expectedValue, actualValue);

            // Close driver windows
            driver.Close();
        }

        /* 3 test cases: "Registrants registering more than five participants will be given 10% discount." */

        // Test Method 1: Verify whether the price for 6 participant on Day 1 is calculated correctly as per the specified requirement, which states than more than 5 participants will be given a 10% discount and should be charged $2430. However, this test will result in a fail as the actual charge is $1890.67. 

        [TestMethod]
        public void TotalCharge_RegistrationDay_1_Participants_6_TenPercentDiscount_Returns_Price_2430()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Jakob");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Grady");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("419 Hunter Ave");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Oshawa");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("ON");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("N1P 5A3");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("416-531-8931");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("jackobgrady12345@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("6");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day1");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            // Wait for 5 seconds for the viewRegistration page to be fully loaded before performing other tasks
            Thread.Sleep(5000);

            /* Assert */

            // Locate the 'price' text box element 
            IWebElement priceField = driver.FindElement(By.Id("price"));

            // Define actual and expected values for assertion
            string actualValue = priceField.GetAttribute("value");
            string expectedValue = "$2430";          // 6 Participants * $450 * (0.90) = $2430

            // Assert to verify that the actual value being displayed matches the expected value
            Assert.AreEqual(expectedValue, actualValue);

            // Close driver windows
            // driver.Close();
        }


        // Test Method 2: Verify whether the price for 10 participant on Day 2 is calculated correctly as per the specified requirement, which states than more than 5 participants will be given a 10% discount and should be charge $3150. However, this test will result in a fail as the actual charge is $4050.67. 

        [TestMethod]
        public void TotalCharge_RegistrationDay_2_Participants_10_TenPercentDiscount_Returns_Price_3150()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Retha");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Koelpin");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("1055 Mainland St");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Vancouver");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("BC");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("V6B 1A9");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("604-684-6239");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("koelpin.retha@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("10");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("day2");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            // Wait for 5 seconds for the viewRegistration page to be fully loaded before performing other tasks
            Thread.Sleep(5000);

            /* Assert */

            // Locate the 'price' text box element 
            IWebElement priceField = driver.FindElement(By.Id("price"));

            // Define actual and expected values for assertion
            string actualValue = priceField.GetAttribute("value");
            string expectedValue = "$3150";          // 10 Participants * $350 * (0.90) = $3150

            // Assert to verify that the actual value being displayed matches the expected value
            Assert.AreEqual(expectedValue, actualValue);

            // Close driver windows
            driver.Close();
        }

        // Test Method 3: Verify whether the price for 50 participant on Both Day is calculated correctly as per the specified requirement, which states than more than 5 participants will be given a 10% discount and should be charge $33750. However, this test will result in a fail as the actual charge is $337500.67. 
        [TestMethod]
        public void TotalCharge_RegistrationDay_BothDays_Participants_50_TenPercentDiscount_Returns_Price_33750()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Lura");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Romaguera");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("201 Pockwock Rd");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Hammonds Plains");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("NS");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("B4B 1N5");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("902-443-4247");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("l.romaguera01@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("50");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("both");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            // Wait for 5 seconds for the viewRegistration page to be fully loaded before performing other tasks
            Thread.Sleep(5000);

            /* Assert */

            // Locate the 'price' text box element 
            IWebElement priceField = driver.FindElement(By.Id("price"));

            // Define actual and expected values for assertion
            string actualValue = priceField.GetAttribute("value");
            String expectedValue = "$33750";          // 50 Participants * $750 * (0.90) = $33750

            // Assert to verify that the actual value being displayed matches the expected value
            Assert.AreEqual(expectedValue, actualValue);

            // Close driver windows
            driver.Close();
        }

    }

    [TestClass]
    public class TopPageLink_UnitTest
    {
        /* 3 test cases: "Test for web app to The Event, the home page, and main page of Conestoga College" */

        IWebDriver driver;

        // Test Method 1: Verify that THE Event! link provided and working at the top of the web app on the view registration page. In this case, the test is expected to pass since the link is presented and successfuly navigates to the intended page.
        [TestMethod]
        public void TopPageLink_THEEvent_present_valid_inViewRegistrationPage_Returns_RegisterationPage()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            String baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Lura");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Romaguera");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("201 Pockwock Rd");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Hammonds Plains");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("NS");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("B4B 1N5");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("902-443-4247");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("l.romaguera01@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("50");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("both");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(1000);

            // Locate the 'THE Event!' link element and click it to navigate to a new page
            IWebElement eventLink = driver.FindElement(By.LinkText("THE Event!"));  
            eventLink.Click();

            /* Assert */

            // Define actual and expected values for assertion
            string expectedUrl = "https://localhost/register/index.html";   // I chose this to be the expected Url based on the professor approval that THEEvent link should return back to the register page. 
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

        // Test Method 2: Verify that Home link provided and working at the top of the web app on the view registration page. In this case, the test is expected to pass since the link is presented and successfuly navigates to the intended page.

        [TestMethod]
        public void TopPageLink_Home_present_valid_inViewRegistrationPage_Returns_RegisterationPage()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Johnny");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Mccorroy");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("201 Pockwock Rd");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Hammonds Plains");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("ON");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("K4D 1L5");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("902-443-4247");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("l.romaguera01@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("50");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("both");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(1000);

            // Locate the 'Home' link element and click it to navigate to a new page
            IWebElement homeLink = driver.FindElement(By.LinkText("Home"));
            homeLink.Click();

            /* Assert */

            // Define actual and expected values for assertion
            string expectedUrl = "https://localhost/register/index.html";     // I chose this to be the expected Url based on the professor approval that Home link should return back to the register page.
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }

        // Test Method 3: Verify that Conestoga link provided and working at the top of the web app on the view registration page. In this case, the test is expected to fail since the link is missing. 

        [TestMethod]
        public void TopPageLink_ConestogaCollege_present_valid_inViewRegistrationPage_Return_ConestogaCollege_MainPage()
        {
            // Initial Setup
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            string baseUrl = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(baseUrl);

            /* Arrange */

            // Locate the 'firstName' text box element and enter the value provided into the field
            IWebElement firstNameField = driver.FindElement(By.Name("firstName"));
            firstNameField.SendKeys("Lura");
            Thread.Sleep(1000);

            // Locate the 'lastName' text box element and enter the value provided into the field
            IWebElement lastNameField = driver.FindElement(By.Name("lastName"));
            lastNameField.SendKeys("Romaguera");
            Thread.Sleep(1000);

            // Locate the 'address' text box element and enter the value provided into the field
            IWebElement addressField = driver.FindElement(By.Name("address"));
            addressField.SendKeys("201 Pockwock Rd");
            Thread.Sleep(1000);

            // Locate the 'city' text box element and enter the value provided into the field
            IWebElement cityField = driver.FindElement(By.Name("city"));
            cityField.SendKeys("Hammonds Plains");
            Thread.Sleep(1000);

            // Locate the 'province' dropdown menu element and select a province provided accordingly
            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("NS");
            Thread.Sleep(1000);

            // Locate the 'postalCode' text box element and enter the value provided into the field
            IWebElement postalCodeField = driver.FindElement(By.Name("postalCode"));
            postalCodeField.SendKeys("B4B 1N5");
            Thread.Sleep(1000);

            // Locate the 'phone' text box element and enter the value provided into the field
            IWebElement phoneNumberField = driver.FindElement(By.Name("phone"));
            phoneNumberField.SendKeys("902-443-4247");
            Thread.Sleep(1000);

            // Locate the 'email' text box element and enter the value provided into the field
            IWebElement emailAddressField = driver.FindElement(By.Name("email"));
            emailAddressField.SendKeys("l.romaguera01@gmail.com");
            Thread.Sleep(1000);

            // Locate the 'numberOfParticipants' text box element and enter the value provided into the field
            IWebElement numberOfParticipantsField = driver.FindElement(By.Name("numberOfParticipants"));
            numberOfParticipantsField.SendKeys("50");
            Thread.Sleep(1000);

            // Locate the 'daysRegistered' dropdown menu element and select a day provided accordingly
            SelectElement daysRegisteredDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            daysRegisteredDropDown.SelectByValue("both");
            Thread.Sleep(1000);

            /* Act */

            // Locate the 'btnSubmit' button element and click it to submit the register form
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(1000);

            // Locate the 'Link to Conestoga College' link element and click it to navigate to a new page
            IWebElement conestogaLink = driver.FindElement(By.LinkText("Link to Conestoga College"));
            conestogaLink.Click();          // Since the Link to Conestoga College is missing, thus will cause this test case to fail before the link text is not found or present on viewRegistration page.

            /* Assert */

            // Define actual and expected values for assertion
            string expectedUrl = "https://www.conestogac.on.ca/about/corporate-information/policies";
            string actualUrl = driver.Url;

            // Assert to ensure that the URL after clicking the 'btnSubmit' button matches the expected URL
            Assert.AreEqual(expectedUrl, actualUrl);

            // Close driver windows
            driver.Close();
        }
    }
}