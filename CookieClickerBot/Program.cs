using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CookieClickerBot
{
    public static class Program
    {
        public static void Main(string[] args)
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
