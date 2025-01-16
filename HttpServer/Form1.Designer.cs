namespace HttpServer
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
            this.startServerBtn = new System.Windows.Forms.Button();
            this.stopServerBtn = new System.Windows.Forms.Button();
            this.serverLogsText = new System.Windows.Forms.TextBox();
            this.serverPortText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startServerBtn
            // 
            this.startServerBtn.Location = new System.Drawing.Point(23, 247);
            this.startServerBtn.Name = "startServerBtn";
            this.startServerBtn.Size = new System.Drawing.Size(75, 38);
            this.startServerBtn.TabIndex = 0;
            this.startServerBtn.Text = "Start";
            this.startServerBtn.UseVisualStyleBackColor = true;
            this.startServerBtn.Click += new System.EventHandler(this.startServerBtn_Click);
            // 
            // stopServerBtn
            // 
            this.stopServerBtn.Location = new System.Drawing.Point(104, 247);
            this.stopServerBtn.Name = "stopServerBtn";
            this.stopServerBtn.Size = new System.Drawing.Size(75, 38);
            this.stopServerBtn.TabIndex = 1;
            this.stopServerBtn.Text = "Stop";
            this.stopServerBtn.UseVisualStyleBackColor = true;
            this.stopServerBtn.Click += new System.EventHandler(this.stopServerBtn_Click);
            // 
            // serverLogsText
            // 
            this.serverLogsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverLogsText.Location = new System.Drawing.Point(195, 33);
            this.serverLogsText.Multiline = true;
            this.serverLogsText.Name = "serverLogsText";
            this.serverLogsText.Size = new System.Drawing.Size(635, 524);
            this.serverLogsText.TabIndex = 2;
            // 
            // serverPortText
            // 
            this.serverPortText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverPortText.Location = new System.Drawing.Point(23, 318);
            this.serverPortText.Name = "serverPortText";
            this.serverPortText.Size = new System.Drawing.Size(100, 20);
            this.serverPortText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server logs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 569);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverPortText);
            this.Controls.Add(this.serverLogsText);
            this.Controls.Add(this.stopServerBtn);
            this.Controls.Add(this.startServerBtn);
            this.Name = "Form1";
            this.Text = "HttpServer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startServerBtn;
        private System.Windows.Forms.Button stopServerBtn;
        private System.Windows.Forms.TextBox serverLogsText;
        private System.Windows.Forms.TextBox serverPortText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

