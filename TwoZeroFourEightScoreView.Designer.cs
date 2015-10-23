namespace twozerofoureight
{
    partial class TwoZeroFourEightScoreView
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
            this.Score = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Freestyle Script", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(49, 111);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(114, 64);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("Mistral", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.Location = new System.Drawing.Point(169, 98);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(65, 79);
            this.lblScore1.TabIndex = 1;
            this.lblScore1.Text = "0";
            this.lblScore1.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // TwoZeroFourEightScoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 316);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.Score);
            this.Name = "TwoZeroFourEightScoreView";
            this.Text = "TwoZeroFourEightScoreView";
            this.Load += new System.EventHandler(this.TwoZeroFourEightScoreView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score;
        public System.Windows.Forms.Label lblScore1;
    }
}