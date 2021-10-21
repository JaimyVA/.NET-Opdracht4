namespace Opdracht4
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
            this.lbTitel = new System.Windows.Forms.Label();
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.cbTijd = new System.Windows.Forms.CheckBox();
            this.btnVolgendeTaak = new System.Windows.Forms.Button();
            this.btnVerwijderTaak = new System.Windows.Forms.Button();
            this.btnZetAchteraan = new System.Windows.Forms.Button();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.btnTextveld = new System.Windows.Forms.Button();
            this.tbMeedelen = new System.Windows.Forms.TextBox();
            this.tbAgenda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTitel
            // 
            this.lbTitel.AutoSize = true;
            this.lbTitel.Location = new System.Drawing.Point(12, 15);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(41, 20);
            this.lbTitel.TabIndex = 0;
            this.lbTitel.Text = "Titel:";
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(59, 13);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(241, 27);
            this.tbTitel.TabIndex = 1;
            // 
            // cbTijd
            // 
            this.cbTijd.AutoSize = true;
            this.cbTijd.Location = new System.Drawing.Point(389, 13);
            this.cbTijd.Name = "cbTijd";
            this.cbTijd.Size = new System.Drawing.Size(59, 24);
            this.cbTijd.TabIndex = 3;
            this.cbTijd.Text = "Tijd:";
            this.cbTijd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbTijd.UseVisualStyleBackColor = true;
            // 
            // btnVolgendeTaak
            // 
            this.btnVolgendeTaak.Location = new System.Drawing.Point(490, 83);
            this.btnVolgendeTaak.Name = "btnVolgendeTaak";
            this.btnVolgendeTaak.Size = new System.Drawing.Size(97, 54);
            this.btnVolgendeTaak.TabIndex = 4;
            this.btnVolgendeTaak.Text = "Volgende taak";
            this.btnVolgendeTaak.UseVisualStyleBackColor = true;
            this.btnVolgendeTaak.Click += new System.EventHandler(this.btnVolgendeTaak_Click);
            // 
            // btnVerwijderTaak
            // 
            this.btnVerwijderTaak.Location = new System.Drawing.Point(593, 83);
            this.btnVerwijderTaak.Name = "btnVerwijderTaak";
            this.btnVerwijderTaak.Size = new System.Drawing.Size(86, 54);
            this.btnVerwijderTaak.TabIndex = 5;
            this.btnVerwijderTaak.Text = "Verwijder taak";
            this.btnVerwijderTaak.UseVisualStyleBackColor = true;
            this.btnVerwijderTaak.Click += new System.EventHandler(this.btnVerwijderTaak_Click);
            // 
            // btnZetAchteraan
            // 
            this.btnZetAchteraan.Location = new System.Drawing.Point(685, 83);
            this.btnZetAchteraan.Name = "btnZetAchteraan";
            this.btnZetAchteraan.Size = new System.Drawing.Size(86, 54);
            this.btnZetAchteraan.TabIndex = 6;
            this.btnZetAchteraan.Text = "Zet Achteraan";
            this.btnZetAchteraan.UseVisualStyleBackColor = true;
            this.btnZetAchteraan.Click += new System.EventHandler(this.btnZetAchteraan_Click);
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(582, 12);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(97, 54);
            this.btnOpslaan.TabIndex = 7;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(432, 170);
            this.textBox1.TabIndex = 8;
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.BackColor = System.Drawing.Color.Red;
            this.btnMessageBox.Location = new System.Drawing.Point(19, 231);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(186, 29);
            this.btnMessageBox.TabIndex = 9;
            this.btnMessageBox.Text = "Meedelen in Messagebox";
            this.btnMessageBox.UseVisualStyleBackColor = false;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // btnTextveld
            // 
            this.btnTextveld.BackColor = System.Drawing.Color.Green;
            this.btnTextveld.Location = new System.Drawing.Point(262, 231);
            this.btnTextveld.Name = "btnTextveld";
            this.btnTextveld.Size = new System.Drawing.Size(186, 29);
            this.btnTextveld.TabIndex = 10;
            this.btnTextveld.Text = "Meedelen in Textveld";
            this.btnTextveld.UseVisualStyleBackColor = false;
            this.btnTextveld.Click += new System.EventHandler(this.btnTextveld_Click);
            // 
            // tbMeedelen
            // 
            this.tbMeedelen.Location = new System.Drawing.Point(19, 275);
            this.tbMeedelen.Multiline = true;
            this.tbMeedelen.Name = "tbMeedelen";
            this.tbMeedelen.Size = new System.Drawing.Size(425, 150);
            this.tbMeedelen.TabIndex = 11;
            // 
            // tbAgenda
            // 
            this.tbAgenda.Location = new System.Drawing.Point(490, 143);
            this.tbAgenda.Multiline = true;
            this.tbAgenda.Name = "tbAgenda";
            this.tbAgenda.Size = new System.Drawing.Size(281, 150);
            this.tbAgenda.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAgenda);
            this.Controls.Add(this.tbMeedelen);
            this.Controls.Add(this.btnTextveld);
            this.Controls.Add(this.btnMessageBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.btnZetAchteraan);
            this.Controls.Add(this.btnVerwijderTaak);
            this.Controls.Add(this.btnVolgendeTaak);
            this.Controls.Add(this.cbTijd);
            this.Controls.Add(this.tbTitel);
            this.Controls.Add(this.lbTitel);
            this.Name = "Form1";
            this.Text = "TeDoen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitel;
        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.CheckBox cbTijd;
        private System.Windows.Forms.Button btnVolgendeTaak;
        private System.Windows.Forms.Button btnVerwijderTaak;
        private System.Windows.Forms.Button btnZetAchteraan;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Button btnTextveld;
        private System.Windows.Forms.TextBox tbMeedelen;
        private System.Windows.Forms.TextBox tbAgenda;
    }
}

