﻿namespace WinAbstractionDemo1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnArc = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArc
            // 
            this.btnArc.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArc.Location = new System.Drawing.Point(413, 341);
            this.btnArc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArc.Name = "btnArc";
            this.btnArc.Size = new System.Drawing.Size(116, 42);
            this.btnArc.TabIndex = 5;
            this.btnArc.Text = "畫圓弧";
            this.btnArc.UseVisualStyleBackColor = true;
            this.btnArc.Click += new System.EventHandler(this.btnArc_Click);
            // 
            // btnLine
            // 
            this.btnLine.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLine.Location = new System.Drawing.Point(268, 341);
            this.btnLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(116, 42);
            this.btnLine.TabIndex = 4;
            this.btnLine.Text = "畫線";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCircle.Location = new System.Drawing.Point(132, 341);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(116, 42);
            this.btnCircle.TabIndex = 3;
            this.btnCircle.Text = "畫圓";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 711);
            this.Controls.Add(this.btnArc);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnCircle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArc;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnCircle;
    }
}

