namespace 多线程_框架
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ucProcessLine1 = new HZH_Controls.Controls.UCProcessLine();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ucProcessLine2 = new HZH_Controls.Controls.UCProcessLine();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucProcessLine3 = new HZH_Controls.Controls.UCProcessLine();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ucProcessLine4 = new HZH_Controls.Controls.UCProcessLine();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ucProcessLine5 = new HZH_Controls.Controls.UCProcessLine();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "线程1:";
            // 
            // ucProcessLine1
            // 
            this.ucProcessLine1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ucProcessLine1.ForeColor = System.Drawing.Color.White;
            this.ucProcessLine1.Location = new System.Drawing.Point(125, 22);
            this.ucProcessLine1.MaxValue = 100;
            this.ucProcessLine1.Name = "ucProcessLine1";
            this.ucProcessLine1.Size = new System.Drawing.Size(521, 50);
            this.ucProcessLine1.TabIndex = 3;
            this.ucProcessLine1.Text = "ucProcessLine1";
            this.ucProcessLine1.Value = 0;
            this.ucProcessLine1.ValueBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessLine1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucProcessLine1.ValueTextType = HZH_Controls.Controls.ValueTextType.Percent;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(672, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "启动线程";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(831, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "停止线程";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ucProcessLine2
            // 
            this.ucProcessLine2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ucProcessLine2.ForeColor = System.Drawing.Color.White;
            this.ucProcessLine2.Location = new System.Drawing.Point(125, 97);
            this.ucProcessLine2.MaxValue = 100;
            this.ucProcessLine2.Name = "ucProcessLine2";
            this.ucProcessLine2.Size = new System.Drawing.Size(521, 50);
            this.ucProcessLine2.TabIndex = 3;
            this.ucProcessLine2.Text = "ucProcessLine1";
            this.ucProcessLine2.Value = 0;
            this.ucProcessLine2.ValueBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessLine2.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucProcessLine2.ValueTextType = HZH_Controls.Controls.ValueTextType.Percent;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(672, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 60);
            this.button3.TabIndex = 5;
            this.button3.Text = "启动线程";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(831, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 60);
            this.button4.TabIndex = 5;
            this.button4.Text = "停止线程";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "线程2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(14, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "线程3:";
            // 
            // ucProcessLine3
            // 
            this.ucProcessLine3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessLine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ucProcessLine3.ForeColor = System.Drawing.Color.White;
            this.ucProcessLine3.Location = new System.Drawing.Point(125, 174);
            this.ucProcessLine3.MaxValue = 100;
            this.ucProcessLine3.Name = "ucProcessLine3";
            this.ucProcessLine3.Size = new System.Drawing.Size(521, 50);
            this.ucProcessLine3.TabIndex = 3;
            this.ucProcessLine3.Text = "ucProcessLine1";
            this.ucProcessLine3.Value = 0;
            this.ucProcessLine3.ValueBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessLine3.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucProcessLine3.ValueTextType = HZH_Controls.Controls.ValueTextType.Percent;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(672, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 60);
            this.button5.TabIndex = 5;
            this.button5.Text = "启动线程";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(831, 164);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 60);
            this.button6.TabIndex = 5;
            this.button6.Text = "停止线程";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(14, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "线程4:";
            // 
            // ucProcessLine4
            // 
            this.ucProcessLine4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessLine4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ucProcessLine4.ForeColor = System.Drawing.Color.White;
            this.ucProcessLine4.Location = new System.Drawing.Point(125, 252);
            this.ucProcessLine4.MaxValue = 100;
            this.ucProcessLine4.Name = "ucProcessLine4";
            this.ucProcessLine4.Size = new System.Drawing.Size(521, 50);
            this.ucProcessLine4.TabIndex = 3;
            this.ucProcessLine4.Text = "ucProcessLine1";
            this.ucProcessLine4.Value = 0;
            this.ucProcessLine4.ValueBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessLine4.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucProcessLine4.ValueTextType = HZH_Controls.Controls.ValueTextType.Percent;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(672, 245);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 60);
            this.button7.TabIndex = 5;
            this.button7.Text = "启动线程";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(831, 242);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 60);
            this.button8.TabIndex = 5;
            this.button8.Text = "停止线程";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(14, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "线程5:";
            // 
            // ucProcessLine5
            // 
            this.ucProcessLine5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessLine5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ucProcessLine5.ForeColor = System.Drawing.Color.White;
            this.ucProcessLine5.Location = new System.Drawing.Point(125, 324);
            this.ucProcessLine5.MaxValue = 100;
            this.ucProcessLine5.Name = "ucProcessLine5";
            this.ucProcessLine5.Size = new System.Drawing.Size(521, 50);
            this.ucProcessLine5.TabIndex = 3;
            this.ucProcessLine5.Text = "ucProcessLine1";
            this.ucProcessLine5.Value = 0;
            this.ucProcessLine5.ValueBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessLine5.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucProcessLine5.ValueTextType = HZH_Controls.Controls.ValueTextType.Percent;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(672, 317);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(144, 60);
            this.button9.TabIndex = 5;
            this.button9.Text = "启动线程";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.Location = new System.Drawing.Point(831, 314);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(144, 60);
            this.button10.TabIndex = 5;
            this.button10.Text = "停止线程";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button11.Location = new System.Drawing.Point(21, 387);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(172, 60);
            this.button11.TabIndex = 5;
            this.button11.Text = "启动全部线程";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button12.Location = new System.Drawing.Point(199, 387);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(172, 60);
            this.button12.TabIndex = 5;
            this.button12.Text = "停止全部线程";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button13.Location = new System.Drawing.Point(377, 387);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(172, 60);
            this.button13.TabIndex = 5;
            this.button13.Text = "进度条归零";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 459);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ucProcessLine5);
            this.Controls.Add(this.ucProcessLine4);
            this.Controls.Add(this.ucProcessLine3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ucProcessLine2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ucProcessLine1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.UCProcessLine ucProcessLine1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private HZH_Controls.Controls.UCProcessLine ucProcessLine2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private HZH_Controls.Controls.UCProcessLine ucProcessLine3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private HZH_Controls.Controls.UCProcessLine ucProcessLine4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label5;
        private HZH_Controls.Controls.UCProcessLine ucProcessLine5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}

