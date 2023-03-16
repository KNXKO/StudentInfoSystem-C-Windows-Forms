namespace Lukas_Lechovic_06
{
    partial class FormStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltext = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.btnUlozit = new System.Windows.Forms.Button();
            this.txtPsc = new System.Windows.Forms.TextBox();
            this.lblPsc = new System.Windows.Forms.Label();
            this.txtBydlisko = new System.Windows.Forms.TextBox();
            this.lblBydlisko = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lvlBirthDate = new System.Windows.Forms.Label();
            this.txtPriezvisko = new System.Windows.Forms.TextBox();
            this.lblPriezvisko = new System.Windows.Forms.Label();
            this.txtMeno = new System.Windows.Forms.TextBox();
            this.lblMeno = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lbltext);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("UCM Sans Book", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltext.ForeColor = System.Drawing.Color.White;
            this.lbltext.Location = new System.Drawing.Point(32, 32);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(238, 38);
            this.lbltext.TabIndex = 0;
            this.lbltext.Text = "Pridať študenta";
            this.lbltext.Click += new System.EventHandler(this.lbltext_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtDate);
            this.panel2.Controls.Add(this.btnUlozit);
            this.panel2.Controls.Add(this.txtPsc);
            this.panel2.Controls.Add(this.lblPsc);
            this.panel2.Controls.Add(this.txtBydlisko);
            this.panel2.Controls.Add(this.lblBydlisko);
            this.panel2.Controls.Add(this.txtTelefon);
            this.panel2.Controls.Add(this.lblTelefon);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lvlBirthDate);
            this.panel2.Controls.Add(this.txtPriezvisko);
            this.panel2.Controls.Add(this.lblPriezvisko);
            this.panel2.Controls.Add(this.txtMeno);
            this.panel2.Controls.Add(this.lblMeno);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(32, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 390);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(21, 113);
            this.txtDate.MaxDate = new System.DateTime(2022, 10, 31, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(1900, 3, 10, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 23);
            this.txtDate.TabIndex = 10;
            this.txtDate.Value = new System.DateTime(2022, 10, 31, 0, 0, 0, 0);
            this.txtDate.ValueChanged += new System.EventHandler(this.txtDate_ValueChanged);
            // 
            // btnUlozit
            // 
            this.btnUlozit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUlozit.FlatAppearance.BorderSize = 0;
            this.btnUlozit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUlozit.Font = new System.Drawing.Font("Encode Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUlozit.ForeColor = System.Drawing.Color.Snow;
            this.btnUlozit.Location = new System.Drawing.Point(21, 309);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(100, 30);
            this.btnUlozit.TabIndex = 8;
            this.btnUlozit.Text = "Pridať";
            this.btnUlozit.UseVisualStyleBackColor = false;
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // txtPsc
            // 
            this.txtPsc.BackColor = System.Drawing.Color.White;
            this.txtPsc.Font = new System.Drawing.Font("Encode Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPsc.Location = new System.Drawing.Point(199, 260);
            this.txtPsc.MaxLength = 7;
            this.txtPsc.Name = "txtPsc";
            this.txtPsc.PlaceholderText = "900 86";
            this.txtPsc.Size = new System.Drawing.Size(141, 22);
            this.txtPsc.TabIndex = 7;
            this.txtPsc.TextChanged += new System.EventHandler(this.txtPsc_TextChanged);
            // 
            // lblPsc
            // 
            this.lblPsc.AutoSize = true;
            this.lblPsc.Font = new System.Drawing.Font("Encode Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPsc.Location = new System.Drawing.Point(199, 237);
            this.lblPsc.Name = "lblPsc";
            this.lblPsc.Size = new System.Drawing.Size(31, 18);
            this.lblPsc.TabIndex = 0;
            this.lblPsc.Text = "PSC:";
            // 
            // txtBydlisko
            // 
            this.txtBydlisko.BackColor = System.Drawing.Color.White;
            this.txtBydlisko.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBydlisko.Font = new System.Drawing.Font("Encode Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBydlisko.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBydlisko.Location = new System.Drawing.Point(21, 260);
            this.txtBydlisko.MaxLength = 60;
            this.txtBydlisko.Name = "txtBydlisko";
            this.txtBydlisko.PlaceholderText = "Budmerice 747";
            this.txtBydlisko.Size = new System.Drawing.Size(141, 22);
            this.txtBydlisko.TabIndex = 6;
            // 
            // lblBydlisko
            // 
            this.lblBydlisko.AutoSize = true;
            this.lblBydlisko.Font = new System.Drawing.Font("Encode Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBydlisko.Location = new System.Drawing.Point(21, 237);
            this.lblBydlisko.Name = "lblBydlisko";
            this.lblBydlisko.Size = new System.Drawing.Size(54, 18);
            this.lblBydlisko.TabIndex = 0;
            this.lblBydlisko.Text = "Bydlisko:";
            this.lblBydlisko.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.White;
            this.txtTelefon.Font = new System.Drawing.Font("Encode Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefon.Location = new System.Drawing.Point(199, 113);
            this.txtTelefon.MaxLength = 15;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.PlaceholderText = "+421 915 545 006";
            this.txtTelefon.Size = new System.Drawing.Size(141, 22);
            this.txtTelefon.TabIndex = 5;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Encode Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefon.Location = new System.Drawing.Point(199, 92);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(49, 18);
            this.lblTelefon.TabIndex = 0;
            this.lblTelefon.Text = "Telefón:";
            this.lblTelefon.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Encode Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(21, 187);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "lukaslechovic@gmail.com";
            this.txtEmail.Size = new System.Drawing.Size(176, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Encode Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(21, 166);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 18);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // lvlBirthDate
            // 
            this.lvlBirthDate.AutoSize = true;
            this.lvlBirthDate.Font = new System.Drawing.Font("Encode Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvlBirthDate.Location = new System.Drawing.Point(21, 92);
            this.lvlBirthDate.Name = "lvlBirthDate";
            this.lvlBirthDate.Size = new System.Drawing.Size(100, 18);
            this.lvlBirthDate.TabIndex = 0;
            this.lvlBirthDate.Text = "Dátum narodenia:";
            this.lvlBirthDate.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtPriezvisko
            // 
            this.txtPriezvisko.BackColor = System.Drawing.Color.White;
            this.txtPriezvisko.Font = new System.Drawing.Font("Encode Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPriezvisko.Location = new System.Drawing.Point(199, 45);
            this.txtPriezvisko.MaxLength = 30;
            this.txtPriezvisko.Name = "txtPriezvisko";
            this.txtPriezvisko.PlaceholderText = "Lechovič";
            this.txtPriezvisko.Size = new System.Drawing.Size(141, 22);
            this.txtPriezvisko.TabIndex = 2;
            // 
            // lblPriezvisko
            // 
            this.lblPriezvisko.AutoSize = true;
            this.lblPriezvisko.Font = new System.Drawing.Font("Encode Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPriezvisko.Location = new System.Drawing.Point(199, 22);
            this.lblPriezvisko.Name = "lblPriezvisko";
            this.lblPriezvisko.Size = new System.Drawing.Size(62, 18);
            this.lblPriezvisko.TabIndex = 0;
            this.lblPriezvisko.Text = "Priezvisko:";
            this.lblPriezvisko.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMeno
            // 
            this.txtMeno.BackColor = System.Drawing.Color.White;
            this.txtMeno.Font = new System.Drawing.Font("Encode Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMeno.Location = new System.Drawing.Point(21, 45);
            this.txtMeno.MaxLength = 30;
            this.txtMeno.Name = "txtMeno";
            this.txtMeno.PlaceholderText = "Lukáš";
            this.txtMeno.Size = new System.Drawing.Size(141, 22);
            this.txtMeno.TabIndex = 1;
            this.txtMeno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMeno
            // 
            this.lblMeno.AutoSize = true;
            this.lblMeno.Font = new System.Drawing.Font("Encode Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMeno.Location = new System.Drawing.Point(21, 22);
            this.lblMeno.Name = "lblMeno";
            this.lblMeno.Size = new System.Drawing.Size(40, 18);
            this.lblMeno.TabIndex = 0;
            this.lblMeno.Text = "Meno:";
            this.lblMeno.Click += new System.EventHandler(this.lblName_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbltext;
        private Panel panel2;
        private TextBox txtMeno;
        private Label lblMeno;
        private TextBox txtPriezvisko;
        private Label lblPriezvisko;
        private Label lvlBirthDate;
        private TextBox txtTelefon;
        private Label lblTelefon;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPsc;
        private Label lblPsc;
        private TextBox txtBydlisko;
        private Label lblBydlisko;
        private Button btnUlozit;
        private DateTimePicker txtDate;
    }
}