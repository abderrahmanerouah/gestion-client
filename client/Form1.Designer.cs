﻿
namespace client
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clients = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonajt = new System.Windows.Forms.Button();
            this.buttonmdf = new System.Windows.Forms.Button();
            this.buttonsupp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonenrg = new System.Windows.Forms.Button();
            this.buttonrech = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(641, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clients
            // 
            this.clients.AutoSize = true;
            this.clients.Location = new System.Drawing.Point(106, 228);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(48, 17);
            this.clients.TabIndex = 1;
            this.clients.Text = "clients";
            this.clients.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "LastName";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ville";
            this.label3.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adress";
            this.label4.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonajt
            // 
            this.buttonajt.Location = new System.Drawing.Point(21, 37);
            this.buttonajt.Name = "buttonajt";
            this.buttonajt.Size = new System.Drawing.Size(92, 44);
            this.buttonajt.TabIndex = 4;
            this.buttonajt.Text = "Ajouter";
            this.buttonajt.UseVisualStyleBackColor = true;
            this.buttonajt.Click += new System.EventHandler(this.buttonajt_Click);
            // 
            // buttonmdf
            // 
            this.buttonmdf.Location = new System.Drawing.Point(136, 35);
            this.buttonmdf.Name = "buttonmdf";
            this.buttonmdf.Size = new System.Drawing.Size(92, 44);
            this.buttonmdf.TabIndex = 4;
            this.buttonmdf.Text = "Modifier";
            this.buttonmdf.UseVisualStyleBackColor = true;
            this.buttonmdf.Click += new System.EventHandler(this.buttonmdf_Click);
            // 
            // buttonsupp
            // 
            this.buttonsupp.Location = new System.Drawing.Point(247, 35);
            this.buttonsupp.Name = "buttonsupp";
            this.buttonsupp.Size = new System.Drawing.Size(92, 44);
            this.buttonsupp.TabIndex = 4;
            this.buttonsupp.Text = "Supprimer";
            this.buttonsupp.UseVisualStyleBackColor = true;
            this.buttonsupp.Click += new System.EventHandler(this.buttonsupp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonsupp);
            this.groupBox1.Controls.Add(this.buttonenrg);
            this.groupBox1.Controls.Add(this.buttonrech);
            this.groupBox1.Controls.Add(this.buttonajt);
            this.groupBox1.Controls.Add(this.buttonmdf);
            this.groupBox1.Location = new System.Drawing.Point(450, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 213);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // buttonenrg
            // 
            this.buttonenrg.Location = new System.Drawing.Point(22, 87);
            this.buttonenrg.Name = "buttonenrg";
            this.buttonenrg.Size = new System.Drawing.Size(91, 44);
            this.buttonenrg.TabIndex = 4;
            this.buttonenrg.Text = "Enregistrer";
            this.buttonenrg.UseVisualStyleBackColor = true;
            this.buttonenrg.Click += new System.EventHandler(this.buttonenrg_Click);
            // 
            // buttonrech
            // 
            this.buttonrech.Location = new System.Drawing.Point(137, 87);
            this.buttonrech.Name = "buttonrech";
            this.buttonrech.Size = new System.Drawing.Size(91, 44);
            this.buttonrech.TabIndex = 4;
            this.buttonrech.Text = "chercher";
            this.buttonrech.UseVisualStyleBackColor = true;
            this.buttonrech.Click += new System.EventHandler(this.buttonrech_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(292, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(292, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID";
            this.label5.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(94, 121);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 587);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonajt;
        private System.Windows.Forms.Button buttonmdf;
        private System.Windows.Forms.Button buttonsupp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonenrg;
        private System.Windows.Forms.Button buttonrech;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
    }
}

