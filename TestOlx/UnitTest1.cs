using OpenQA.Selenium;
using OpenQA.Selenium.Safari;

namespace TestOlx;

public class Tests
{
    private IWebDriver driver;
    private readonly By signInButton = By.XPath("//strong[text()='Ваш профіль']");
    [SetUp]
    public void Setup()
    {
        driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        driver.Navigate().GoToUrl("https://www.olx.ua/uk/");
        driver.Manage().Window.Maximize();
        
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [TearDown]
    public void TearDown1()
    {
        
    }
}