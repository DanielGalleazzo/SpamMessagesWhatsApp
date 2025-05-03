namespace SpamMessagesWhatsAppWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtContato = new TextBox();
            txtQntd = new TextBox();
            txtMsg = new TextBox();
            botaoEnviar = new Button();
            SuspendLayout();
            // 
            // txtContato
            // 
            txtContato.Location = new Point(128, 147);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(203, 23);
            txtContato.TabIndex = 0;
            txtContato.TextChanged += txtContato_TextChanged;
            // 
            // txtQntd
            // 
            txtQntd.Location = new Point(187, 222);
            txtQntd.Name = "txtQntd";
            txtQntd.Size = new Size(70, 23);
            txtQntd.TabIndex = 1;
            txtQntd.TextChanged += txtQntd_TextChanged;
            // 
            // txtMsg
            // 
            txtMsg.Location = new Point(430, 147);
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(203, 23);
            txtMsg.TabIndex = 2;
            txtMsg.TextChanged += txtMsg_TextChanged;
            // 
            // botaoEnviar
            // 
            botaoEnviar.Location = new Point(430, 222);
            botaoEnviar.Name = "botaoEnviar";
            botaoEnviar.Size = new Size(203, 30);
            botaoEnviar.TabIndex = 3;
            botaoEnviar.Text = "Enviar";
            botaoEnviar.UseVisualStyleBackColor = true;
            botaoEnviar.Click += botaoEnviar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(785, 445);
            Controls.Add(botaoEnviar);
            Controls.Add(txtMsg);
            Controls.Add(txtQntd);
            Controls.Add(txtContato);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox txtContato;
        private TextBox txtQntd;
        private TextBox txtMsg;
        private Button botaoEnviar;
    }
}
