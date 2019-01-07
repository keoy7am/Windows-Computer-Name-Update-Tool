namespace 電腦名稱修改器
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.tb_NewName = new System.Windows.Forms.TextBox();
            this.lb_NewName = new System.Windows.Forms.Label();
            this.lb_OriginalName = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_NewName
            // 
            this.tb_NewName.Font = new System.Drawing.Font("新細明體", 12F);
            this.tb_NewName.Location = new System.Drawing.Point(156, 67);
            this.tb_NewName.Name = "tb_NewName";
            this.tb_NewName.Size = new System.Drawing.Size(232, 27);
            this.tb_NewName.TabIndex = 0;
            // 
            // lb_NewName
            // 
            this.lb_NewName.AutoSize = true;
            this.lb_NewName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_NewName.Location = new System.Drawing.Point(12, 67);
            this.lb_NewName.Name = "lb_NewName";
            this.lb_NewName.Size = new System.Drawing.Size(138, 27);
            this.lb_NewName.TabIndex = 1;
            this.lb_NewName.Text = "新電腦名稱：";
            // 
            // lb_OriginalName
            // 
            this.lb_OriginalName.AutoSize = true;
            this.lb_OriginalName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_OriginalName.Location = new System.Drawing.Point(12, 40);
            this.lb_OriginalName.Name = "lb_OriginalName";
            this.lb_OriginalName.Size = new System.Drawing.Size(138, 27);
            this.lb_OriginalName.TabIndex = 2;
            this.lb_OriginalName.Text = "舊電腦名稱：";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Clear.Location = new System.Drawing.Point(17, 109);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(160, 75);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "清除";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Save.Location = new System.Drawing.Point(230, 109);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(160, 75);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "修改";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Restart.Location = new System.Drawing.Point(230, 109);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(160, 75);
            this.btn_Restart.TabIndex = 5;
            this.btn_Restart.Text = "重新啟動";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Visible = false;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 200);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lb_OriginalName);
            this.Controls.Add(this.lb_NewName);
            this.Controls.Add(this.tb_NewName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "電腦名稱修改器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NewName;
        private System.Windows.Forms.Label lb_NewName;
        private System.Windows.Forms.Label lb_OriginalName;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Restart;
    }
}

