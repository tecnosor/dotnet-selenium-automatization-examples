using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace tecnosor.automatization.instagram
{
    public class InstagramBot : IDisposable
    {
        public IWebDriver driver { get; private set; }
        public IDictionary<String, Object> vars { get; private set; }
        public IJavaScriptExecutor js { get; private set; }
        public InstagramBot()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<String, Object>();
        }
        public void Dispose() => driver.Quit();

        public void IniciarSesion()
        {
            Console.WriteLine($"Inicio de sesion MANUAL IG, 40 segundos de espera");
            driver.Navigate().GoToUrl("https://www.instagram.com/");
        }
        public void IgComment(string urlPublicacion, string comentario)
        {
            Console.WriteLine($"[{DateTime.Now.ToString()}] Comentario: {comentario} - START");
            driver.Navigate().GoToUrl(urlPublicacion);
            driver.Manage().Window.Size = new System.Drawing.Size(976, 1040);
            driver.FindElement(By.CssSelector(".x1qlqyl8")).Click();
            driver.FindElement(By.CssSelector(".x1qlqyl8")).SendKeys($"@{comentario} - otra participación más :D !");
            driver.FindElement(By.XPath("//form/div/div[2]/div")).Click();
            Console.WriteLine($"[{DateTime.Now.ToString()}] Comentario: {comentario} - DONE");
        }
    }
}