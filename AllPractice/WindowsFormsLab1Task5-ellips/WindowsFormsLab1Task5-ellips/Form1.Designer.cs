
namespace WindowsFormsLab1Task5_ellips
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
            this.Close_Ellipse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Close_Ellipse
            // 
            this.Close_Ellipse.BackColor = System.Drawing.Color.Purple;
            this.Close_Ellipse.Location = new System.Drawing.Point(324, 178);
            this.Close_Ellipse.Name = "Close_Ellipse";
            this.Close_Ellipse.Size = new System.Drawing.Size(75, 23);
            this.Close_Ellipse.TabIndex = 0;
            this.Close_Ellipse.Text = "Close";
            this.Close_Ellipse.UseVisualStyleBackColor = false;
            this.Close_Ellipse.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.Close_Ellipse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close_Ellipse;
    }
}

