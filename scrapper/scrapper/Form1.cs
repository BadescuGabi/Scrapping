using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            IWebDriver driver = new ChromeDriver("C:/Users/Gabri/Desktop/vechi/repos/scrapper/scrapper");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://mightytext.net";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("login")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("identifierId")).SendKeys("gabore69@gmail.com");
            driver.FindElement(By.ClassName("VfPpkd-RLmnJb")).Click();
            driver.FindElement(By.ClassName("whsOndzHQkBf")).SendKeys("gabore69");



            Console.WriteLine(webBrowser1.Url);
            HtmlElement a = webBrowser1.Document.GetElementById("newSms");
            Console.WriteLine(a.InnerHtml);
            a.RaiseEvent("onclick");
            HtmlElement b = webBrowser1.Document.GetElementById("sendToTheseContacts");
            b.InnerText += "0755285220";
            Console.WriteLine(b.InnerHtml);
            HtmlElement c = webBrowser1.Document.GetElementById("send-one-text");
            c.InnerText = "salut";
        }

    }
}