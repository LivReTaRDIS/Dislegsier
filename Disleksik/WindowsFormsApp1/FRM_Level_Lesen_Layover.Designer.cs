﻿namespace WindowsFormsApp1
{
    partial class FRM_Level_Lesen_Layover
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PNL_InnerEdge = new System.Windows.Forms.Panel();
            this.LBL_SearchedWord = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PNL_Inner_Window = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PNL_InnerEdge.SuspendLayout();
            this.PNL_Inner_Window.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.PNL_InnerEdge);
            this.panel1.Location = new System.Drawing.Point(250, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 300);
            this.panel1.TabIndex = 0;
            // 
            // PNL_InnerEdge
            // 
            this.PNL_InnerEdge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PNL_InnerEdge.Controls.Add(this.LBL_SearchedWord);
            this.PNL_InnerEdge.Controls.Add(this.panel3);
            this.PNL_InnerEdge.Controls.Add(this.PNL_Inner_Window);
            this.PNL_InnerEdge.Location = new System.Drawing.Point(165, 7);
            this.PNL_InnerEdge.Name = "PNL_InnerEdge";
            this.PNL_InnerEdge.Size = new System.Drawing.Size(170, 140);
            this.PNL_InnerEdge.TabIndex = 1;
            // 
            // LBL_SearchedWord
            // 
            this.LBL_SearchedWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_SearchedWord.AutoEllipsis = true;
            this.LBL_SearchedWord.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_SearchedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LBL_SearchedWord.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LBL_SearchedWord.Location = new System.Drawing.Point(17, 52);
            this.LBL_SearchedWord.Margin = new System.Windows.Forms.Padding(0);
            this.LBL_SearchedWord.Name = "LBL_SearchedWord";
            this.LBL_SearchedWord.Size = new System.Drawing.Size(136, 36);
            this.LBL_SearchedWord.TabIndex = 1;
            this.LBL_SearchedWord.Text = "war";
            this.LBL_SearchedWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 1);
            this.panel3.TabIndex = 5;
            // 
            // PNL_Inner_Window
            // 
            this.PNL_Inner_Window.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PNL_Inner_Window.Controls.Add(this.panel4);
            this.PNL_Inner_Window.Location = new System.Drawing.Point(2, 2);
            this.PNL_Inner_Window.Name = "PNL_Inner_Window";
            this.PNL_Inner_Window.Size = new System.Drawing.Size(166, 136);
            this.PNL_Inner_Window.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(85, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 140);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 200);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // FRM_Level_2Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FRM_Level_2Layout";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "te";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Level_2Layout_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Level_2Layout_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRM_Level_2Layout_KeyDown);
            this.Move += new System.EventHandler(this.FRM_Level_2Layout_Move);
            this.panel1.ResumeLayout(false);
            this.PNL_InnerEdge.ResumeLayout(false);
            this.PNL_Inner_Window.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PNL_InnerEdge;
        private System.Windows.Forms.Panel PNL_Inner_Window;
        public System.Windows.Forms.Label LBL_SearchedWord;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}