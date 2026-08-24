namespace WinFormsApp1
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
            lblId = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtCargaHoraria = new TextBox();
            txtValor = new TextBox();
            lblNome = new Label();
            lblCargaHoraria = new Label();
            lblValor = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(361, 106);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            lblId.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(391, 103);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(391, 141);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCargaHoraria
            // 
            txtCargaHoraria.Location = new Point(391, 183);
            txtCargaHoraria.Name = "txtCargaHoraria";
            txtCargaHoraria.Size = new Size(100, 23);
            txtCargaHoraria.TabIndex = 3;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(391, 221);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 4;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(339, 144);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblCargaHoraria
            // 
            lblCargaHoraria.AutoSize = true;
            lblCargaHoraria.Location = new Point(299, 186);
            lblCargaHoraria.Name = "lblCargaHoraria";
            lblCargaHoraria.Size = new Size(80, 15);
            lblCargaHoraria.TabIndex = 6;
            lblCargaHoraria.Text = "Carga Horária";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(346, 224);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 7;
            lblValor.Text = "Valor";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(326, 259);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 491);
            Controls.Add(btnSalvar);
            Controls.Add(lblValor);
            Controls.Add(lblCargaHoraria);
            Controls.Add(lblNome);
            Controls.Add(txtValor);
            Controls.Add(txtCargaHoraria);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtCargaHoraria;
        private TextBox txtValor;
        private Label lblNome;
        private Label lblCargaHoraria;
        private Label lblValor;
        private Button btnSalvar;
    }
}
