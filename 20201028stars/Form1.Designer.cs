namespace _20201028stars
{
    partial class row
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
            this.label1 = new System.Windows.Forms.Label();
            this.rowChooser = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rowChooser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(233, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "列數";
            // 
            // rowChooser
            // 
            this.rowChooser.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rowChooser.Location = new System.Drawing.Point(364, 122);
            this.rowChooser.Name = "rowChooser";
            this.rowChooser.Size = new System.Drawing.Size(171, 51);
            this.rowChooser.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(255, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "按這裡";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // row
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rowChooser);
            this.Controls.Add(this.label1);
            this.Name = "row";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rowChooser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown rowChooser;
        private System.Windows.Forms.Button button1;
    }
}

