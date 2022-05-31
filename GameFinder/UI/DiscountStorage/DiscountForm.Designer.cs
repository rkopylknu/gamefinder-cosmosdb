namespace GameFinder.UI.DiscountStorage
{
    partial class DiscountForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteDiscount = new System.Windows.Forms.Button();
            this.dgvDiscounts = new System.Windows.Forms.DataGridView();
            this.btnCreateDiscount = new System.Windows.Forms.Button();
            this.btnGoToSearch = new System.Windows.Forms.Button();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.btnDecreaseGameCount = new System.Windows.Forms.Button();
            this.btnIncreaseGameCount = new System.Windows.Forms.Button();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(45, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 7);
            this.groupBox1.Size = new System.Drawing.Size(964, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discounts";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteDiscount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvDiscounts, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateDiscount, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 220);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDeleteDiscount
            // 
            this.btnDeleteDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteDiscount.Location = new System.Drawing.Point(478, 167);
            this.btnDeleteDiscount.Name = "btnDeleteDiscount";
            this.btnDeleteDiscount.Size = new System.Drawing.Size(469, 50);
            this.btnDeleteDiscount.TabIndex = 2;
            this.btnDeleteDiscount.Text = "Delete";
            this.btnDeleteDiscount.UseVisualStyleBackColor = true;
            this.btnDeleteDiscount.Click += new System.EventHandler(this.btnDeleteDiscount_Click);
            // 
            // dgvDiscounts
            // 
            this.dgvDiscounts.AllowUserToAddRows = false;
            this.dgvDiscounts.AllowUserToDeleteRows = false;
            this.dgvDiscounts.AllowUserToResizeColumns = false;
            this.dgvDiscounts.AllowUserToResizeRows = false;
            this.dgvDiscounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiscounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiscounts.ColumnHeadersHeight = 30;
            this.dgvDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDiscounts, 2);
            this.dgvDiscounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiscounts.Location = new System.Drawing.Point(3, 3);
            this.dgvDiscounts.MultiSelect = false;
            this.dgvDiscounts.Name = "dgvDiscounts";
            this.dgvDiscounts.ReadOnly = true;
            this.dgvDiscounts.RowHeadersVisible = false;
            this.dgvDiscounts.RowHeadersWidth = 5;
            this.dgvDiscounts.RowTemplate.Height = 40;
            this.dgvDiscounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscounts.Size = new System.Drawing.Size(944, 158);
            this.dgvDiscounts.TabIndex = 0;
            // 
            // btnCreateDiscount
            // 
            this.btnCreateDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateDiscount.Location = new System.Drawing.Point(3, 167);
            this.btnCreateDiscount.Name = "btnCreateDiscount";
            this.btnCreateDiscount.Size = new System.Drawing.Size(469, 50);
            this.btnCreateDiscount.TabIndex = 1;
            this.btnCreateDiscount.Text = "Create";
            this.btnCreateDiscount.UseVisualStyleBackColor = true;
            this.btnCreateDiscount.Click += new System.EventHandler(this.btnCreateDiscount_Click);
            // 
            // btnGoToSearch
            // 
            this.btnGoToSearch.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGoToSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToSearch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoToSearch.Location = new System.Drawing.Point(45, 585);
            this.btnGoToSearch.Name = "btnGoToSearch";
            this.btnGoToSearch.Size = new System.Drawing.Size(170, 51);
            this.btnGoToSearch.TabIndex = 9;
            this.btnGoToSearch.Text = "Search";
            this.btnGoToSearch.UseVisualStyleBackColor = false;
            this.btnGoToSearch.Click += new System.EventHandler(this.btnGoToSearch_Click);
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateGame.Location = new System.Drawing.Point(542, 585);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(225, 51);
            this.btnCreateGame.TabIndex = 10;
            this.btnCreateGame.Text = "Create";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteGame.Location = new System.Drawing.Point(773, 585);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(229, 51);
            this.btnDeleteGame.TabIndex = 11;
            this.btnDeleteGame.Text = "Delete";
            this.btnDeleteGame.UseVisualStyleBackColor = true;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // btnDecreaseGameCount
            // 
            this.btnDecreaseGameCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecreaseGameCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecreaseGameCount.Location = new System.Drawing.Point(483, 585);
            this.btnDecreaseGameCount.Name = "btnDecreaseGameCount";
            this.btnDecreaseGameCount.Size = new System.Drawing.Size(53, 51);
            this.btnDecreaseGameCount.TabIndex = 12;
            this.btnDecreaseGameCount.Text = "-";
            this.btnDecreaseGameCount.UseVisualStyleBackColor = true;
            this.btnDecreaseGameCount.Click += new System.EventHandler(this.btnDecreaseGameCount_Click);
            // 
            // btnIncreaseGameCount
            // 
            this.btnIncreaseGameCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncreaseGameCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIncreaseGameCount.Location = new System.Drawing.Point(424, 585);
            this.btnIncreaseGameCount.Name = "btnIncreaseGameCount";
            this.btnIncreaseGameCount.Size = new System.Drawing.Size(53, 51);
            this.btnIncreaseGameCount.TabIndex = 13;
            this.btnIncreaseGameCount.Text = "+";
            this.btnIncreaseGameCount.UseVisualStyleBackColor = true;
            this.btnIncreaseGameCount.Click += new System.EventHandler(this.btnIncreaseGameCount_Click);
            // 
            // dgvGames
            // 
            this.dgvGames.AllowUserToAddRows = false;
            this.dgvGames.AllowUserToDeleteRows = false;
            this.dgvGames.AllowUserToResizeColumns = false;
            this.dgvGames.AllowUserToResizeRows = false;
            this.dgvGames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGames.BackgroundColor = System.Drawing.Color.White;
            this.dgvGames.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGames.ColumnHeadersHeight = 30;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGames.Location = new System.Drawing.Point(7, 22);
            this.dgvGames.MultiSelect = false;
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.ReadOnly = true;
            this.dgvGames.RowHeadersVisible = false;
            this.dgvGames.RowHeadersWidth = 5;
            this.dgvGames.RowTemplate.Height = 40;
            this.dgvGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGames.Size = new System.Drawing.Size(950, 246);
            this.dgvGames.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvGames);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(45, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7, 5, 7, 7);
            this.groupBox3.Size = new System.Drawing.Size(964, 275);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Games";
            // 
            // DiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 669);
            this.Controls.Add(this.btnIncreaseGameCount);
            this.Controls.Add(this.btnDecreaseGameCount);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.btnGoToSearch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discount Storage";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDiscounts;
        private System.Windows.Forms.Button btnDeleteDiscount;
        private System.Windows.Forms.Button btnCreateDiscount;
        private System.Windows.Forms.Button btnGoToSearch;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Button btnDeleteGame;
        private System.Windows.Forms.Button btnDecreaseGameCount;
        private System.Windows.Forms.Button btnIncreaseGameCount;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}