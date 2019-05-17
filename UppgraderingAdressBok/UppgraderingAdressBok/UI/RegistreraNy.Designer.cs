namespace UppgraderingAdressBok.UI
{
    partial class RegistreraNy
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label efternamnLabel;
            System.Windows.Forms.Label förnamnLabel;
            System.Windows.Forms.Label gatunamnLabel;
            System.Windows.Forms.Label postnummerLabel;
            System.Windows.Forms.Label postortLabel;
            System.Windows.Forms.Label epostaddressLabel;
            System.Windows.Forms.Label riktnummerLabel;
            System.Windows.Forms.Label telefonnummerLabel;
            System.Windows.Forms.Label iDLabel;
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.efternamnTextBox = new System.Windows.Forms.TextBox();
            this.förnamnTextBox = new System.Windows.Forms.TextBox();
            this.adressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gatunamnTextBox = new System.Windows.Forms.TextBox();
            this.postnummerTextBox = new System.Windows.Forms.TextBox();
            this.postortTextBox = new System.Windows.Forms.TextBox();
            this.epostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.epostaddressTextBox = new System.Windows.Forms.TextBox();
            this.telefonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.riktnummerTextBox = new System.Windows.Forms.TextBox();
            this.telefonnummerTextBox = new System.Windows.Forms.TextBox();
            this.kontakttypBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            efternamnLabel = new System.Windows.Forms.Label();
            förnamnLabel = new System.Windows.Forms.Label();
            gatunamnLabel = new System.Windows.Forms.Label();
            postnummerLabel = new System.Windows.Forms.Label();
            postortLabel = new System.Windows.Forms.Label();
            epostaddressLabel = new System.Windows.Forms.Label();
            riktnummerLabel = new System.Windows.Forms.Label();
            telefonnummerLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontakttypBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // efternamnLabel
            // 
            efternamnLabel.AutoSize = true;
            efternamnLabel.Location = new System.Drawing.Point(34, 70);
            efternamnLabel.Name = "efternamnLabel";
            efternamnLabel.Size = new System.Drawing.Size(58, 13);
            efternamnLabel.TabIndex = 1;
            efternamnLabel.Text = "Efternamn:";
            // 
            // förnamnLabel
            // 
            förnamnLabel.AutoSize = true;
            förnamnLabel.Location = new System.Drawing.Point(41, 36);
            förnamnLabel.Name = "förnamnLabel";
            förnamnLabel.Size = new System.Drawing.Size(51, 13);
            förnamnLabel.TabIndex = 3;
            förnamnLabel.Text = "Förnamn:";
            // 
            // gatunamnLabel
            // 
            gatunamnLabel.AutoSize = true;
            gatunamnLabel.Location = new System.Drawing.Point(33, 109);
            gatunamnLabel.Name = "gatunamnLabel";
            gatunamnLabel.Size = new System.Drawing.Size(59, 13);
            gatunamnLabel.TabIndex = 4;
            gatunamnLabel.Text = "Gatunamn:";
            // 
            // postnummerLabel
            // 
            postnummerLabel.AutoSize = true;
            postnummerLabel.Location = new System.Drawing.Point(24, 149);
            postnummerLabel.Name = "postnummerLabel";
            postnummerLabel.Size = new System.Drawing.Size(68, 13);
            postnummerLabel.TabIndex = 6;
            postnummerLabel.Text = "Postnummer:";
            // 
            // postortLabel
            // 
            postortLabel.AutoSize = true;
            postortLabel.Location = new System.Drawing.Point(49, 189);
            postortLabel.Name = "postortLabel";
            postortLabel.Size = new System.Drawing.Size(43, 13);
            postortLabel.TabIndex = 8;
            postortLabel.Text = "Postort:";
            // 
            // epostaddressLabel
            // 
            epostaddressLabel.AutoSize = true;
            epostaddressLabel.Location = new System.Drawing.Point(18, 301);
            epostaddressLabel.Name = "epostaddressLabel";
            epostaddressLabel.Size = new System.Drawing.Size(74, 13);
            epostaddressLabel.TabIndex = 10;
            epostaddressLabel.Text = "Epostaddress:";
            // 
            // riktnummerLabel
            // 
            riktnummerLabel.AutoSize = true;
            riktnummerLabel.Location = new System.Drawing.Point(26, 220);
            riktnummerLabel.Name = "riktnummerLabel";
            riktnummerLabel.Size = new System.Drawing.Size(66, 13);
            riktnummerLabel.TabIndex = 12;
            riktnummerLabel.Text = "Riktnummer:";
            // 
            // telefonnummerLabel
            // 
            telefonnummerLabel.AutoSize = true;
            telefonnummerLabel.Location = new System.Drawing.Point(9, 260);
            telefonnummerLabel.Name = "telefonnummerLabel";
            telefonnummerLabel.Size = new System.Drawing.Size(83, 13);
            telefonnummerLabel.TabIndex = 14;
            telefonnummerLabel.Text = "Telefonnummer:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(41, 377);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(47, 13);
            iDLabel.TabIndex = 16;
            iDLabel.Text = "Kontakt:";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(UppgraderingAdressBok.Model.Person);
            // 
            // efternamnTextBox
            // 
            this.efternamnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Efternamn", true));
            this.efternamnTextBox.Location = new System.Drawing.Point(98, 67);
            this.efternamnTextBox.Name = "efternamnTextBox";
            this.efternamnTextBox.Size = new System.Drawing.Size(177, 20);
            this.efternamnTextBox.TabIndex = 2;
            // 
            // förnamnTextBox
            // 
            this.förnamnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Förnamn", true));
            this.förnamnTextBox.Location = new System.Drawing.Point(98, 29);
            this.förnamnTextBox.Name = "förnamnTextBox";
            this.förnamnTextBox.Size = new System.Drawing.Size(177, 20);
            this.förnamnTextBox.TabIndex = 4;
            // 
            // adressBindingSource
            // 
            this.adressBindingSource.DataSource = typeof(UppgraderingAdressBok.Model.Adress);
            // 
            // gatunamnTextBox
            // 
            this.gatunamnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressBindingSource, "Gatunamn", true));
            this.gatunamnTextBox.Location = new System.Drawing.Point(98, 106);
            this.gatunamnTextBox.Name = "gatunamnTextBox";
            this.gatunamnTextBox.Size = new System.Drawing.Size(177, 20);
            this.gatunamnTextBox.TabIndex = 5;
            // 
            // postnummerTextBox
            // 
            this.postnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressBindingSource, "Postnummer", true));
            this.postnummerTextBox.Location = new System.Drawing.Point(98, 142);
            this.postnummerTextBox.Name = "postnummerTextBox";
            this.postnummerTextBox.Size = new System.Drawing.Size(177, 20);
            this.postnummerTextBox.TabIndex = 7;
            // 
            // postortTextBox
            // 
            this.postortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressBindingSource, "Postort", true));
            this.postortTextBox.Location = new System.Drawing.Point(98, 182);
            this.postortTextBox.Name = "postortTextBox";
            this.postortTextBox.Size = new System.Drawing.Size(177, 20);
            this.postortTextBox.TabIndex = 9;
            // 
            // epostBindingSource
            // 
            this.epostBindingSource.DataSource = typeof(UppgraderingAdressBok.Model.Epost);
            // 
            // epostaddressTextBox
            // 
            this.epostaddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.epostBindingSource, "Epostaddress", true));
            this.epostaddressTextBox.Location = new System.Drawing.Point(98, 298);
            this.epostaddressTextBox.Name = "epostaddressTextBox";
            this.epostaddressTextBox.Size = new System.Drawing.Size(177, 20);
            this.epostaddressTextBox.TabIndex = 11;
            // 
            // telefonBindingSource
            // 
            this.telefonBindingSource.DataSource = typeof(UppgraderingAdressBok.Model.Telefon);
            // 
            // riktnummerTextBox
            // 
            this.riktnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonBindingSource, "Riktnummer", true));
            this.riktnummerTextBox.Location = new System.Drawing.Point(98, 217);
            this.riktnummerTextBox.Name = "riktnummerTextBox";
            this.riktnummerTextBox.Size = new System.Drawing.Size(177, 20);
            this.riktnummerTextBox.TabIndex = 13;
            // 
            // telefonnummerTextBox
            // 
            this.telefonnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonBindingSource, "Telefonnummer", true));
            this.telefonnummerTextBox.Location = new System.Drawing.Point(98, 257);
            this.telefonnummerTextBox.Name = "telefonnummerTextBox";
            this.telefonnummerTextBox.Size = new System.Drawing.Size(177, 20);
            this.telefonnummerTextBox.TabIndex = 15;
            // 
            // kontakttypBindingSource
            // 
            this.kontakttypBindingSource.DataSource = typeof(UppgraderingAdressBok.Model.Kontakttyp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "1) Personlig kontakt   2) Företags kontakt   3) Övrig kontakt";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 369);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Lägg till ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistreraNy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(telefonnummerLabel);
            this.Controls.Add(this.telefonnummerTextBox);
            this.Controls.Add(riktnummerLabel);
            this.Controls.Add(this.riktnummerTextBox);
            this.Controls.Add(epostaddressLabel);
            this.Controls.Add(this.epostaddressTextBox);
            this.Controls.Add(postortLabel);
            this.Controls.Add(this.postortTextBox);
            this.Controls.Add(postnummerLabel);
            this.Controls.Add(this.postnummerTextBox);
            this.Controls.Add(gatunamnLabel);
            this.Controls.Add(this.gatunamnTextBox);
            this.Controls.Add(efternamnLabel);
            this.Controls.Add(this.efternamnTextBox);
            this.Controls.Add(förnamnLabel);
            this.Controls.Add(this.förnamnTextBox);
            this.Name = "RegistreraNy";
            this.Text = "RegistreraNy";
            this.Load += new System.EventHandler(this.RegistreraNy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontakttypBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox efternamnTextBox;
        private System.Windows.Forms.TextBox förnamnTextBox;
        private System.Windows.Forms.BindingSource adressBindingSource;
        private System.Windows.Forms.TextBox gatunamnTextBox;
        private System.Windows.Forms.TextBox postnummerTextBox;
        private System.Windows.Forms.TextBox postortTextBox;
        private System.Windows.Forms.BindingSource epostBindingSource;
        private System.Windows.Forms.TextBox epostaddressTextBox;
        private System.Windows.Forms.BindingSource telefonBindingSource;
        private System.Windows.Forms.TextBox riktnummerTextBox;
        private System.Windows.Forms.TextBox telefonnummerTextBox;
        private System.Windows.Forms.BindingSource kontakttypBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}