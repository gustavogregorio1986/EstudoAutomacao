// Cria uma instância do Chrome
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();

// Abre o Google
driver.Navigate().GoToUrl("https://www.google.com");

// Encontra o campo de busca pelo nome "q"
IWebElement searchBox = driver.FindElement(By.Name("q"));

// Digita o texto no campo
searchBox.SendKeys("Selenium C#");

// Pressiona Enter
searchBox.SendKeys(Keys.Enter);

// Aguarda 3 segundos só para ver o resultado
System.Threading.Thread.Sleep(3000);

// Fecha o navegador
driver.Quit();
