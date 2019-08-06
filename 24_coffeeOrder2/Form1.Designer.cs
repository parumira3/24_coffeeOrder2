namespace _24_coffeeOrder2
{
    partial class Form1
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
            this.GropBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDow1 = new System.Windows.Forms.RadioButton();
            this.rdoDow2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoEdge2 = new System.Windows.Forms.RadioButton();
            this.rdoEdge1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxTop1 = new System.Windows.Forms.CheckBox();
            this.cBoxTop3 = new System.Windows.Forms.CheckBox();
            this.cBoxTop2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lBoxOrder = new System.Windows.Forms.ListBox();
            this.GropBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // GropBox1
            // 
            this.GropBox1.Controls.Add(this.rdoDow2);
            this.GropBox1.Controls.Add(this.rdoDow1);
            this.GropBox1.Location = new System.Drawing.Point(3, 3);
            this.GropBox1.Name = "GropBox1";
            this.GropBox1.Size = new System.Drawing.Size(327, 53);
            this.GropBox1.TabIndex = 0;
            this.GropBox1.TabStop = false;
            this.GropBox1.Text = "도우";
            // 
            // rdoDow1
            // 
            this.rdoDow1.AutoSize = true;
            this.rdoDow1.Location = new System.Drawing.Point(9, 20);
            this.rdoDow1.Name = "rdoDow1";
            this.rdoDow1.Size = new System.Drawing.Size(127, 16);
            this.rdoDow1.TabIndex = 0;
            this.rdoDow1.TabStop = true;
            this.rdoDow1.Text = "오리지널(10,000원)";
            this.rdoDow1.UseVisualStyleBackColor = true;
            // 
            // rdoDow2
            // 
            this.rdoDow2.AutoSize = true;
            this.rdoDow2.Location = new System.Drawing.Point(156, 20);
            this.rdoDow2.Name = "rdoDow2";
            this.rdoDow2.Size = new System.Drawing.Size(91, 16);
            this.rdoDow2.TabIndex = 1;
            this.rdoDow2.TabStop = true;
            this.rdoDow2.Text = "씬(11,000원)";
            this.rdoDow2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoEdge2);
            this.groupBox1.Controls.Add(this.rdoEdge1);
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "엣지";
            // 
            // rdoEdge2
            // 
            this.rdoEdge2.AutoSize = true;
            this.rdoEdge2.Location = new System.Drawing.Point(156, 20);
            this.rdoEdge2.Name = "rdoEdge2";
            this.rdoEdge2.Size = new System.Drawing.Size(145, 16);
            this.rdoEdge2.TabIndex = 1;
            this.rdoEdge2.TabStop = true;
            this.rdoEdge2.Text = "치즈크러스트(2,000원)";
            this.rdoEdge2.UseVisualStyleBackColor = true;
            // 
            // rdoEdge1
            // 
            this.rdoEdge1.AutoSize = true;
            this.rdoEdge1.Location = new System.Drawing.Point(9, 20);
            this.rdoEdge1.Name = "rdoEdge1";
            this.rdoEdge1.Size = new System.Drawing.Size(121, 16);
            this.rdoEdge1.TabIndex = 0;
            this.rdoEdge1.TabStop = true;
            this.rdoEdge1.Text = "리치골드(1.000원)";
            this.rdoEdge1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cBoxTop2);
            this.groupBox2.Controls.Add(this.cBoxTop3);
            this.groupBox2.Controls.Add(this.cBoxTop1);
            this.groupBox2.Location = new System.Drawing.Point(3, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 93);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "토핑";
            // 
            // cBoxTop1
            // 
            this.cBoxTop1.AutoSize = true;
            this.cBoxTop1.Location = new System.Drawing.Point(9, 20);
            this.cBoxTop1.Name = "cBoxTop1";
            this.cBoxTop1.Size = new System.Drawing.Size(126, 16);
            this.cBoxTop1.TabIndex = 0;
            this.cBoxTop1.Text = "쏘세지(1EA 500원)";
            this.cBoxTop1.UseVisualStyleBackColor = true;
            this.cBoxTop1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cBoxTop3
            // 
            this.cBoxTop3.AutoSize = true;
            this.cBoxTop3.Location = new System.Drawing.Point(9, 64);
            this.cBoxTop3.Name = "cBoxTop3";
            this.cBoxTop3.Size = new System.Drawing.Size(114, 16);
            this.cBoxTop3.TabIndex = 1;
            this.cBoxTop3.Text = "치즈(1EA 300원)";
            this.cBoxTop3.UseVisualStyleBackColor = true;
            this.cBoxTop3.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cBoxTop2
            // 
            this.cBoxTop2.AutoSize = true;
            this.cBoxTop2.Location = new System.Drawing.Point(9, 42);
            this.cBoxTop2.Name = "cBoxTop2";
            this.cBoxTop2.Size = new System.Drawing.Size(114, 16);
            this.cBoxTop2.TabIndex = 2;
            this.cBoxTop2.Text = "감자(1EA 200원)";
            this.cBoxTop2.UseVisualStyleBackColor = true;
            this.cBoxTop2.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "개";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(229, 63);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(32, 21);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "주문하기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lBoxOrder
            // 
            this.lBoxOrder.FormattingEnabled = true;
            this.lBoxOrder.ItemHeight = 12;
            this.lBoxOrder.Location = new System.Drawing.Point(12, 265);
            this.lBoxOrder.Name = "lBoxOrder";
            this.lBoxOrder.Size = new System.Drawing.Size(400, 172);
            this.lBoxOrder.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.lBoxOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GropBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GropBox1.ResumeLayout(false);
            this.GropBox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GropBox1;
        private System.Windows.Forms.RadioButton rdoDow2;
        private System.Windows.Forms.RadioButton rdoDow1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoEdge2;
        private System.Windows.Forms.RadioButton rdoEdge1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cBoxTop2;
        private System.Windows.Forms.CheckBox cBoxTop3;
        private System.Windows.Forms.CheckBox cBoxTop1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lBoxOrder;
    }
}

