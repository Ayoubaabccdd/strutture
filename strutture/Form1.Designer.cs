﻿namespace strutture
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.nome = new System.Windows.Forms.TextBox();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salva = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.visu = new System.Windows.Forms.Button();
            this.modi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modiprezzo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Modifica = new System.Windows.Forms.Button();
            this.modinome1 = new System.Windows.Forms.TextBox();
            this.modinome = new System.Windows.Forms.Label();
            this.Cancella = new System.Windows.Forms.Button();
            this.Somma = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.modip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(133, 105);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 0;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(245, 105);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(100, 20);
            this.prezzo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezzo";
            // 
            // salva
            // 
            this.salva.Location = new System.Drawing.Point(12, 105);
            this.salva.Name = "salva";
            this.salva.Size = new System.Drawing.Size(75, 23);
            this.salva.TabIndex = 4;
            this.salva.Text = "salva";
            this.salva.UseVisualStyleBackColor = true;
            this.salva.Click += new System.EventHandler(this.salva_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(516, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(252, 362);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // visu
            // 
            this.visu.Location = new System.Drawing.Point(12, 134);
            this.visu.Name = "visu";
            this.visu.Size = new System.Drawing.Size(75, 23);
            this.visu.TabIndex = 0;
            this.visu.Text = "Visualizza";
            this.visu.UseVisualStyleBackColor = true;
            this.visu.Click += new System.EventHandler(this.visu_Click);
            // 
            // modi
            // 
            this.modi.Location = new System.Drawing.Point(94, 174);
            this.modi.Name = "modi";
            this.modi.Size = new System.Drawing.Size(100, 20);
            this.modi.TabIndex = 7;
            this.modi.TextChanged += new System.EventHandler(this.modi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ricerca nome";
            // 
            // modiprezzo
            // 
            this.modiprezzo.Location = new System.Drawing.Point(104, 226);
            this.modiprezzo.Name = "modiprezzo";
            this.modiprezzo.Size = new System.Drawing.Size(100, 20);
            this.modiprezzo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Modifica prezzo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Modifica
            // 
            this.Modifica.Location = new System.Drawing.Point(13, 223);
            this.Modifica.Name = "Modifica";
            this.Modifica.Size = new System.Drawing.Size(75, 23);
            this.Modifica.TabIndex = 11;
            this.Modifica.Text = "Modifca";
            this.Modifica.UseVisualStyleBackColor = true;
            this.Modifica.Click += new System.EventHandler(this.Modifica_Click);
            // 
            // modinome1
            // 
            this.modinome1.Location = new System.Drawing.Point(232, 226);
            this.modinome1.Name = "modinome1";
            this.modinome1.Size = new System.Drawing.Size(100, 20);
            this.modinome1.TabIndex = 13;
            this.modinome1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // modinome
            // 
            this.modinome.AutoSize = true;
            this.modinome.Location = new System.Drawing.Point(226, 210);
            this.modinome.Name = "modinome";
            this.modinome.Size = new System.Drawing.Size(76, 13);
            this.modinome.TabIndex = 14;
            this.modinome.Text = "Modifica nome";
            this.modinome.Click += new System.EventHandler(this.modinome_Click);
            // 
            // Cancella
            // 
            this.Cancella.Location = new System.Drawing.Point(13, 252);
            this.Cancella.Name = "Cancella";
            this.Cancella.Size = new System.Drawing.Size(75, 23);
            this.Cancella.TabIndex = 15;
            this.Cancella.Text = "Cancella";
            this.Cancella.UseVisualStyleBackColor = true;
            this.Cancella.Click += new System.EventHandler(this.Cancella_Click);
            // 
            // Somma
            // 
            this.Somma.Location = new System.Drawing.Point(12, 283);
            this.Somma.Name = "Somma";
            this.Somma.Size = new System.Drawing.Size(75, 23);
            this.Somma.TabIndex = 16;
            this.Somma.Text = "Somma";
            this.Somma.UseVisualStyleBackColor = true;
            this.Somma.Click += new System.EventHandler(this.Somma_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Percentuale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modip
            // 
            this.modip.Location = new System.Drawing.Point(104, 312);
            this.modip.Name = "modip";
            this.modip.Size = new System.Drawing.Size(100, 20);
            this.modip.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "sconto da applicare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Somma);
            this.Controls.Add(this.Cancella);
            this.Controls.Add(this.modinome);
            this.Controls.Add(this.modinome1);
            this.Controls.Add(this.Modifica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modiprezzo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modi);
            this.Controls.Add(this.visu);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.salva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.nome);
            this.Name = "Form1";
            this.Text = "Cancella";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button salva;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button visu;
        private System.Windows.Forms.TextBox modi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modiprezzo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Modifica;
        private System.Windows.Forms.TextBox modinome1;
        private System.Windows.Forms.Label modinome;
        private System.Windows.Forms.Button Cancella;
        private System.Windows.Forms.Button Somma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox modip;
        private System.Windows.Forms.Label label5;
    }
}

