namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            txtCarID = new TextBox();
            lbCarName = new Label();
            txtCarName = new TextBox();
            lbManufacturer = new Label();
            txtManufacturer = new TextBox();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(40, 47);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 1;
            lbCarID.Text = "Car ID";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(152, 44);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(267, 27);
            txtCarID.TabIndex = 6;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(40, 96);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 7;
            lbCarName.Text = "Car Name";
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(152, 93);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(267, 27);
            txtCarName.TabIndex = 8;
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(40, 145);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 9;
            lbManufacturer.Text = "Manufacturer";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(152, 142);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(267, 27);
            txtManufacturer.TabIndex = 10;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(489, 47);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 11;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(489, 96);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(88, 20);
            lbReleaseYear.TabIndex = 12;
            lbReleaseYear.Text = "ReleaseYear";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(582, 44);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(267, 27);
            txtPrice.TabIndex = 13;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(582, 93);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(267, 27);
            txtReleaseYear.TabIndex = 14;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(152, 189);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 15;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(373, 189);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 16;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(596, 189);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(40, 224);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(809, 188);
            dgvCarList.TabIndex = 18;
            dgvCarList.CellContentClick += dgvCarList_CellContentClick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(373, 418);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 19;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 466);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(lbManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(lbCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private TextBox txtCarID;
        private Label lbCarName;
        private TextBox txtCarName;
        private Label lbManufacturer;
        private TextBox txtManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}