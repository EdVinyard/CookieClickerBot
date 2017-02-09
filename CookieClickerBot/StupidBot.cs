using OpenQA.Selenium;

namespace CookieClickerBot
{
    public class StupidBot
    {
        private readonly IWebDriver _browser;

        public StupidBot(IWebDriver browser)
        {
            _browser = browser;
        }

        public void Act()
        {
            // click on the big cookie
            _browser.FindElement(By.Id("bigCookie")).Click();
        }
    }
}
