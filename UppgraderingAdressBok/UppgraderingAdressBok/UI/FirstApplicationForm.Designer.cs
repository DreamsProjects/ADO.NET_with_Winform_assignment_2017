namespace UppgraderingAdressBok.DataContext.DataControllers.Model.UI
{
    partial class FirstApplicationForm
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
            System.Windows.Forms.Label gatunamnLabel;
            this.adressDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gatunamnTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registreraNyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adresshanteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uppdateraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taBortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sökningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gatunamnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adressDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gatunamnLabel
            // 
            gatunamnLabel.AutoSize = true;
            gatunamnLabel.Location = new System.Drawing.Point(9, 305);
            gatunamnLabel.Name = "gatunamnLabel";
            gatunamnLabel.Size = new System.Drawing.Size(42, 13);
            gatunamnLabel.TabIndex = 1;
            gatunamnLabel.Text = "Adress:";
            // 
            // adressDataGridView
            // 
            this.adressDataGridView.AutoGenerateColumns = false;
            this.adressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.adressDataGridView.DataSource = this.adressBindingSource;
            this.adressDataGridView.Location = new System.Drawing.Point(12, 41);
            this.adressDataGridView.Name = "adressDataGridView";
            this.adressDataGridView.Size = new System.Drawing.Size(548, 219);
            this.adressDataGridView.TabIndex = 1;
            this.adressDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adressDataGridView_CellContentClick);
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
            // adressBindingSource
            // 
            this.adressBindingSource.DataSource = typeof(UppgraderingAdressBok.Model.Adress);
            // 
            // gatunamnTextBox
            // 
            this.gatunamnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressBindingSource, "Gatunamn", true));
            this.gatunamnTextBox.Location = new System.Drawing.Point(60, 298);
            this.gatunamnTextBox.Name = "gatunamnTextBox";
            this.gatunamnTextBox.Size = new System.Drawing.Size(325, 20);
            this.gatunamnTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sök";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registreraNyToolStripMenuItem,
            this.adresshanteringToolStripMenuItem,
            this.sökningarToolStripMenuItem,
            this.avslutaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registreraNyToolStripMenuItem
            // 
            this.registreraNyToolStripMenuItem.Name = "registreraNyToolStripMenuItem";
            this.registreraNyToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.registreraNyToolStripMenuItem.Text = "Registrera ny";
            this.registreraNyToolStripMenuItem.Click += new System.EventHandler(this.registreraNyToolStripMenuItem_Click);
            // 
            // adresshanteringToolStripMenuItem
            // 
            this.adresshanteringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.läggTillToolStripMenuItem,
            this.uppdateraToolStripMenuItem,
            this.taBortToolStripMenuItem});
            this.adresshanteringToolStripMenuItem.Name = "adresshanteringToolStripMenuItem";
            this.adresshanteringToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.adresshanteringToolStripMenuItem.Text = "Adresshantering";
            // 
            // läggTillToolStripMenuItem
            // 
            this.läggTillToolStripMenuItem.Name = "läggTillToolStripMenuItem";
            this.läggTillToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.läggTillToolStripMenuItem.Text = "Lägg till";
            this.läggTillToolStripMenuItem.Click += new System.EventHandler(this.läggTillToolStripMenuItem_Click);
            // 
            // uppdateraToolStripMenuItem
            // 
            this.uppdateraToolStripMenuItem.Name = "uppdateraToolStripMenuItem";
            this.uppdateraToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.uppdateraToolStripMenuItem.Text = "Uppdatera";
            this.uppdateraToolStripMenuItem.Click += new System.EventHandler(this.uppdateraToolStripMenuItem_Click);
            // 
            // taBortToolStripMenuItem
            // 
            this.taBortToolStripMenuItem.Name = "taBortToolStripMenuItem";
            this.taBortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.taBortToolStripMenuItem.Text = "Ta bort";
            this.taBortToolStripMenuItem.Click += new System.EventHandler(this.taBortToolStripMenuItem_Click);
            // 
            // sökningarToolStripMenuItem
            // 
            this.sökningarToolStripMenuItem.Name = "sökningarToolStripMenuItem";
            this.sökningarToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sökningarToolStripMenuItem.Text = "Sök";
            this.sökningarToolStripMenuItem.Click += new System.EventHandler(this.sökningarToolStripMenuItem_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // FirstApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(gatunamnLabel);
            this.Controls.Add(this.gatunamnTextBox);
            this.Controls.Add(this.adressDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FirstApplicationForm";
            this.Text = "FirstApplicationForm";
            this.Load += new System.EventHandler(this.FirstApplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adressDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource adressBindingSource;
        private System.Windows.Forms.DataGridView adressDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox gatunamnTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registreraNyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adresshanteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uppdateraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taBortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sökningarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
    }
}