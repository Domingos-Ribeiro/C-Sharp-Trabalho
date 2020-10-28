namespace Trabalho_Final
{
    partial class Technical_Sprt
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
            this.rtb_TechSprt = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_TechSprt
            // 
            this.rtb_TechSprt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_TechSprt.Location = new System.Drawing.Point(40, 67);
            this.rtb_TechSprt.Name = "rtb_TechSprt";
            this.rtb_TechSprt.ReadOnly = true;
            this.rtb_TechSprt.Size = new System.Drawing.Size(350, 100);
            this.rtb_TechSprt.TabIndex = 0;
            this.rtb_TechSprt.Text = "   At the moment, only the menus shown in bold are working, all others will be im" +
    "plemented shortly.\n\n   We apologize for the fact.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(166, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Technical_Sprt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb_TechSprt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Technical_Sprt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Technical Support Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_TechSprt;
        private System.Windows.Forms.Button button1;
    }
}