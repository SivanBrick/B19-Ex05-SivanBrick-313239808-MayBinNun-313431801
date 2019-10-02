namespace UI
{
    partial class LogInFormD
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
            this.buttonChances = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChances
            // 
            this.buttonChances.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChances.Location = new System.Drawing.Point(41, 54);
            this.buttonChances.Name = "buttonChances";
            this.buttonChances.Size = new System.Drawing.Size(383, 37);
            this.buttonChances.TabIndex = 1;
            this.buttonChances.Text = "Number of chances : 4";
            this.buttonChances.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(317, 120);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(107, 37);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // LogInFormD
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 205);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonChances);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LogInFormD";
            this.Text = "LogInFormD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChances;
        private System.Windows.Forms.Button buttonStart;
    }
}