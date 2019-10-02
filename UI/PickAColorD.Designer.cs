namespace UI
{
    partial class PickAcolorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickAcolorForm));
            this.pink = new System.Windows.Forms.Button();
            this.orange = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.purpel = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.brown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 
            // 
            this.pink.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.pink, "pink");
            this.pink.UseVisualStyleBackColor = false;
            this.pink.Click += new System.EventHandler(this.Color_Click);
            // 
            // 
            // 
            this.orange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.orange, "orange");
            this.orange.UseVisualStyleBackColor = false;
            this.orange.Click += new System.EventHandler(this.Color_Click);
            // 
            // 
            // 
            this.green.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.green, "green");
            this.green.UseVisualStyleBackColor = false;
            this.green.Click += new System.EventHandler(this.Color_Click);
            // 
            // 
            // 
            this.yellow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.yellow, "yellow");
            this.yellow.UseVisualStyleBackColor = false;
            this.yellow.Click += new System.EventHandler(this.Color_Click);
            // 
            // 
            // 
            this.red.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.red, "red");
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.Color_Click);
            // 
            // 
            // 
            this.purpel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.purpel, "purpel");
            this.purpel.UseVisualStyleBackColor = false;
            this.purpel.Click += new System.EventHandler(this.Color_Click);
            // 
            // 
            // 
            this.blue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.blue, "blue");
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.Color_Click);
            // 
            // 
            // 
            this.brown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.brown, "brown");
            this.brown.UseVisualStyleBackColor = false;
            this.brown.Click += new System.EventHandler(this.Color_Click);
            // 
            // PickAcolorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.brown);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.purpel);
            this.Controls.Add(this.red);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.green);
            this.Controls.Add(this.orange);
            this.Controls.Add(this.pink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PickAcolorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pink;
        private System.Windows.Forms.Button orange;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button purpel;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button brown;
    }
}