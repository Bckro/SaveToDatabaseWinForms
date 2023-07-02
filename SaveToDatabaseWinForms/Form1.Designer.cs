namespace SaveToDatabaseWinForms
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
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelWiek = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelKod = new System.Windows.Forms.Label();
            this.buttonPrzekazDane = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(219, 74);
            this.textBoxNazwisko.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(148, 30);
            this.textBoxNazwisko.TabIndex = 0;
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Location = new System.Drawing.Point(219, 118);
            this.textBoxWiek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(148, 30);
            this.textBoxWiek.TabIndex = 1;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(219, 162);
            this.textBoxAdres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(148, 30);
            this.textBoxAdres.TabIndex = 2;
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(219, 206);
            this.textBoxKod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(148, 30);
            this.textBoxKod.TabIndex = 3;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(219, 31);
            this.textBoxImie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(148, 30);
            this.textBoxImie.TabIndex = 4;
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(70, 31);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(19, 25);
            this.labelImie.TabIndex = 5;
            this.labelImie.Text = "-";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(70, 77);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(19, 25);
            this.labelNazwisko.TabIndex = 6;
            this.labelNazwisko.Text = "-";
            // 
            // labelWiek
            // 
            this.labelWiek.AutoSize = true;
            this.labelWiek.Location = new System.Drawing.Point(70, 118);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(19, 25);
            this.labelWiek.TabIndex = 7;
            this.labelWiek.Text = "-";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(70, 162);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(19, 25);
            this.labelAdres.TabIndex = 8;
            this.labelAdres.Text = "-";
            // 
            // labelKod
            // 
            this.labelKod.AutoSize = true;
            this.labelKod.Location = new System.Drawing.Point(70, 206);
            this.labelKod.Name = "labelKod";
            this.labelKod.Size = new System.Drawing.Size(19, 25);
            this.labelKod.TabIndex = 9;
            this.labelKod.Text = "-";
            // 
            // buttonPrzekazDane
            // 
            this.buttonPrzekazDane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrzekazDane.Location = new System.Drawing.Point(219, 268);
            this.buttonPrzekazDane.Name = "buttonPrzekazDane";
            this.buttonPrzekazDane.Size = new System.Drawing.Size(148, 30);
            this.buttonPrzekazDane.TabIndex = 10;
            this.buttonPrzekazDane.Text = "Save data";
            this.buttonPrzekazDane.UseVisualStyleBackColor = true;
            this.buttonPrzekazDane.Click += new System.EventHandler(this.buttonPrzekazDane_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 328);
            this.Controls.Add(this.buttonPrzekazDane);
            this.Controls.Add(this.labelKod);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelWiek);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.textBoxKod);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxWiek);
            this.Controls.Add(this.textBoxNazwisko);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Personal information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelKod;
        private System.Windows.Forms.Button buttonPrzekazDane;
    }
}

