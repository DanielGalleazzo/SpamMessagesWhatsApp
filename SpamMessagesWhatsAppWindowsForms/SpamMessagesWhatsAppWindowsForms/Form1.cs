using EasyAutomationFramework;
using static SpamMessagesWhatsAppWindowsForms.Metodo;

namespace SpamMessagesWhatsAppWindowsForms
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

        private void txtContato_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQntd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoEnviar_Click(object sender, EventArgs e)
        {
            string contato = txtContato.Text;
            string mensagem = txtMsg.Text;
            int quantidade = int.Parse(txtQntd.Text);

            var bot = new SpamWhatsApp();
            bot.Starting();
            for (int i = 0; i < quantidade; i++)
            {
                bot.SendMessage(contato, mensagem);
            }

            MessageBox.Show("Mensagens enviadas.");
        }
        public class SpamWhatsApp : Web
        {
            public void Starting()
            {
                StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\danie\\AppData\\Local\\Google\\Chrome\\User Data");
                Navigate("https://web.whatsapp.com/");
                WaitForLoad(10000);

            }
            public void SendMessage(string para, string mensagem)
            {
                var contato = AssignValue(TypeElement.Xpath, "//*[@id=side]/div[1]/div/div[2]/div/div/div/p", para);
                contato.element.SendKeys(OpenQA.Selenium.Keys.Enter);
                System.Threading.Thread.Sleep(1000);
                var msg = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span/div/div[2]/div[1]/div[2]/div[1]/p", mensagem);
                msg.element.SendKeys(OpenQA.Selenium.Keys.Enter);
            }
        }
    }
}