namespace CarInventoryManagement.Forms.Accessories
{
    partial class accessoriesAddForm
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryTxtBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityUD = new System.Windows.Forms.NumericUpDown();
            this.priceUD = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandTxtBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modelTxtBox = new System.Windows.Forms.TextBox();
            this.vendorTxtBox = new System.Windows.Forms.TextBox();
            this.pathPic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUD)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackgroundImage = global::CarInventoryManagement.Properties.Resources.img_234957;
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox.Location = new System.Drawing.Point(3, 3);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(233, 233);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(242, 3);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(47, 24);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Име";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTxtBox.Location = new System.Drawing.Point(302, 0);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(225, 27);
            this.nameTxtBox.TabIndex = 2;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryLabel.Location = new System.Drawing.Point(242, 30);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(105, 24);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Категория";
            // 
            // categoryTxtBox
            // 
            this.categoryTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryTxtBox.Location = new System.Drawing.Point(353, 33);
            this.categoryTxtBox.Name = "categoryTxtBox";
            this.categoryTxtBox.Size = new System.Drawing.Size(225, 27);
            this.categoryTxtBox.TabIndex = 4;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(242, 63);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantityLabel.Size = new System.Drawing.Size(117, 24);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Количество";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityUD
            // 
            this.quantityUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityUD.Location = new System.Drawing.Point(365, 66);
            this.quantityUD.Name = "quantityUD";
            this.quantityUD.Size = new System.Drawing.Size(120, 27);
            this.quantityUD.TabIndex = 6;
            // 
            // priceUD
            // 
            this.priceUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceUD.Location = new System.Drawing.Point(314, 97);
            this.priceUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceUD.Name = "priceUD";
            this.priceUD.Size = new System.Drawing.Size(120, 27);
            this.priceUD.TabIndex = 7;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(242, 97);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceLabel.Size = new System.Drawing.Size(54, 24);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Цена";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandLabel.Location = new System.Drawing.Point(242, 136);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brandLabel.Size = new System.Drawing.Size(66, 24);
            this.brandLabel.TabIndex = 9;
            this.brandLabel.Text = "Марка";
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandTxtBox
            // 
            this.brandTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandTxtBox.Location = new System.Drawing.Point(314, 133);
            this.brandTxtBox.Name = "brandTxtBox";
            this.brandTxtBox.Size = new System.Drawing.Size(225, 27);
            this.brandTxtBox.TabIndex = 10;
            this.brandTxtBox.TextChanged += new System.EventHandler(this.brandTxtBox_TextChanged);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelLabel.Location = new System.Drawing.Point(242, 173);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.modelLabel.Size = new System.Drawing.Size(70, 24);
            this.modelLabel.TabIndex = 11;
            this.modelLabel.Text = "Модел";
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modelLabel.Click += new System.EventHandler(this.modelLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(242, 212);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Вносител";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modelTxtBox
            // 
            this.modelTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelTxtBox.Location = new System.Drawing.Point(318, 173);
            this.modelTxtBox.Name = "modelTxtBox";
            this.modelTxtBox.Size = new System.Drawing.Size(225, 27);
            this.modelTxtBox.TabIndex = 13;
            // 
            // vendorTxtBox
            // 
            this.vendorTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vendorTxtBox.Location = new System.Drawing.Point(344, 212);
            this.vendorTxtBox.Name = "vendorTxtBox";
            this.vendorTxtBox.Size = new System.Drawing.Size(225, 27);
            this.vendorTxtBox.TabIndex = 14;
            // 
            // pathPic
            // 
            this.pathPic.Location = new System.Drawing.Point(3, 242);
            this.pathPic.Name = "pathPic";
            this.pathPic.Size = new System.Drawing.Size(233, 23);
            this.pathPic.TabIndex = 15;
            this.pathPic.Text = "Избери снимка";
            this.pathPic.UseVisualStyleBackColor = true;
            this.pathPic.Click += new System.EventHandler(this.pathPic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-1, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Местоположение на файла:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(238, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(196, 27);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(440, 277);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancelBtn.Size = new System.Drawing.Size(72, 28);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Отказ";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(518, 277);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveBtn.Size = new System.Drawing.Size(105, 28);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Запази";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // accessoriesAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 313);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathPic);
            this.Controls.Add(this.vendorTxtBox);
            this.Controls.Add(this.modelTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.brandTxtBox);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceUD);
            this.Controls.Add(this.quantityUD);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.categoryTxtBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.picBox);
            this.Name = "accessoriesAddForm";
            this.Text = "accessoriesAddForm";
            this.Load += new System.EventHandler(this.accessoriesAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox categoryTxtBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityUD;
        private System.Windows.Forms.NumericUpDown priceUD;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox brandTxtBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modelTxtBox;
        private System.Windows.Forms.TextBox vendorTxtBox;
        private System.Windows.Forms.Button pathPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}