namespace HandlingIe
{
    partial class ComSample
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
            this.btnOpenYahoo = new System.Windows.Forms.Button();
            this.btnOpenGoogle = new System.Windows.Forms.Button();
            this.btnYahooCloseLastOpenWindow = new System.Windows.Forms.Button();
            this.btnGoogleCloseLastOpenWindow = new System.Windows.Forms.Button();
            this.btnYahooCloseAll = new System.Windows.Forms.Button();
            this.btnGoogleCloseAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCloseParentYahoo = new System.Windows.Forms.Label();
            this.lblCloseParentGoogle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenYahoo
            // 
            this.btnOpenYahoo.Location = new System.Drawing.Point(38, 63);
            this.btnOpenYahoo.Name = "btnOpenYahoo";
            this.btnOpenYahoo.Size = new System.Drawing.Size(75, 48);
            this.btnOpenYahoo.TabIndex = 0;
            this.btnOpenYahoo.Text = "Open Yahoo";
            this.btnOpenYahoo.UseVisualStyleBackColor = true;
            this.btnOpenYahoo.Click += new System.EventHandler(this.btnOpenYahoo_Click);
            // 
            // btnOpenGoogle
            // 
            this.btnOpenGoogle.Location = new System.Drawing.Point(38, 193);
            this.btnOpenGoogle.Name = "btnOpenGoogle";
            this.btnOpenGoogle.Size = new System.Drawing.Size(75, 51);
            this.btnOpenGoogle.TabIndex = 1;
            this.btnOpenGoogle.Text = "Open Google";
            this.btnOpenGoogle.UseVisualStyleBackColor = true;
            this.btnOpenGoogle.Click += new System.EventHandler(this.btnOpenGoogle_Click);
            // 
            // btnYahooCloseLastOpenWindow
            // 
            this.btnYahooCloseLastOpenWindow.Location = new System.Drawing.Point(152, 44);
            this.btnYahooCloseLastOpenWindow.Name = "btnYahooCloseLastOpenWindow";
            this.btnYahooCloseLastOpenWindow.Size = new System.Drawing.Size(75, 76);
            this.btnYahooCloseLastOpenWindow.TabIndex = 2;
            this.btnYahooCloseLastOpenWindow.Text = "Close Last Open window";
            this.btnYahooCloseLastOpenWindow.UseVisualStyleBackColor = true;
            this.btnYahooCloseLastOpenWindow.Click += new System.EventHandler(this.btnYahooCloseLastOpenWindow_Click);
            // 
            // btnGoogleCloseLastOpenWindow
            // 
            this.btnGoogleCloseLastOpenWindow.Location = new System.Drawing.Point(152, 176);
            this.btnGoogleCloseLastOpenWindow.Name = "btnGoogleCloseLastOpenWindow";
            this.btnGoogleCloseLastOpenWindow.Size = new System.Drawing.Size(75, 85);
            this.btnGoogleCloseLastOpenWindow.TabIndex = 3;
            this.btnGoogleCloseLastOpenWindow.Text = "Close Last Open window";
            this.btnGoogleCloseLastOpenWindow.UseVisualStyleBackColor = true;
            this.btnGoogleCloseLastOpenWindow.Click += new System.EventHandler(this.btnGoogleCloseLastOpenWindow_Click);
            // 
            // btnYahooCloseAll
            // 
            this.btnYahooCloseAll.Location = new System.Drawing.Point(270, 54);
            this.btnYahooCloseAll.Name = "btnYahooCloseAll";
            this.btnYahooCloseAll.Size = new System.Drawing.Size(75, 57);
            this.btnYahooCloseAll.TabIndex = 4;
            this.btnYahooCloseAll.Text = "Close All";
            this.btnYahooCloseAll.UseVisualStyleBackColor = true;
            this.btnYahooCloseAll.Click += new System.EventHandler(this.btnYahooCloseAll_Click);
            // 
            // btnGoogleCloseAll
            // 
            this.btnGoogleCloseAll.Location = new System.Drawing.Point(270, 191);
            this.btnGoogleCloseAll.Name = "btnGoogleCloseAll";
            this.btnGoogleCloseAll.Size = new System.Drawing.Size(75, 54);
            this.btnGoogleCloseAll.TabIndex = 5;
            this.btnGoogleCloseAll.Text = "Close All";
            this.btnGoogleCloseAll.UseVisualStyleBackColor = true;
            this.btnGoogleCloseAll.Click += new System.EventHandler(this.btnGoogleCloseAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "親が閉じられたか";
            // 
            // lblCloseParentYahoo
            // 
            this.lblCloseParentYahoo.AutoSize = true;
            this.lblCloseParentYahoo.Location = new System.Drawing.Point(551, 75);
            this.lblCloseParentYahoo.Name = "lblCloseParentYahoo";
            this.lblCloseParentYahoo.Size = new System.Drawing.Size(0, 15);
            this.lblCloseParentYahoo.TabIndex = 8;
            // 
            // lblCloseParentGoogle
            // 
            this.lblCloseParentGoogle.AutoSize = true;
            this.lblCloseParentGoogle.Location = new System.Drawing.Point(551, 211);
            this.lblCloseParentGoogle.Name = "lblCloseParentGoogle";
            this.lblCloseParentGoogle.Size = new System.Drawing.Size(0, 15);
            this.lblCloseParentGoogle.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "親が閉じられたか";
            // 
            // ComSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCloseParentGoogle);
            this.Controls.Add(this.lblCloseParentYahoo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoogleCloseAll);
            this.Controls.Add(this.btnYahooCloseAll);
            this.Controls.Add(this.btnGoogleCloseLastOpenWindow);
            this.Controls.Add(this.btnYahooCloseLastOpenWindow);
            this.Controls.Add(this.btnOpenGoogle);
            this.Controls.Add(this.btnOpenYahoo);
            this.Name = "ComSample";
            this.Text = "ComSample.cs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenYahoo;
        private System.Windows.Forms.Button btnOpenGoogle;
        private System.Windows.Forms.Button btnYahooCloseLastOpenWindow;
        private System.Windows.Forms.Button btnGoogleCloseLastOpenWindow;
        private System.Windows.Forms.Button btnYahooCloseAll;
        private System.Windows.Forms.Button btnGoogleCloseAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCloseParentYahoo;
        private System.Windows.Forms.Label lblCloseParentGoogle;
        private System.Windows.Forms.Label label2;
    }
}

