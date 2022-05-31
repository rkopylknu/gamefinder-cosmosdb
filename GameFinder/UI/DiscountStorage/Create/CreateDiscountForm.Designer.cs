namespace GameFinder.UI.DiscountStorage.Create
{
    partial class CreateDiscountForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFindGame = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbGameStore = new System.Windows.Forms.GroupBox();
            this.tbGameStore = new System.Windows.Forms.TextBox();
            this.gbGameName = new System.Windows.Forms.GroupBox();
            this.tbGameName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbGameManfucturer = new System.Windows.Forms.GroupBox();
            this.tbGameManufacturer = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbNewPrice = new System.Windows.Forms.GroupBox();
            this.tbNewPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRegularPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbGameStore.SuspendLayout();
            this.gbGameName.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbGameManfucturer.SuspendLayout();
            this.gbNewPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnFindGame, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbGameName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 244);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnFindGame
            // 
            this.btnFindGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFindGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindGame.Location = new System.Drawing.Point(3, 186);
            this.btnFindGame.Name = "btnFindGame";
            this.btnFindGame.Size = new System.Drawing.Size(412, 55);
            this.btnFindGame.TabIndex = 3;
            this.btnFindGame.Text = "Find Game";
            this.btnFindGame.UseVisualStyleBackColor = true;
            this.btnFindGame.Click += new System.EventHandler(this.btnFindGame_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbGameStore);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 55);
            this.panel2.TabIndex = 2;
            // 
            // gbGameStore
            // 
            this.gbGameStore.Controls.Add(this.tbGameStore);
            this.gbGameStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGameStore.ForeColor = System.Drawing.Color.Black;
            this.gbGameStore.Location = new System.Drawing.Point(0, 0);
            this.gbGameStore.Name = "gbGameStore";
            this.gbGameStore.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.gbGameStore.Size = new System.Drawing.Size(412, 55);
            this.gbGameStore.TabIndex = 1;
            this.gbGameStore.TabStop = false;
            this.gbGameStore.Text = "Game Store";
            // 
            // tbGameStore
            // 
            this.tbGameStore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbGameStore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGameStore.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGameStore.Location = new System.Drawing.Point(15, 23);
            this.tbGameStore.Name = "tbGameStore";
            this.tbGameStore.Size = new System.Drawing.Size(382, 21);
            this.tbGameStore.TabIndex = 0;
            // 
            // gbGameName
            // 
            this.gbGameName.Controls.Add(this.tbGameName);
            this.gbGameName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGameName.ForeColor = System.Drawing.Color.Black;
            this.gbGameName.Location = new System.Drawing.Point(3, 3);
            this.gbGameName.Name = "gbGameName";
            this.gbGameName.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.gbGameName.Size = new System.Drawing.Size(412, 55);
            this.gbGameName.TabIndex = 0;
            this.gbGameName.TabStop = false;
            this.gbGameName.Text = "Game Name";
            // 
            // tbGameName
            // 
            this.tbGameName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbGameName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGameName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGameName.Location = new System.Drawing.Point(15, 23);
            this.tbGameName.Name = "tbGameName";
            this.tbGameName.Size = new System.Drawing.Size(382, 21);
            this.tbGameName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbGameManfucturer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 55);
            this.panel1.TabIndex = 1;
            // 
            // gbGameManfucturer
            // 
            this.gbGameManfucturer.Controls.Add(this.tbGameManufacturer);
            this.gbGameManfucturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGameManfucturer.ForeColor = System.Drawing.Color.Black;
            this.gbGameManfucturer.Location = new System.Drawing.Point(0, 0);
            this.gbGameManfucturer.Name = "gbGameManfucturer";
            this.gbGameManfucturer.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.gbGameManfucturer.Size = new System.Drawing.Size(412, 55);
            this.gbGameManfucturer.TabIndex = 1;
            this.gbGameManfucturer.TabStop = false;
            this.gbGameManfucturer.Text = "Game Manufacturer";
            // 
            // tbGameManufacturer
            // 
            this.tbGameManufacturer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbGameManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGameManufacturer.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGameManufacturer.Location = new System.Drawing.Point(15, 23);
            this.tbGameManufacturer.Name = "tbGameManufacturer";
            this.tbGameManufacturer.Size = new System.Drawing.Size(382, 21);
            this.tbGameManufacturer.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Enabled = false;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(244, 427);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(199, 48);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gbNewPrice
            // 
            this.gbNewPrice.Controls.Add(this.tbNewPrice);
            this.gbNewPrice.Enabled = false;
            this.gbNewPrice.Location = new System.Drawing.Point(28, 343);
            this.gbNewPrice.Name = "gbNewPrice";
            this.gbNewPrice.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.gbNewPrice.Size = new System.Drawing.Size(412, 55);
            this.gbNewPrice.TabIndex = 7;
            this.gbNewPrice.TabStop = false;
            this.gbNewPrice.Text = "New Price";
            // 
            // tbNewPrice
            // 
            this.tbNewPrice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbNewPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewPrice.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewPrice.Location = new System.Drawing.Point(15, 23);
            this.tbNewPrice.Name = "tbNewPrice";
            this.tbNewPrice.Size = new System.Drawing.Size(382, 21);
            this.tbNewPrice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Regular Price:";
            // 
            // lbRegularPrice
            // 
            this.lbRegularPrice.AutoSize = true;
            this.lbRegularPrice.Location = new System.Drawing.Point(129, 311);
            this.lbRegularPrice.Name = "lbRegularPrice";
            this.lbRegularPrice.Size = new System.Drawing.Size(0, 17);
            this.lbRegularPrice.TabIndex = 9;
            // 
            // CreateDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 489);
            this.Controls.Add(this.lbRegularPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbNewPrice);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreateDiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Discount";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbGameStore.ResumeLayout(false);
            this.gbGameStore.PerformLayout();
            this.gbGameName.ResumeLayout(false);
            this.gbGameName.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbGameManfucturer.ResumeLayout(false);
            this.gbGameManfucturer.PerformLayout();
            this.gbNewPrice.ResumeLayout(false);
            this.gbNewPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbGameName;
        private System.Windows.Forms.TextBox tbGameName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbGameStore;
        private System.Windows.Forms.TextBox tbGameStore;
        private System.Windows.Forms.GroupBox gbGameManfucturer;
        private System.Windows.Forms.TextBox tbGameManufacturer;
        private System.Windows.Forms.GroupBox gbNewPrice;
        private System.Windows.Forms.TextBox tbNewPrice;
        private System.Windows.Forms.Button btnFindGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRegularPrice;
    }
}