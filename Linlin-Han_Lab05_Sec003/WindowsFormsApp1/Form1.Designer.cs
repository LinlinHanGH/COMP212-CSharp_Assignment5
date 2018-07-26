namespace WindowsFormsApp1
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
            this.btnGenInt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenInt
            // 
            this.btnGenInt.Location = new System.Drawing.Point(12, 26);
            this.btnGenInt.Name = "btnGenInt";
            this.btnGenInt.Size = new System.Drawing.Size(217, 35);
            this.btnGenInt.TabIndex = 0;
            this.btnGenInt.Text = "Generate Random Int";
            this.btnGenInt.UseVisualStyleBackColor = true;
            this.btnGenInt.Click += new System.EventHandler(this.btnGenInt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 244);
            this.Controls.Add(this.btnGenInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenInt;
    }
}

