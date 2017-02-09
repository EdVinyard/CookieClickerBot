using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CookieClickerBot
{
    internal static class Program
    {
        public static void Main()
        {
            IWebDriver browser = new ChromeDriver(
                new ChromeOptions
                {
                    LeaveBrowserRunning = true,
                });

            browser.Navigate().GoToUrl("http://orteil.dashnet.org/cookieclicker/");
            var bot = new StupidBot(browser);

            while (true)
            {
                bot.Act();
            }
        }
    }
}
