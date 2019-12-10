using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class POBuyer
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        //private string baseURL;
        private bool acceptNextAlert = true;

        

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            //baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }


        public void SwitchtoCurrentWindow()
        {
            //SwitchTo is Seleniums InBuilt Code and Driver is WebDriver 
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        

        [Test]
        public void AThePOBuyerTest()
        {
            driver.Navigate().GoToUrl("http://172.16.18.106/PAIS_Selenium/Login.aspx");
            Task.Delay(2000).Wait();
            
            /*
            
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu4");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            var element = driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t24"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t24")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch"))).SelectByText("CODMA");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SearchDept")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SearchDept"))).SelectByText("Admissions");
            Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SearchDept")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SearchDept")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();*/
            /*
            String PRID = driver.FindElement(By.XPath("//td[contains(text(),'00001594')]")).Text;

            driver.FindElement(By.Id("HyperLinkLogout")).Click();   */
           
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();

            var element = driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t39"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);


            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t39")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropdownlistPoType")).Click();
            Task.Delay(2000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropdownlistPoType"))).SelectByText("indigenous");
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropdownlistPoType")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='BusinessUnit:'])[1]/following::td[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownListBU")).Click();
            Task.Delay(2000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownListBU"))).SelectByText("CODMA");
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownListBU")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonDept")).Click();
            Task.Delay(2000).Wait();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_1 | ]]


            //This method makes Switch To Current Window makes much easier 
            //SwitchtoCurrentWindow();

            driver.SwitchTo().Window(driver.WindowHandles.Last());

            //driver.SwitchTo().Window().Title.Contains("Display");


            driver.FindElement(By.Id("DeptName")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("DeptName")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("DeptName")).SendKeys("Admissions");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("btnSearch")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("GridViewDept_LabelDID_0")).Click();
            Task.Delay(2000).Wait();

            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            Task.Delay(2000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSearch")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtBoxReq")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtBoxReq")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtBoxReq")).SendKeys("00001620");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSrch")).Click();
            Task.Delay(2000).Wait();

            
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPR_CheckBoxMarkPR_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_brnSubPo")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSubPRLine_CheckBoxMarkPRLine_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSubPrLine")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonDebsearch")).Click();
            Task.Delay(2000).Wait();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_1 | ]]

            //SwitchtoCurrentWindow();

            driver.SwitchTo().Window(driver.WindowHandles.Last());

            
            driver.FindElement(By.Id("vendCode")).Click();
            driver.FindElement(By.Id("vendCode")).Clear();
            driver.FindElement(By.Id("vendCode")).SendKeys("pur");
            driver.FindElement(By.Id("btnSearch")).Click();
            Task.Delay(2000).Wait();
            
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("GridViewVendor_LabelVID_4")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("GridViewVendor_LabelVID_4")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_3 | ]]

            driver.SwitchTo().Window(driver.WindowHandles.Last());

            driver.FindElement(By.Id("GridViewVendor_LabelVID_0")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_2 | ]]
            driver.SwitchTo().Window(driver.WindowHandles.First());
            //driver.Close();

            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            driver.FindElement(By.Id("txtattnPhone")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("txtattnPhone")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("txtattnPhone")).SendKeys("757575");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonShip")).Click();
            Task.Delay(2000).Wait();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_2 | ]]

            driver.SwitchTo().Window(driver.WindowHandles.Last());

            driver.FindElement(By.Id("GridViewShipLocation_LabelVID_0")).Click();
            Task.Delay(2000).Wait();
            //driver.Close();

            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose")).Click();
            Task.Delay(2000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose"))).SelectByText("Conference");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose")).Click();
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlTaxComponent"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlTaxComponent")).Click();
            //Task.Delay(2000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlTaxComponent"))).SelectByText("CGST+SGST");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextComment")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextComment")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextComment")).SendKeys("for test3");
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlTaxComponent")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("DropDownListTermCond")).Click();
            //Task.Delay(2000).Wait();
            new SelectElement(driver.FindElement(By.Id("DropDownListTermCond"))).SelectByText("CAPG1");
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("DropDownListTermCond")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_HSNLabel_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_HSNLabel_0")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_HSNLabel_0")).SendKeys("65");
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_DDLMatTax_0")).Click();
            //Task.Delay(2000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_DDLMatTax_0"))).SelectByText("GST Exempt Item");

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_DDLMatTax_0")).Click();
            //Task.Delay(2000).Wait();

            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_UnitPriceText_0"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_UnitPriceText_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_UnitPriceText_0")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPODetails_UnitPriceText_0")).SendKeys("50");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='PO Entry'])[2]/following::center[1]")).Click();
            Task.Delay(2000).Wait();

            var element3 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script3 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript(script3, element3);

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();

            //Perfect
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();

            var element4 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script4 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js4 = (IJavaScriptExecutor)driver;
            js4.ExecuteScript(script4, element4);

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSubmit")).Click();

            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            driver.FindElement(By.Id("HyperLinkLogout")).Click();

            //Perfect
        }

        [Test]
        public void BThePOFinanceTest()
        {
            driver.Navigate().GoToUrl("http://172.16.18.106/PAIS_Selenium/Login.aspx");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv6");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t5")).Click();
            Task.Delay(2000).Wait();

            
            //ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
        }

        //Done Till Above

        [Test]
        public void CThePODDPTest()
        {
            driver.Navigate().GoToUrl("http://172.16.18.106/PAIS_Selenium/Login.aspx");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu3");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t5")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();

            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);


            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();

            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
        }


        [Test]
        public void DThePOPDTest()
        {
            driver.Navigate().GoToUrl("http://172.16.18.106/PAIS_Selenium/Login.aspx");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu5");

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t10")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();

            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
        }

        [Test]
        public void EThePODispatchTest()
        {
            driver.Navigate().GoToUrl("http://172.16.18.106/PAIS_Selenium/Login.aspx");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            var element = driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t40"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t40")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();
            acceptNextAlert = true;
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script1, element1);

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Do You Want To Continue[\\s\\S]$"));
            Task.Delay(2000).Wait();

            //driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_BtnEdit_7")).Click();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
        }
        /*
        [Test]
        public void poapprove()
        {

            driver.Navigate().GoToUrl("http://172.16.18.106/PAIS_Selenium/Login.aspx");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv6");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t5")).Click();
            Task.Delay(2000).Wait();


            IWebElement grid = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch"));
            string POID = "00001928";
            // Get all the rows
            Task.Delay(2000).Wait();
            //By locAllRows = By.XPath(".//*[contains(@class,'x-grid3-body')]//*[contains(@class,'x-grid3-row')]");
            By locAllRows = By.XPath(".//*[contains(@class,'footable')]//*[contains(@class,'footable')]");
            IList<IWebElement> allRows = grid.FindElements(locAllRows);
            //IList<IWebElement> allRows = grid.
            Task.Delay(2000).Wait();
            // Loop through each row and compare actual emp. no. with expected emp. no.
            Task.Delay(2000).Wait();

            foreach (IWebElement row in allRows)
            {

                // Emp No. is 4th column

                //By locEmpNo = By.XPath("//div[@id='ContentPlaceHolder1_ContentPlaceHolder3_accordion2']//tr[4]");

                // Get the Emp. No.
                //String actEmpNo = row.FindElements(locEmpNo);
                //String actEmpNo = row.FindElements(locEmpNo).GetText();
                //driver.FindElement(By.Id("demoLink")).get();
                // Compare actual vs expected
                string st = driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_ContentPlaceHolder3_accordion2']//th[3]")).GetAttribute("value");
                if (st.Equals(POID))
                    System.Console.Write("POID", st);
                Task.Delay(10000).Wait();
                {

                    row.Click(); // Select row
                    Task.Delay(10000).Wait();
                    //System.out.println("Selected row " + (allRows.indexOf(row) + 1) + " having Emp. No. " + expEmpNo)
                    Task.Delay(2000).Wait();
                    //break; // exit the for loop

                }
                
            }
        }
        */

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
