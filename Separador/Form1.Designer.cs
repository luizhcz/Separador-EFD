namespace Separador
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.procurar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.separar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.qtd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblcont = new System.Windows.Forms.Label();
            this.txtErros = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.novo = new System.Windows.Forms.Button();
            this.progresso = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // procurar
            // 
            this.procurar.Location = new System.Drawing.Point(434, 31);
            this.procurar.Name = "procurar";
            this.procurar.Size = new System.Drawing.Size(75, 23);
            this.procurar.TabIndex = 0;
            this.procurar.Text = "Procurar";
            this.procurar.UseVisualStyleBackColor = true;
            this.procurar.Click += new System.EventHandler(this.procurar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 20);
            this.textBox1.TabIndex = 1;
            // 
            // separar
            // 
            this.separar.Location = new System.Drawing.Point(12, 59);
            this.separar.Name = "separar";
            this.separar.Size = new System.Drawing.Size(75, 23);
            this.separar.TabIndex = 4;
            this.separar.Text = "Separar";
            this.separar.UseVisualStyleBackColor = true;
            this.separar.Click += new System.EventHandler(this.separar_Click);
            // 
            // qtd
            // 
            this.qtd.AutoSize = true;
            this.qtd.Location = new System.Drawing.Point(386, 17);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(42, 13);
            this.qtd.TabIndex = 6;
            this.qtd.Text = "Qtd = 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 10);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblcont
            // 
            this.lblcont.AutoSize = true;
            this.lblcont.Location = new System.Drawing.Point(0, 10);
            this.lblcont.Name = "lblcont";
            this.lblcont.Size = new System.Drawing.Size(44, 13);
            this.lblcont.TabIndex = 8;
            this.lblcont.Text = "Parado ";
            // 
            // txtErros
            // 
            this.txtErros.Location = new System.Drawing.Point(0, 111);
            this.txtErros.Name = "txtErros";
            this.txtErros.Size = new System.Drawing.Size(518, 229);
            this.txtErros.TabIndex = 9;
            this.txtErros.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Erro:";
            // 
            // novo
            // 
            this.novo.Location = new System.Drawing.Point(93, 59);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(75, 23);
            this.novo.TabIndex = 11;
            this.novo.Text = "Novo";
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(0, 101);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(518, 10);
            this.progresso.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 337);
            this.Controls.Add(this.progresso);
            this.Controls.Add(this.novo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtErros);
            this.Controls.Add(this.lblcont);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.separar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.procurar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Separador ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button procurar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button separar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label qtd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblcont;
        private System.Windows.Forms.RichTextBox txtErros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button novo;
        private System.Windows.Forms.ProgressBar progresso;
    }
}

