namespace buscaCep
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
            mskCEP = new TextBox();
            btnBuscar_Click = new Button();
            lblLogradouro = new Label();
            lblBairro = new Label();
            lblLocalidade = new Label();
            lblUf = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // mskCEP
            // 
            mskCEP.Location = new Point(45, 59);
            mskCEP.Name = "mskCEP";
            mskCEP.Size = new Size(100, 23);
            mskCEP.TabIndex = 0;
            // 
            // btnBuscar_Click
            // 
            btnBuscar_Click.Location = new Point(214, 58);
            btnBuscar_Click.Name = "btnBuscar_Click";
            btnBuscar_Click.Size = new Size(171, 23);
            btnBuscar_Click.TabIndex = 1;
            btnBuscar_Click.Text = "Buscar Endereço";
            btnBuscar_Click.UseVisualStyleBackColor = true;
            btnBuscar_Click.Click += btnBuscar_Click_Click;
            // 
            // lblLogradouro
            // 
            lblLogradouro.BorderStyle = BorderStyle.FixedSingle;
            lblLogradouro.Location = new Point(45, 181);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(694, 33);
            lblLogradouro.TabIndex = 2;
            lblLogradouro.Text = "...";
            // 
            // lblBairro
            // 
            lblBairro.BorderStyle = BorderStyle.FixedSingle;
            lblBairro.Location = new Point(45, 229);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(694, 33);
            lblBairro.TabIndex = 3;
            lblBairro.Text = "...";
            // 
            // lblLocalidade
            // 
            lblLocalidade.BorderStyle = BorderStyle.FixedSingle;
            lblLocalidade.Location = new Point(45, 274);
            lblLocalidade.Name = "lblLocalidade";
            lblLocalidade.Size = new Size(694, 33);
            lblLocalidade.TabIndex = 4;
            lblLocalidade.Text = "...";
            lblLocalidade.Click += label3_Click;
            // 
            // lblUf
            // 
            lblUf.BorderStyle = BorderStyle.FixedSingle;
            lblUf.Location = new Point(45, 327);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(694, 33);
            lblUf.TabIndex = 5;
            lblUf.Text = "...";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(45, 136);
            label5.Name = "label5";
            label5.Size = new Size(694, 33);
            label5.TabIndex = 6;
            label5.Text = "Endereço";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(lblUf);
            Controls.Add(lblLocalidade);
            Controls.Add(lblBairro);
            Controls.Add(lblLogradouro);
            Controls.Add(btnBuscar_Click);
            Controls.Add(mskCEP);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox mskCEP;
        private Button btnBuscar_Click;
        private Label lblLogradouro;
        private Label lblBairro;
        private Label lblLocalidade;
        private Label lblUf;
        private Label label5;
    }
}
