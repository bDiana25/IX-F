namespace tRex
{
    partial class EndlessRunner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndlessRunner));
            this.scoreLabel = new System.Windows.Forms.Label();
            this.trexPictureBox = new System.Windows.Forms.PictureBox();
            this.obs1PB = new System.Windows.Forms.PictureBox();
            this.obs2PB = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trexPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs1PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs2PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 20);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(106, 24);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "score:0 ";
            // 
            // trexPictureBox
            // 
            this.trexPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("trexPictureBox.Image")));
            this.trexPictureBox.Location = new System.Drawing.Point(35, 369);
            this.trexPictureBox.Name = "trexPictureBox";
            this.trexPictureBox.Size = new System.Drawing.Size(40, 43);
            this.trexPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trexPictureBox.TabIndex = 1;
            this.trexPictureBox.TabStop = false;
            // 
            // obs1PB
            // 
            this.obs1PB.Image = ((System.Drawing.Image)(resources.GetObject("obs1PB.Image")));
            this.obs1PB.Location = new System.Drawing.Point(177, 366);
            this.obs1PB.Name = "obs1PB";
            this.obs1PB.Size = new System.Drawing.Size(23, 46);
            this.obs1PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obs1PB.TabIndex = 2;
            this.obs1PB.TabStop = false;
            this.obs1PB.Tag = "obstacle";
            // 
            // obs2PB
            // 
            this.obs2PB.Image = ((System.Drawing.Image)(resources.GetObject("obs2PB.Image")));
            this.obs2PB.Location = new System.Drawing.Point(278, 379);
            this.obs2PB.Name = "obs2PB";
            this.obs2PB.Size = new System.Drawing.Size(32, 33);
            this.obs2PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obs2PB.TabIndex = 3;
            this.obs2PB.TabStop = false;
            this.obs2PB.Tag = "obstacle";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(-3, 406);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(807, 50);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // EndlessRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.obs2PB);
            this.Controls.Add(this.obs1PB);
            this.Controls.Add(this.trexPictureBox);
            this.Controls.Add(this.scoreLabel);
            this.Name = "EndlessRunner";
            this.Text = "EndlessRunner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.trexPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs1PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs2PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox trexPictureBox;
        private System.Windows.Forms.PictureBox obs1PB;
        private System.Windows.Forms.PictureBox obs2PB;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

