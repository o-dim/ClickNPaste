namespace ClicknPaste
{
    partial class ClicknPaste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClicknPaste));
            this.label1 = new System.Windows.Forms.Label();
            this.savingText = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "안뇽 !! ";
            // 
            // savingText
            // 
            this.savingText.Location = new System.Drawing.Point(31, 61);
            this.savingText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savingText.Name = "savingText";
            this.savingText.Size = new System.Drawing.Size(349, 25);
            this.savingText.TabIndex = 4;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(262, 188);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(54, 61);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(322, 146);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(70, 102);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Enter";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(27, 142);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(95, 44);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "···";
            this.btn1.UseVisualStyleBackColor = true;
            //this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(147, 142);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(95, 44);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "궁.";
            this.btn2.UseVisualStyleBackColor = true;
            //this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(27, 205);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(95, 44);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "나는 지나";
            this.btn3.UseVisualStyleBackColor = true;
            //this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(147, 205);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(95, 44);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "동글동글";
            this.btn4.UseVisualStyleBackColor = true;
            //this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // ClicknPaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClicknPaste.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 274);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.savingText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.saveBtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClicknPaste";
            this.Text = "٩꒰๑ ´∇`๑꒱۶";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox savingText;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
    }
}

