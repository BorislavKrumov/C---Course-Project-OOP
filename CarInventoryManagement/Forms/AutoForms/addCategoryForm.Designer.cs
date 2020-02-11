namespace CarInventoryManagement
{
    partial class addCategoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.categorytxtBox = new System.Windows.Forms.TextBox();
            this.addCategory = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.errorNameCategory = new System.Windows.Forms.Label();
            this.deletecategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име на категорията ";
            // 
            // categorytxtBox
            // 
            this.categorytxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categorytxtBox.Location = new System.Drawing.Point(12, 47);
            this.categorytxtBox.Name = "categorytxtBox";
            this.categorytxtBox.Size = new System.Drawing.Size(211, 26);
            this.categorytxtBox.TabIndex = 1;
            // 
            // addCategory
            // 
            this.addCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.addCategory.FlatAppearance.BorderSize = 0;
            this.addCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.addCategory.Location = new System.Drawing.Point(202, 115);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(89, 40);
            this.addCategory.TabIndex = 3;
            this.addCategory.Text = "Добави";
            this.addCategory.UseVisualStyleBackColor = false;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.cancel.Location = new System.Drawing.Point(12, 115);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(89, 40);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Отказ";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // errorNameCategory
            // 
            this.errorNameCategory.AutoSize = true;
            this.errorNameCategory.ForeColor = System.Drawing.Color.DarkRed;
            this.errorNameCategory.Location = new System.Drawing.Point(50, 87);
            this.errorNameCategory.Name = "errorNameCategory";
            this.errorNameCategory.Size = new System.Drawing.Size(0, 13);
            this.errorNameCategory.TabIndex = 7;
            // 
            // deletecategory
            // 
            this.deletecategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.deletecategory.FlatAppearance.BorderSize = 0;
            this.deletecategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletecategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletecategory.ForeColor = System.Drawing.SystemColors.Control;
            this.deletecategory.Location = new System.Drawing.Point(107, 115);
            this.deletecategory.Name = "deletecategory";
            this.deletecategory.Size = new System.Drawing.Size(89, 40);
            this.deletecategory.TabIndex = 8;
            this.deletecategory.Text = "Изтрий";
            this.deletecategory.UseVisualStyleBackColor = false;
            this.deletecategory.Click += new System.EventHandler(this.button1_Click);
            // 
            // addCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 189);
            this.Controls.Add(this.deletecategory);
            this.Controls.Add(this.errorNameCategory);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.categorytxtBox);
            this.Controls.Add(this.label1);
            this.Name = "addCategoryForm";
            this.Text = "Категория";
            this.Load += new System.EventHandler(this.addCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categorytxtBox;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label errorNameCategory;
        private System.Windows.Forms.Button deletecategory;
    }
}