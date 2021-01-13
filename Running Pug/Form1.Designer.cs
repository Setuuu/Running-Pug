namespace Running_Pug
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
            this.components = new System.ComponentModel.Container();
            this.textLives = new System.Windows.Forms.Label();
            this.textTime = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.heart = new System.Windows.Forms.PictureBox();
            this.pug = new System.Windows.Forms.PictureBox();
            this.fireHydrant = new System.Windows.Forms.PictureBox();
            this.counter = new System.Windows.Forms.Timer(this.components);
            this.finalTime = new System.Windows.Forms.Label();
            this.finalMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireHydrant)).BeginInit();
            this.SuspendLayout();
            // 
            // textLives
            // 
            this.textLives.AutoSize = true;
            this.textLives.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLives.Location = new System.Drawing.Point(677, 9);
            this.textLives.Name = "textLives";
            this.textLives.Size = new System.Drawing.Size(72, 25);
            this.textLives.TabIndex = 4;
            this.textLives.Text = "Lives:";
            this.textLives.Click += new System.EventHandler(this.label1_Click);
            // 
            // textTime
            // 
            this.textTime.AutoSize = true;
            this.textTime.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTime.Location = new System.Drawing.Point(12, 9);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(69, 25);
            this.textTime.TabIndex = 5;
            this.textTime.Text = "Time:";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(-10, 402);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(848, 58);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // heart
            // 
            this.heart.AccessibleName = "heart";
            this.heart.Image = global::Running_Pug.Properties.Resources.heartSmaller1;
            this.heart.Location = new System.Drawing.Point(672, 196);
            this.heart.Name = "heart";
            this.heart.Size = new System.Drawing.Size(50, 50);
            this.heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.heart.TabIndex = 3;
            this.heart.TabStop = false;
            this.heart.Tag = "heart";
            // 
            // pug
            // 
            this.pug.BackColor = System.Drawing.Color.Transparent;
            this.pug.Image = global::Running_Pug.Properties.Resources.runningPug_smaller;
            this.pug.Location = new System.Drawing.Point(12, 331);
            this.pug.Name = "pug";
            this.pug.Size = new System.Drawing.Size(114, 75);
            this.pug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pug.TabIndex = 2;
            this.pug.TabStop = false;
            this.pug.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // fireHydrant
            // 
            this.fireHydrant.BackColor = System.Drawing.Color.Transparent;
            this.fireHydrant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fireHydrant.Image = global::Running_Pug.Properties.Resources.fireHydrant_SMALL;
            this.fireHydrant.Location = new System.Drawing.Point(511, 344);
            this.fireHydrant.Name = "fireHydrant";
            this.fireHydrant.Size = new System.Drawing.Size(40, 59);
            this.fireHydrant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fireHydrant.TabIndex = 6;
            this.fireHydrant.TabStop = false;
            this.fireHydrant.Tag = "fireHydrant";
            // 
            // counter
            // 
            this.counter.Enabled = true;
            this.counter.Interval = 1000;
            this.counter.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // finalTime
            // 
            this.finalTime.AutoSize = true;
            this.finalTime.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalTime.Location = new System.Drawing.Point(303, 196);
            this.finalTime.Name = "finalTime";
            this.finalTime.Size = new System.Drawing.Size(0, 30);
            this.finalTime.TabIndex = 7;
            this.finalTime.Tag = "finalTime";
            this.finalTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.finalTime.Click += new System.EventHandler(this.finalTime_Click);
            // 
            // finalMessage
            // 
            this.finalMessage.AutoSize = true;
            this.finalMessage.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalMessage.Location = new System.Drawing.Point(126, 114);
            this.finalMessage.Name = "finalMessage";
            this.finalMessage.Size = new System.Drawing.Size(0, 34);
            this.finalMessage.TabIndex = 8;
            this.finalMessage.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finalMessage);
            this.Controls.Add(this.finalTime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.textLives);
            this.Controls.Add(this.heart);
            this.Controls.Add(this.pug);
            this.Controls.Add(this.fireHydrant);
            this.Name = "Form1";
            this.Text = "Running Pug";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.isKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.isKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireHydrant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pug;
        private System.Windows.Forms.PictureBox heart;
        private System.Windows.Forms.Label textLives;
        private System.Windows.Forms.Label textTime;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox fireHydrant;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer counter;
        private System.Windows.Forms.Label finalTime;
        private System.Windows.Forms.Label finalMessage;
    }
}

