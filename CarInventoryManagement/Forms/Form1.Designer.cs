namespace CarInventoryManagement
{
    partial class Form1
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
            this.addpartsbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addpartsbtn
            // 
            this.addpartsbtn.Location = new System.Drawing.Point(71, 12);
            this.addpartsbtn.Name = "addpartsbtn";
            this.addpartsbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addpartsbtn.Size = new System.Drawing.Size(231, 75);
            this.addpartsbtn.TabIndex = 0;
            this.addpartsbtn.Text = "Авточасти";
            this.addpartsbtn.UseVisualStyleBackColor = true;
            this.addpartsbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 111);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(231, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "Автоаксесоари";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 210);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addpartsbtn);
            this.Name = "Form1";
            this.Text = "Автомагазин";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addpartsbtn;
        private System.Windows.Forms.Button button1;
    }
}

