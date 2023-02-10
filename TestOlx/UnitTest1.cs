using OpenQA.Selenium;
using OpenQA.Selenium.Safari;

namespace TestOlx;

public class Tests
{
    private IWebDriver driver;
    private readonly By signInButton = By.XPath("//strong[text()='Ваш профіль']");
    private readonly By logginInputButton = By.XPath("//input[@name='username']");
    private readonly By passwordInputButton = By.XPath("//input[@name='password']");
    private readonly By enterToSiteButton=By.XPath("//button[@type='submit']");
    private readonly By submitButton=By.XPath("//button[@type='submit']");
    
    [SetUp]
    public void Setup()
    {
        driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        driver.Navigate().GoToUrl("https://www.olx.ua/uk/");
        //driver.Manage().Window.Maximize();
        
    }

    [Test]
    public void Test1()
    {
        var signIn = driver.FindElement(signInButton);
        signIn.Click();

        var loggin = driver.FindElement(logginInputButton);
        loggin.SendKeys("voznesenskiytim@gmail.com");

        var password = driver.FindElement(passwordInputButton);
        password.SendKeys("010204Tema");

        var enter = driver.FindElement(enterToSiteButton);
        enter.Click();

        var submit = driver.FindElement(submitButton);
        submit.Click();
    }

    [TearDown]
    public void TearDown1()
    {
        
    }
}