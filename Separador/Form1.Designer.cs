﻿namespace Separador
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.qtd = new System.Windows.Forms.Label();
            this.lblcont = new System.Windows.Forms.Label();
            this.txtErros = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRenomear = new System.Windows.Forms.RadioButton();
            this.rbPadrao = new System.Windows.Forms.RadioButton();
            this.txtQuant_maior_zero = new System.Windows.Forms.TextBox();
            this.txtQuant_igual_zero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpRenomear = new System.Windows.Forms.GroupBox();
            this.novo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.separar = new System.Windows.Forms.Button();
            this.procurar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpRenomear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 20);
            this.textBox1.TabIndex = 1;
            // 
            // qtd
            // 
            this.qtd.AutoSize = true;
            this.qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(413, 54);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(42, 13);
            this.qtd.TabIndex = 6;
            this.qtd.Text = "Qtd = 0";
            // 
            // lblcont
            // 
            this.lblcont.AutoSize = true;
            this.lblcont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcont.Location = new System.Drawing.Point(0, 7);
            this.lblcont.Name = "lblcont";
            this.lblcont.Size = new System.Drawing.Size(51, 13);
            this.lblcont.TabIndex = 8;
            this.lblcont.Text = "Parado ";
            // 
            // txtErros
            // 
            this.txtErros.Location = new System.Drawing.Point(12, 228);
            this.txtErros.Name = "txtErros";
            this.txtErros.Size = new System.Drawing.Size(477, 221);
            this.txtErros.TabIndex = 9;
            this.txtErros.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Erro:";
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(12, 218);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(477, 10);
            this.progresso.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRenomear);
            this.groupBox1.Controls.Add(this.rbPadrao);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 54);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // rbRenomear
            // 
            this.rbRenomear.AutoSize = true;
            this.rbRenomear.Location = new System.Drawing.Point(9, 31);
            this.rbRenomear.Name = "rbRenomear";
            this.rbRenomear.Size = new System.Drawing.Size(74, 17);
            this.rbRenomear.TabIndex = 1;
            this.rbRenomear.Text = "Renomear";
            this.rbRenomear.UseVisualStyleBackColor = true;
            this.rbRenomear.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbPadrao
            // 
            this.rbPadrao.AutoSize = true;
            this.rbPadrao.Checked = true;
            this.rbPadrao.Location = new System.Drawing.Point(9, 8);
            this.rbPadrao.Name = "rbPadrao";
            this.rbPadrao.Size = new System.Drawing.Size(59, 17);
            this.rbPadrao.TabIndex = 0;
            this.rbPadrao.TabStop = true;
            this.rbPadrao.Text = "Padrão";
            this.rbPadrao.UseVisualStyleBackColor = true;
            this.rbPadrao.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtQuant_maior_zero
            // 
            this.txtQuant_maior_zero.Location = new System.Drawing.Point(9, 32);
            this.txtQuant_maior_zero.Name = "txtQuant_maior_zero";
            this.txtQuant_maior_zero.Size = new System.Drawing.Size(152, 20);
            this.txtQuant_maior_zero.TabIndex = 14;
            // 
            // txtQuant_igual_zero
            // 
            this.txtQuant_igual_zero.Location = new System.Drawing.Point(9, 77);
            this.txtQuant_igual_zero.Name = "txtQuant_igual_zero";
            this.txtQuant_igual_zero.Size = new System.Drawing.Size(152, 20);
            this.txtQuant_igual_zero.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pasta: Enviados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pasta: Quant = 0";
            // 
            // gpRenomear
            // 
            this.gpRenomear.Controls.Add(this.label2);
            this.gpRenomear.Controls.Add(this.label3);
            this.gpRenomear.Controls.Add(this.txtQuant_maior_zero);
            this.gpRenomear.Controls.Add(this.txtQuant_igual_zero);
            this.gpRenomear.Enabled = false;
            this.gpRenomear.Location = new System.Drawing.Point(114, 54);
            this.gpRenomear.Name = "gpRenomear";
            this.gpRenomear.Size = new System.Drawing.Size(200, 114);
            this.gpRenomear.TabIndex = 18;
            this.gpRenomear.TabStop = false;
            this.gpRenomear.Visible = false;
            // 
            // novo
            // 
            this.novo.Image = global::Separador.Properties.Resources.ic_add_black_24dp_1x;
            this.novo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.novo.Location = new System.Drawing.Point(12, 87);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(96, 26);
            this.novo.TabIndex = 11;
            this.novo.Text = "Novo";
            this.novo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 5);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // separar
            // 
            this.separar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.separar.Image = global::Separador.Properties.Resources.ic_fast_forward_black_24dp;
            this.separar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.separar.Location = new System.Drawing.Point(12, 59);
            this.separar.Name = "separar";
            this.separar.Size = new System.Drawing.Size(96, 26);
            this.separar.TabIndex = 4;
            this.separar.Text = "Separar";
            this.separar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.separar.UseVisualStyleBackColor = true;
            this.separar.Click += new System.EventHandler(this.separar_Click);
            // 
            // procurar
            // 
            this.procurar.Image = global::Separador.Properties.Resources.ic_search_black_18dp_1x;
            this.procurar.Location = new System.Drawing.Point(461, 31);
            this.procurar.Name = "procurar";
            this.procurar.Size = new System.Drawing.Size(28, 23);
            this.procurar.TabIndex = 0;
            this.procurar.UseVisualStyleBackColor = true;
            this.procurar.Click += new System.EventHandler(this.procurar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 456);
            this.Controls.Add(this.gpRenomear);
            this.Controls.Add(this.groupBox1);
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
            this.Text = "Separador EFD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpRenomear.ResumeLayout(false);
            this.gpRenomear.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRenomear;
        private System.Windows.Forms.RadioButton rbPadrao;
        private System.Windows.Forms.TextBox txtQuant_maior_zero;
        private System.Windows.Forms.TextBox txtQuant_igual_zero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpRenomear;
    }
}

