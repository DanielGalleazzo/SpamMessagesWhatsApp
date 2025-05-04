using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyAutomationFramework;

namespace SpamMessagesWhatsAppWindowsForms
{
    internal class Metodo : Web
    {
        public class WhatsAppSendMessage : Web
        {
            public void SendMessage(string para, string mensagem)
            {
                StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\danie\\AppData\\Local\\Google\\Chrome\\User Data");
                Navigate("https://web.whatsapp.com/");
                WaitForLoad();
                var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div[2]/div/div/div/p", para);
                elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

                var elemenSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span/div/div[2]/div[1]/div[2]/div[1]/p", mensagem);
                elemenSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            }
        }
    }
}