﻿namespace yoketoruvs20
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.goLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.copyright = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.hsLabel = new System.Windows.Forms.Label();
            this.titleButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelsource = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(246, 69);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(309, 76);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Yoketoru";
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clearLabel.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearLabel.Location = new System.Drawing.Point(312, 83);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(176, 67);
            this.clearLabel.TabIndex = 1;
            this.clearLabel.Text = "Clear";
            this.clearLabel.Visible = false;
            // 
            // goLabel
            // 
            this.goLabel.AutoSize = true;
            this.goLabel.BackColor = System.Drawing.Color.Red;
            this.goLabel.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.goLabel.Location = new System.Drawing.Point(244, 83);
            this.goLabel.Name = "goLabel";
            this.goLabel.Size = new System.Drawing.Size(313, 67);
            this.goLabel.TabIndex = 2;
            this.goLabel.Text = "Gameover";
            this.goLabel.Visible = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Maroon;
            this.startButton.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.ForeColor = System.Drawing.Color.Aqua;
            this.startButton.Location = new System.Drawing.Point(277, 337);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(234, 59);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "スタート!!";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.copyright.Location = new System.Drawing.Point(303, 417);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(183, 24);
            this.copyright.TabIndex = 4;
            this.copyright.Text = "Copyright © 2020";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(0, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(171, 41);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Time 100";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(12, 41);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(92, 41);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "★:10";
            // 
            // hsLabel
            // 
            this.hsLabel.AutoSize = true;
            this.hsLabel.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLabel.Location = new System.Drawing.Point(276, 205);
            this.hsLabel.Name = "hsLabel";
            this.hsLabel.Size = new System.Drawing.Size(212, 41);
            this.hsLabel.TabIndex = 7;
            this.hsLabel.Text = "HighScore 0";
            // 
            // titleButton
            // 
            this.titleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.titleButton.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titleButton.Location = new System.Drawing.Point(277, 337);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(234, 59);
            this.titleButton.TabIndex = 8;
            this.titleButton.Text = "タイトルへ";
            this.titleButton.UseVisualStyleBackColor = false;
            this.titleButton.Visible = false;
            this.titleButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelsource
            // 
            this.labelsource.AutoSize = true;
            this.labelsource.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelsource.ForeColor = System.Drawing.Color.Blue;
            this.labelsource.Location = new System.Drawing.Point(83, 211);
            this.labelsource.Name = "labelsource";
            this.labelsource.Size = new System.Drawing.Size(22, 15);
            this.labelsource.TabIndex = 9;
            this.labelsource.Text = "★";
            this.labelsource.Visible = false;
            this.labelsource.Click += new System.EventHandler(this.labelsource_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelsource);
            this.Controls.Add(this.hsLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.goLabel);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleButton);
            this.Name = "Form1";
            this.Text = "Yoketoru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Label goLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label hsLabel;
        private System.Windows.Forms.Button titleButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelsource;
    }
}

