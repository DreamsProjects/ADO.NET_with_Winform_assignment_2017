namespace UppgraderingAdressBok.UI
{
    partial class LäggTillAdress
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
            System.Windows.Forms.Label personIDLabel;
            System.Windows.Forms.Label gatunamnLabel;
            System.Windows.Forms.Label postnummerLabel;
            System.Windows.Forms.Label postortLabel;
            this.personIDTextBox = new System.Windows.Forms.TextBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gatunamnTextBox = new System.Windows.Forms.TextBox();
            this.postnummerTextBox = new System.Windows.Forms.TextBox();
            this.postortTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            personIDLabel = new System.Windows.Forms.Label();
            gatunamnLabel = new System.Windows.Forms.Label();
            postnummerLabel = new System.Windows.Forms.Label();
            postortLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personIDLabel
            // 
            personIDLabel.AutoSize = true;
            personIDLabel.Location = new System.Drawing.Point(21, 31);
            personIDLabel.Name = "personIDLabel";
            personIDLabel.Size = new System.Drawing.Size(57, 13);
            personIDLabel.TabIndex = 1;
            personIDLabel.Text = "Person ID:";
            // 
            // gatunamnLabel
            // 
            gatunamnLabel.AutoSize = true;
            gatunamnLabel.Location = new System.Drawing.Point(19, 84);
            gatunamnLabel.Name = "gatunamnLabel";
            gatunamnLabel.Size = new System.Drawing.Size(59, 13);
            gatunamnLabel.TabIndex = 2;
            gatunamnLabel.Text = "Gatunamn:";
            // 
            // postnummerLabel
            // 
            postnummerLabel.AutoSize = true;
            postnummerLabel.Location = new System.Drawing.Point(10, 119);
            postnummerLabel.Name = "postnummerLabel";
            postnummerLabel.Size = new System.Drawing.Size(68, 13);
            postnummerLabel.TabIndex = 4;
            postnummerLabel.Text = "Postnummer:";
            // 
            // postortLabel
            // 
            postortLabel.AutoSize = true;
            postortLabel.Location = new System.Drawing.Point(35, 160);
            postortLabel.Name = "postortLabel";
            postortLabel.Size = new System.Drawing.Size(43, 13);
            postortLabel.TabIndex = 6;
            postortLabel.Text = "Postort:";
            // 
            // personIDTextBox
            // 
            this.personIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "PersonID", true));
            this.personIDTextBox.Location = new System.Drawing.Point(84, 28);
            this.personIDTextBox.Name = "personIDTextBox";
            this.personIDTextBox.Size = new System.Drawing.Size(84, 20);
            this.personIDTextBox.TabIndex = 2;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(UppgraderingAdressBok.Model.Person);
            // 
            // adressBindingSource
            // 
            this.adressBindingSource.DataSource = typeof(UppgraderingAdressBok.Model.Adress);
            // 
            // gatunamnTextBox
            // 
            this.gatunamnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressBindingSource, "Gatunamn", true));
            this.gatunamnTextBox.Location = new System.Drawing.Point(84, 81);
            this.gatunamnTextBox.Name = "gatunamnTextBox";
            this.gatunamnTextBox.Size = new System.Drawing.Size(221, 20);
            this.gatunamnTextBox.TabIndex = 3;
            // 
            // postnummerTextBox
            // 
            this.postnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressBindingSource, "Postnummer", true));
            this.postnummerTextBox.Location = new System.Drawing.Point(84, 116);
            this.postnummerTextBox.Name = "postnummerTextBox";
            this.postnummerTextBox.Size = new System.Drawing.Size(84, 20);
            this.postnummerTextBox.TabIndex = 5;
            // 
            // postortTextBox
            // 
            this.postortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressBindingSource, "Postort", true));
            this.postortTextBox.Location = new System.Drawing.Point(84, 157);
            this.postortTextBox.Name = "postortTextBox";
            this.postortTextBox.Size = new System.Drawing.Size(221, 20);
            this.postortTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lägg till adress";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LäggTillAdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 247);
            this.Controls.Add(this.button1);
            this.Controls.Add(postortLabel);
            this.Controls.Add(this.postortTextBox);
            this.Controls.Add(postnummerLabel);
            this.Controls.Add(this.postnummerTextBox);
            this.Controls.Add(gatunamnLabel);
            this.Controls.Add(this.gatunamnTextBox);
            this.Controls.Add(personIDLabel);
            this.Controls.Add(this.personIDTextBox);
            this.Name = "LäggTillAdress";
            this.Text = "LäggTillAdress";
            this.Load += new System.EventHandler(this.LäggTillAdress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox personIDTextBox;
        private System.Windows.Forms.BindingSource adressBindingSource;
        private System.Windows.Forms.TextBox gatunamnTextBox;
        private System.Windows.Forms.TextBox postnummerTextBox;
        private System.Windows.Forms.TextBox postortTextBox;
        private System.Windows.Forms.Button button1;
    }
}