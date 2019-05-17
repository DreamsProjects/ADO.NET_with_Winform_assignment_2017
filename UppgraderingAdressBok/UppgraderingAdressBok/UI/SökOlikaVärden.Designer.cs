namespace UppgraderingAdressBok.UI
{
    partial class SökOlikaVärden
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ContactTypeCheckbox = new System.Windows.Forms.CheckBox();
            this.MailingAddressCheckbox = new System.Windows.Forms.CheckBox();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.addressDisplayGrid = new System.Windows.Forms.DataGridView();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressDisplayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ContactTypeCheckbox);
            this.groupBox1.Controls.Add(this.MailingAddressCheckbox);
            this.groupBox1.Controls.Add(this.NameCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 219);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(278, 71);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök";
            // 
            // ContactTypeCheckbox
            // 
            this.ContactTypeCheckbox.AutoSize = true;
            this.ContactTypeCheckbox.Location = new System.Drawing.Point(154, 33);
            this.ContactTypeCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.ContactTypeCheckbox.Name = "ContactTypeCheckbox";
            this.ContactTypeCheckbox.Size = new System.Drawing.Size(98, 21);
            this.ContactTypeCheckbox.TabIndex = 2;
            this.ContactTypeCheckbox.Text = "Kontakt typ";
            this.ContactTypeCheckbox.UseVisualStyleBackColor = true;
            // 
            // MailingAddressCheckbox
            // 
            this.MailingAddressCheckbox.AutoSize = true;
            this.MailingAddressCheckbox.Location = new System.Drawing.Point(79, 33);
            this.MailingAddressCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.MailingAddressCheckbox.Name = "MailingAddressCheckbox";
            this.MailingAddressCheckbox.Size = new System.Drawing.Size(72, 21);
            this.MailingAddressCheckbox.TabIndex = 1;
            this.MailingAddressCheckbox.Text = "Postort";
            this.MailingAddressCheckbox.UseVisualStyleBackColor = true;
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Location = new System.Drawing.Point(8, 33);
            this.NameCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(64, 21);
            this.NameCheckBox.TabIndex = 0;
            this.NameCheckBox.Text = "Namn";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // addressDisplayGrid
            // 
            this.addressDisplayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressDisplayGrid.Location = new System.Drawing.Point(11, 11);
            this.addressDisplayGrid.Margin = new System.Windows.Forms.Padding(2);
            this.addressDisplayGrid.Name = "addressDisplayGrid";
            this.addressDisplayGrid.RowTemplate.Height = 24;
            this.addressDisplayGrid.Size = new System.Drawing.Size(360, 191);
            this.addressDisplayGrid.TabIndex = 19;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(57, 308);
            this.SearchTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(231, 20);
            this.SearchTextbox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Text:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(302, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Sök";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SökOlikaVärden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 346);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addressDisplayGrid);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "SökOlikaVärden";
            this.Text = "SökOlikaVärden";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressDisplayGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ContactTypeCheckbox;
        private System.Windows.Forms.CheckBox MailingAddressCheckbox;
        private System.Windows.Forms.CheckBox NameCheckBox;
        private System.Windows.Forms.DataGridView addressDisplayGrid;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}