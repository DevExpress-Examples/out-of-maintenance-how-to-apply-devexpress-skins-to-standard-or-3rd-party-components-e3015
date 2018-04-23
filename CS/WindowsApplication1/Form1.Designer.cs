namespace WindowsApplication1
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.skinnedStandardButton2 = new WindowsApplication1.SkinnedStandardButton();
            this.skinnedStandardButton1 = new WindowsApplication1.SkinnedStandardButton();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(403, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "UseSkins";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // skinnedStandardButton2
            // 
            this.skinnedStandardButton2.Location = new System.Drawing.Point(44, 84);
            this.skinnedStandardButton2.Name = "skinnedStandardButton2";
            this.skinnedStandardButton2.Size = new System.Drawing.Size(265, 31);
            this.skinnedStandardButton2.TabIndex = 1;
            this.skinnedStandardButton2.Text = "skinnedStandardButton2";
            this.skinnedStandardButton2.UseSkins = false;
            // 
            // skinnedStandardButton1
            // 
            this.skinnedStandardButton1.Location = new System.Drawing.Point(44, 12);
            this.skinnedStandardButton1.Name = "skinnedStandardButton1";
            this.skinnedStandardButton1.Size = new System.Drawing.Size(265, 31);
            this.skinnedStandardButton1.TabIndex = 0;
            this.skinnedStandardButton1.Text = "skinnedStandardButton1";
            this.skinnedStandardButton1.UseSkins = true;
            this.skinnedStandardButton1.Click += new System.EventHandler(this.skinnedStandardButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 309);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.skinnedStandardButton2);
            this.Controls.Add(this.skinnedStandardButton1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SkinnedStandardButton skinnedStandardButton1;
        private SkinnedStandardButton skinnedStandardButton2;
        private System.Windows.Forms.CheckBox checkBox1;


    }
}

