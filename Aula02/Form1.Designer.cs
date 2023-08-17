namespace Aula02
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.botaoIMG1 = new System.Windows.Forms.RadioButton();
            this.imgPIN = new System.Windows.Forms.RadioButton();
            this.botaoPSI = new System.Windows.Forms.RadioButton();
            this.groupborda = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.groupborda.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcbFoto
            // 
            this.pcbFoto.Image = global::Aula02.Properties.Resources.pinguim;
            this.pcbFoto.Location = new System.Drawing.Point(198, 33);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(474, 223);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 1;
            this.pcbFoto.TabStop = false;
            this.pcbFoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // botaoIMG1
            // 
            this.botaoIMG1.AutoSize = true;
            this.botaoIMG1.Location = new System.Drawing.Point(115, 318);
            this.botaoIMG1.Name = "botaoIMG1";
            this.botaoIMG1.Size = new System.Drawing.Size(101, 17);
            this.botaoIMG1.TabIndex = 2;
            this.botaoIMG1.TabStop = true;
            this.botaoIMG1.Text = "Direitos Autorais";
            this.botaoIMG1.UseVisualStyleBackColor = true;
            this.botaoIMG1.CheckedChanged += new System.EventHandler(this.botaoIMG1_CheckedChanged);
            // 
            // imgPIN
            // 
            this.imgPIN.AutoSize = true;
            this.imgPIN.Location = new System.Drawing.Point(115, 357);
            this.imgPIN.Name = "imgPIN";
            this.imgPIN.Size = new System.Drawing.Size(62, 17);
            this.imgPIN.TabIndex = 3;
            this.imgPIN.TabStop = true;
            this.imgPIN.Text = "Pinguim";
            this.imgPIN.UseVisualStyleBackColor = true;
            this.imgPIN.CheckedChanged += new System.EventHandler(this.imgPIN_CheckedChanged);
            // 
            // botaoPSI
            // 
            this.botaoPSI.AutoSize = true;
            this.botaoPSI.Location = new System.Drawing.Point(115, 395);
            this.botaoPSI.Name = "botaoPSI";
            this.botaoPSI.Size = new System.Drawing.Size(79, 17);
            this.botaoPSI.TabIndex = 4;
            this.botaoPSI.TabStop = true;
            this.botaoPSI.Text = "Psicodélico";
            this.botaoPSI.UseVisualStyleBackColor = true;
            this.botaoPSI.CheckedChanged += new System.EventHandler(this.botaoPSI_CheckedChanged);
            // 
            // groupborda
            // 
            this.groupborda.Controls.Add(this.radioButton3);
            this.groupborda.Controls.Add(this.radioButton2);
            this.groupborda.Controls.Add(this.radioButton1);
            this.groupborda.Location = new System.Drawing.Point(248, 285);
            this.groupborda.Name = "groupborda";
            this.groupborda.Size = new System.Drawing.Size(200, 145);
            this.groupborda.TabIndex = 5;
            this.groupborda.TabStop = false;
            this.groupborda.Text = "Borda";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(102, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nenhuma Borda";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 73);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "3D";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 110);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Normal";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(473, 357);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Não quero imagem";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupborda);
            this.Controls.Add(this.botaoPSI);
            this.Controls.Add(this.imgPIN);
            this.Controls.Add(this.botaoIMG1);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.groupborda.ResumeLayout(false);
            this.groupborda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.RadioButton botaoIMG1;
        private System.Windows.Forms.RadioButton imgPIN;
        private System.Windows.Forms.RadioButton botaoPSI;
        private System.Windows.Forms.GroupBox groupborda;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
    }
}

