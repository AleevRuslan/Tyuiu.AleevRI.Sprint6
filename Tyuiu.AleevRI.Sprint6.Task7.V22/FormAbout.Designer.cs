
namespace Tyuiu.AleevRI.Sprint6.Task7.V22
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_ARI = new System.Windows.Forms.Label();
            this.buttonOk_ARI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo_ARI
            // 
            this.labelInfo_ARI.AutoSize = true;
            this.labelInfo_ARI.Location = new System.Drawing.Point(65, 9);
            this.labelInfo_ARI.Name = "labelInfo_ARI";
            this.labelInfo_ARI.Size = new System.Drawing.Size(284, 143);
            this.labelInfo_ARI.TabIndex = 0;
            this.labelInfo_ARI.Text = resources.GetString("labelInfo_ARI.Text");
            // 
            // buttonOk_ARI
            // 
            this.buttonOk_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk_ARI.Location = new System.Drawing.Point(312, 146);
            this.buttonOk_ARI.Name = "buttonOk_ARI";
            this.buttonOk_ARI.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_ARI.TabIndex = 1;
            this.buttonOk_ARI.Text = "Ок";
            this.buttonOk_ARI.UseVisualStyleBackColor = true;
            this.buttonOk_ARI.Click += new System.EventHandler(this.buttonOk_ARI_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 181);
            this.Controls.Add(this.buttonOk_ARI);
            this.Controls.Add(this.labelInfo_ARI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_ARI;
        private System.Windows.Forms.Button buttonOk_ARI;
    }
}