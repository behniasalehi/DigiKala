namespace DigiKala
{
    partial class Category
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescriptions = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            this.lblerrName = new System.Windows.Forms.Label();
            this.lblerrDescriptions = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 124);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(722, 193);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descriptions : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDescriptions
            // 
            this.txtDescriptions.Location = new System.Drawing.Point(152, 85);
            this.txtDescriptions.Name = "txtDescriptions";
            this.txtDescriptions.Size = new System.Drawing.Size(100, 22);
            this.txtDescriptions.TabIndex = 5;
            this.txtDescriptions.TextChanged += new System.EventHandler(this.txtDescriptions_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(641, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(19, 144);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 17);
            this.lblmessage.TabIndex = 7;
            // 
            // lblerrName
            // 
            this.lblerrName.AutoSize = true;
            this.lblerrName.Location = new System.Drawing.Point(270, 30);
            this.lblerrName.Name = "lblerrName";
            this.lblerrName.Size = new System.Drawing.Size(0, 17);
            this.lblerrName.TabIndex = 8;
            // 
            // lblerrDescriptions
            // 
            this.lblerrDescriptions.AutoSize = true;
            this.lblerrDescriptions.Location = new System.Drawing.Point(273, 89);
            this.lblerrDescriptions.Name = "lblerrDescriptions";
            this.lblerrDescriptions.Size = new System.Drawing.Size(0, 17);
            this.lblerrDescriptions.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(544, 193);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(463, 193);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(22, 137);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(230, 33);
            this.btnSaveChanges.TabIndex = 12;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblerrDescriptions);
            this.Controls.Add(this.lblerrName);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescriptions);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescriptions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label lblerrName;
        private System.Windows.Forms.Label lblerrDescriptions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}