namespace EasyManage
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtContents = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Button();
            this.Progress = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(62, 253);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(175, 66);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Location = new System.Drawing.Point(547, 253);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(175, 66);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // txtContents
            // 
            this.txtContents.AutoSize = true;
            this.txtContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContents.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtContents.Location = new System.Drawing.Point(57, 140);
            this.txtContents.MinimumSize = new System.Drawing.Size(665, 0);
            this.txtContents.Name = "txtContents";
            this.txtContents.Size = new System.Drawing.Size(665, 32);
            this.txtContents.TabIndex = 3;
            this.txtContents.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.SystemColors.Highlight;
            this.pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pause.Location = new System.Drawing.Point(309, 253);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(175, 66);
            this.pause.TabIndex = 4;
            this.pause.Text = "PAUSE";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(-2, 366);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(807, 19);
            this.Progress.TabIndex = 5;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(100);
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.txtContents);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Tag = "EasyManage by Yunis Huseynzade";
            this.Text = "EasyManage Control Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label txtContents;
        private System.Windows.Forms.Button pause;
        private MetroFramework.Controls.MetroProgressBar Progress;
    }
}

