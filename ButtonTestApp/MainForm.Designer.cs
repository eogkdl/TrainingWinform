﻿namespace ButtonTestApp
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnFlat = new System.Windows.Forms.Button();
            this.BtnPopup = new System.Windows.Forms.Button();
            this.BtnStandard = new System.Windows.Forms.Button();
            this.BtnSystem = new System.Windows.Forms.Button();
            this.LblButtonStyle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnFlat
            // 
            this.BtnFlat.BackColor = System.Drawing.SystemColors.Window;
            this.BtnFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFlat.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnFlat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnFlat.Location = new System.Drawing.Point(75, 43);
            this.BtnFlat.Name = "BtnFlat";
            this.BtnFlat.Size = new System.Drawing.Size(168, 111);
            this.BtnFlat.TabIndex = 0;
            this.BtnFlat.Text = "Flat";
            this.BtnFlat.UseVisualStyleBackColor = false;
            this.BtnFlat.Click += new System.EventHandler(this.BtnFlat_Click);
            // 
            // BtnPopup
            // 
            this.BtnPopup.BackColor = System.Drawing.SystemColors.Window;
            this.BtnPopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPopup.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnPopup.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnPopup.Location = new System.Drawing.Point(291, 43);
            this.BtnPopup.Name = "BtnPopup";
            this.BtnPopup.Size = new System.Drawing.Size(168, 111);
            this.BtnPopup.TabIndex = 1;
            this.BtnPopup.Text = "Popup";
            this.BtnPopup.UseVisualStyleBackColor = false;
            this.BtnPopup.Click += new System.EventHandler(this.BtnPopup_Click);
            // 
            // BtnStandard
            // 
            this.BtnStandard.BackColor = System.Drawing.SystemColors.Window;
            this.BtnStandard.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnStandard.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnStandard.Location = new System.Drawing.Point(75, 206);
            this.BtnStandard.Name = "BtnStandard";
            this.BtnStandard.Size = new System.Drawing.Size(168, 111);
            this.BtnStandard.TabIndex = 2;
            this.BtnStandard.Text = "Standard";
            this.BtnStandard.UseVisualStyleBackColor = false;
            this.BtnStandard.Click += new System.EventHandler(this.BtnStandard_Click);
            // 
            // BtnSystem
            // 
            this.BtnSystem.BackColor = System.Drawing.SystemColors.Window;
            this.BtnSystem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSystem.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSystem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnSystem.Location = new System.Drawing.Point(291, 206);
            this.BtnSystem.Name = "BtnSystem";
            this.BtnSystem.Size = new System.Drawing.Size(168, 111);
            this.BtnSystem.TabIndex = 3;
            this.BtnSystem.Text = "System";
            this.BtnSystem.UseVisualStyleBackColor = false;
            this.BtnSystem.Click += new System.EventHandler(this.BtnSystem_Click);
            // 
            // LblButtonStyle
            // 
            this.LblButtonStyle.AutoSize = true;
            this.LblButtonStyle.Location = new System.Drawing.Point(13, 353);
            this.LblButtonStyle.Name = "LblButtonStyle";
            this.LblButtonStyle.Size = new System.Drawing.Size(45, 15);
            this.LblButtonStyle.TabIndex = 4;
            this.LblButtonStyle.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 380);
            this.Controls.Add(this.LblButtonStyle);
            this.Controls.Add(this.BtnSystem);
            this.Controls.Add(this.BtnStandard);
            this.Controls.Add(this.BtnPopup);
            this.Controls.Add(this.BtnFlat);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFlat;
        private System.Windows.Forms.Button BtnPopup;
        private System.Windows.Forms.Button BtnStandard;
        private System.Windows.Forms.Button BtnSystem;
        private System.Windows.Forms.Label LblButtonStyle;
    }
}

