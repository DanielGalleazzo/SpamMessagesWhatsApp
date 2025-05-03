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
            string para = txtContato.Text;
        }

        private void txtQntd_TextChanged(object sender, EventArgs e)
        {
            int n = int.Parse(txtQntd.Text);
        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {
            string mensagem = txtContato.Text;
        }

        private void botaoEnviar_Click(object sender, EventArgs e)
        {
            string para = txtContato.Text;
            string mensagem = txtMsg.Text;
            int n = int.Parse(txtQntd.Text); 

            Metodo metodo = new Metodo();
            metodo.SendMessage(para, mensagem);

            for (int i = 0; i < n; i++)
            {
                metodo.SendMessage(para, mensagem);
            }
        }
    }
}
