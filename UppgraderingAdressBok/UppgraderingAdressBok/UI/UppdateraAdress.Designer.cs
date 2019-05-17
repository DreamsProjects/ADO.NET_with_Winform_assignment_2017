namespace UppgraderingAdressBok.UI
{
    partial class UppdateraAdress
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
            System.Windows.Forms.Label postnummerLabel;
            System.Windows.Forms.Label gatunamnLabel;
            System.Windows.Forms.Label postortLabel;
            System.Windows.Forms.Label iDLabel;
            this.adressDataGridView = new System.Windows.Forms.DataGridView();
            this.adressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postnummerTextBox = new System.Windows.Forms.TextBox();
            this.gatunamnTextBox = new System.Windows.Forms.TextBox();
            this.postortTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personIDTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            postnummerLabel = new System.Windows.Forms.Label();
            gatunamnLabel = new System.Windows.Forms.Label();
            postortLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adressDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adressDataGridView
            // 
            this.adressDataGridView.AutoGenerateColumns = false;
            this.adressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.adressDataGridView.DataSource = this.adressBindingSource;
            this.adressDataGridView.Location = new System.Drawing.Point(12, 12);
            this.adressDataGridView.Name = "adressDataGridView";
            this.adressDataGridView.Size = new System.Drawing.Size(518, 185);
            this.adressDataGridView.TabIndex = 1;
            // 
            // adressBindingSource
            // 
            this.adressBindingSource.DataSource = typeof(UppgraderingAdressBok.Model.Adress);
            // 
            // postnummerLabel
            // 
            postnummerLabel.AutoSize = true;
            postnummerLabel.Location = new System.Drawing.Point(57, 355);
            postnummerLabel.Name = "postnummerLabel";
            postnummerLabel.Size = new System.Drawing.Size(68, 13);
            postnummerLabel.TabIndex = 1;
            postnummerLabel.Text = "Postnummer:";
            // 
            // postnummerTextBox
            // 
            this.postnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressBindingSource, "Postnummer", true));
            this.postnummerTextBox.Location = new System.Drawing.Point(131, 352);
            this.postnummerTextBox.Name = "postnummerTextBox";
            this.postnummerTextBox.Size = new System.Drawing.Size(207, 20);
            this.postnummerTextBox.TabIndex = 2;
            // 
            // gatunamnLabel
            // 
            gatunamnLabel.AutoSize = true;
            gatunamnLabel.Location = new System.Drawing.Point(66, 317);
            gatunamnLabel.Name = "gatunamnLabel";
            gatunamnLabel.Size = new System.Drawing.Size(59, 13);
            gatunamnLabel.TabIndex = 3;
            gatunamnLabel.Text = "Gatunamn:";
            // 
            // gatunamnTextBox
            // 
            this.gatunamnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressBindingSource, "Gatunamn", true));
            this.gatunamnTextBox.Location = new System.Drawing.Point(131, 314);
            this.gatunamnTextBox.Name = "gatunamnTextBox";
            this.gatunamnTextBox.Size = new System.Drawing.Size(207, 20);
            this.gatunamnTextBox.TabIndex = 4;
            // 
            // postortLabel
            // 
            postortLabel.AutoSize = true;
            postortLabel.Location = new System.Drawing.Point(82, 391);
            postortLabel.Name = "postortLabel";
            postortLabel.Size = new System.Drawing.Size(43, 13);
            postortLabel.TabIndex = 5;
            postortLabel.Text = "Postort:";
            // 
            // postortTextBox
            // 
            this.postortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressBindingSource, "Postort", true));
            this.postortTextBox.Location = new System.Drawing.Point(131, 388);
            this.postortTextBox.Name = "postortTextBox";
            this.postortTextBox.Size = new System.Drawing.Size(207, 20);
            this.postortTextBox.TabIndex = 6;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(12, 218);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(113, 13);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "Sök efter adress på id:";
            iDLabel.Click += new System.EventHandler(this.iDLabel_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(131, 270);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(52, 20);
            this.iDTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sök";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(UppgraderingAdressBok.Model.Person);
            // 
            // personIDTextBox
            // 
            this.personIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "PersonID", true));
            this.personIDTextBox.Location = new System.Drawing.Point(131, 211);
            this.personIDTextBox.Name = "personIDTextBox";
            this.personIDTextBox.Size = new System.Drawing.Size(73, 20);
            this.personIDTextBox.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Gatunamn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Gatunamn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Postnummer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Postnummer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Postort";
            this.dataGridViewTextBoxColumn4.HeaderText = "Postort";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // UppdateraAdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 441);
            this.Controls.Add(this.personIDTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(postortLabel);
            this.Controls.Add(this.postortTextBox);
            this.Controls.Add(gatunamnLabel);
            this.Controls.Add(this.gatunamnTextBox);
            this.Controls.Add(postnummerLabel);
            this.Controls.Add(this.postnummerTextBox);
            this.Controls.Add(this.adressDataGridView);
            this.Name = "UppdateraAdress";
            this.Text = "UppdateraAdress";
            ((System.ComponentModel.ISupportInitialize)(this.adressDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource adressBindingSource;
        private System.Windows.Forms.DataGridView adressDataGridView;
        private System.Windows.Forms.TextBox postnummerTextBox;
        private System.Windows.Forms.TextBox gatunamnTextBox;
        private System.Windows.Forms.TextBox postortTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox personIDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}