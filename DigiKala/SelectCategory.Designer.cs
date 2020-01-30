namespace DigiKala
{
    partial class SelectCategory
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
            this.ParentCategory = new System.Windows.Forms.DataGridView();
            this.btnSelectCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ParentCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // ParentCategory
            // 
            this.ParentCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParentCategory.Location = new System.Drawing.Point(3, 3);
            this.ParentCategory.Name = "ParentCategory";
            this.ParentCategory.RowHeadersWidth = 51;
            this.ParentCategory.RowTemplate.Height = 24;
            this.ParentCategory.Size = new System.Drawing.Size(788, 150);
            this.ParentCategory.TabIndex = 0;
            // 
            // btnSelectCategory
            // 
            this.btnSelectCategory.Location = new System.Drawing.Point(713, 160);
            this.btnSelectCategory.Name = "btnSelectCategory";
            this.btnSelectCategory.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCategory.TabIndex = 1;
            this.btnSelectCategory.Text = "Select";
            this.btnSelectCategory.UseVisualStyleBackColor = true;
            this.btnSelectCategory.Click += new System.EventHandler(this.btnSelectCategory_Click);
            // 
            // SelectCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelectCategory);
            this.Controls.Add(this.ParentCategory);
            this.Name = "SelectCategory";
            this.Text = "SelectCategory";
            this.Load += new System.EventHandler(this.SelectCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ParentCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectCategory;
        public System.Windows.Forms.DataGridView ParentCategory;
    }
}