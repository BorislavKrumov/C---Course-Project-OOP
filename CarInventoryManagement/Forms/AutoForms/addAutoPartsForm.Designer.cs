namespace CarInventoryManagement
{
    partial class addAutoPartsForm
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
            this.pathPic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picTxtBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.categoryTxtBox = new System.Windows.Forms.TextBox();
            this.quantityNumUD = new System.Windows.Forms.NumericUpDown();
            this.priceNumUD = new System.Windows.Forms.NumericUpDown();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pathPic
            // 
            this.pathPic.Location = new System.Drawing.Point(12, 208);
            this.pathPic.Name = "pathPic";
            this.pathPic.Size = new System.Drawing.Size(188, 23);
            this.pathPic.TabIndex = 1;
            this.pathPic.Text = "Избери снимка";
            this.pathPic.UseVisualStyleBackColor = true;
            this.pathPic.Click += new System.EventHandler(this.pathPic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Местоположение на файла: ";
            // 
            // picTxtBox
            // 
            this.picTxtBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picTxtBox.Location = new System.Drawing.Point(160, 235);
            this.picTxtBox.Name = "picTxtBox";
            this.picTxtBox.Size = new System.Drawing.Size(186, 20);
            this.picTxtBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(216, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 20);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Име:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(371, 116);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(52, 20);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Цена:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryLabel.Location = new System.Drawing.Point(371, 32);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(93, 20);
            this.categoryLabel.TabIndex = 6;
            this.categoryLabel.Text = "Категория:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(216, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTxtBox.Location = new System.Drawing.Point(206, 55);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(140, 26);
            this.nameTxtBox.TabIndex = 8;
            // 
            // categoryTxtBox
            // 
            this.categoryTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryTxtBox.Location = new System.Drawing.Point(375, 55);
            this.categoryTxtBox.Name = "categoryTxtBox";
            this.categoryTxtBox.Size = new System.Drawing.Size(140, 26);
            this.categoryTxtBox.TabIndex = 9;
            // 
            // quantityNumUD
            // 
            this.quantityNumUD.Location = new System.Drawing.Point(220, 139);
            this.quantityNumUD.Name = "quantityNumUD";
            this.quantityNumUD.Size = new System.Drawing.Size(120, 20);
            this.quantityNumUD.TabIndex = 10;
            this.quantityNumUD.ValueChanged += new System.EventHandler(this.quantityNumUD_ValueChanged);
            // 
            // priceNumUD
            // 
            this.priceNumUD.Location = new System.Drawing.Point(375, 139);
            this.priceNumUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceNumUD.Name = "priceNumUD";
            this.priceNumUD.Size = new System.Drawing.Size(120, 20);
            this.priceNumUD.TabIndex = 11;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(375, 235);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Отказ";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(469, 235);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Запази";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // picBox
            // 
            this.picBox.BackgroundImage = global::CarInventoryManagement.Properties.Resources.img_2349571;
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox.Location = new System.Drawing.Point(12, 22);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(188, 180);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // addAutoPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 262);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.priceNumUD);
            this.Controls.Add(this.quantityNumUD);
            this.Controls.Add(this.categoryTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.picTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathPic);
            this.Controls.Add(this.picBox);
            this.Name = "addAutoPartsForm";
            this.Text = "Авточасти ";
            this.Load += new System.EventHandler(this.addAutoPartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button pathPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox picTxtBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox categoryTxtBox;
        private System.Windows.Forms.NumericUpDown quantityNumUD;
        private System.Windows.Forms.NumericUpDown priceNumUD;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}