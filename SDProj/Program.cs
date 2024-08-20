

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://www.saucedemo.com/");
driver.Manage().Window.Maximize();

IWebElement userBox = driver.FindElement(By.Id("user-name"));
userBox.SendKeys("standard_user");

IWebElement passwordBox = driver.FindElement(By.Id("password"));
passwordBox.SendKeys("secret_sauce");

IWebElement loginButton = driver.FindElement(By.Id("login-button"));
loginButton.Click();
Thread.Sleep(2000);

IWebElement productTitle = driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/span"));

if(productTitle.Text == "Products")
{
    Console.WriteLine("Logged in Successfully");
}
else
{
    Console.WriteLine("login Failed");
}

IWebElement cartAdd = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
cartAdd.Click();

IWebElement redShirt = driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)"));
redShirt.Click();

IWebElement cartIcon = driver.FindElement(By.XPath("//*[@id=\"shopping_cart_container\"]/a/span"));
cartIcon.Click();

IWebElement redShirtCart = driver.FindElement(By.XPath("//*[@id=\"item_4_title_link\"]/div"));

if(redShirtCart.Text == "Sauce Labs Backpack")
{
    Console.WriteLine("Added to cart successfully");
}
else
{
    Console.WriteLine("Product failed to add to cart");

}

IWebElement contShopping = driver.FindElement(By.Id("continue-shopping"));
contShopping.Click();

IWebElement fleeceJacket = driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
fleeceJacket.Click();


IWebElement cartIcon1 = driver.FindElement(By.XPath("//*[@id=\"shopping_cart_container\"]/a/span"));
cartIcon1.Click();

IWebElement removeJacket = driver.FindElement(By.Id("remove-sauce-labs-fleece-jacket"));
removeJacket.Click();

IWebElement contShopping1 = driver.FindElement(By.Id("continue-shopping"));
contShopping1.Click();

IWebElement fleeceJacket1= driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
fleeceJacket1.Click();

if (fleeceJacket1.Text != "remove-sauce-labs-fleece-jacket")
{
    Console.WriteLine("Removed fleece from shopping cart successfully");
}
else
{
    Console.WriteLine("Fleece failed to remove from shopping cart");
}

