namespace PrsingXMLFile
{
    partial class Form2
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
            this.textBoxData1 = new System.Windows.Forms.TextBox();
            this.textBoxData2 = new System.Windows.Forms.TextBox();
            this.textBoxData3 = new System.Windows.Forms.TextBox();
            this.buttonCreateSaveXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxData1
            // 
            this.textBoxData1.Location = new System.Drawing.Point(88, 28);
            this.textBoxData1.Name = "textBoxData1";
            this.textBoxData1.Size = new System.Drawing.Size(100, 20);
            this.textBoxData1.TabIndex = 0;
            // 
            // textBoxData2
            // 
            this.textBoxData2.Location = new System.Drawing.Point(88, 67);
            this.textBoxData2.Name = "textBoxData2";
            this.textBoxData2.Size = new System.Drawing.Size(100, 20);
            this.textBoxData2.TabIndex = 1;
            // 
            // textBoxData3
            // 
            this.textBoxData3.Location = new System.Drawing.Point(88, 103);
            this.textBoxData3.Name = "textBoxData3";
            this.textBoxData3.Size = new System.Drawing.Size(100, 20);
            this.textBoxData3.TabIndex = 2;
            // 
            // buttonCreateSaveXml
            // 
            this.buttonCreateSaveXml.Location = new System.Drawing.Point(100, 143);
            this.buttonCreateSaveXml.Name = "buttonCreateSaveXml";
            this.buttonCreateSaveXml.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateSaveXml.TabIndex = 3;
            this.buttonCreateSaveXml.Text = "button1";
            this.buttonCreateSaveXml.UseVisualStyleBackColor = true;
            this.buttonCreateSaveXml.Click += new System.EventHandler(this.buttonCreateSaveXml_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonCreateSaveXml);
            this.Controls.Add(this.textBoxData3);
            this.Controls.Add(this.textBoxData2);
            this.Controls.Add(this.textBoxData1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxData1;
        private System.Windows.Forms.TextBox textBoxData2;
        private System.Windows.Forms.TextBox textBoxData3;
        private System.Windows.Forms.Button buttonCreateSaveXml;
    }
}