using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyAutomationFramework;
public class SpamWhatsApp : Web
{
    static void Main(string[] args)
    {
        var bot = new SpamWhatsApp();
        Console.WriteLine("Quantas mensagens deseja enviar?");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Digite o nome do contato ou grupo: ");
        string para = Console.ReadLine();
        Console.Write("Digite a mensagem: ");
        string mensagem = Console.ReadLine();

        bot.Starting();
        for (int i = 0; i < n; i++)
        {
            bot.SendMessage(para, mensagem);
        }
    }
    public void Starting ()
    {
        StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\danie\\AppData\\Local\\Google\\Chrome\\User Data");
        Navigate("https://web.whatsapp.com/");
        WaitForLoad(10000);
    }
    public void SendMessage(string para, string mensagem)
    {
        
        var elementSearch = AssignValue(TypeElement.Xpath, "//*[@contenteditable='true']", para);
        elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);
        System.Threading.Thread.Sleep(1000);    
        var elemenSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span/div/div[2]/div[1]/div[2]/div[1]/p", mensagem);
        elemenSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);
    }
}
