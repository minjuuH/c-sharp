namespace PictureBox_Animation
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.picChoice3 = new System.Windows.Forms.PictureBox();
            this.picChoice4 = new System.Windows.Forms.PictureBox();
            this.picChoice5 = new System.Windows.Forms.PictureBox();
            this.picChoice6 = new System.Windows.Forms.PictureBox();
            this.picChoice7 = new System.Windows.Forms.PictureBox();
            this.picChoice0 = new System.Windows.Forms.PictureBox();
            this.picChoice2 = new System.Windows.Forms.PictureBox();
            this.picChoice1 = new System.Windows.Forms.PictureBox();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timAnimation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picChoice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start/Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picChoice3
            // 
            this.picChoice3.Image = global::PictureBox_Animation.Properties.Resources.frame_4;
            this.picChoice3.Location = new System.Drawing.Point(370, 330);
            this.picChoice3.Name = "picChoice3";
            this.picChoice3.Size = new System.Drawing.Size(103, 85);
            this.picChoice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice3.TabIndex = 17;
            this.picChoice3.TabStop = false;
            this.picChoice3.Visible = false;
            // 
            // picChoice4
            // 
            this.picChoice4.Image = global::PictureBox_Animation.Properties.Resources.frame_5;
            this.picChoice4.Location = new System.Drawing.Point(479, 330);
            this.picChoice4.Name = "picChoice4";
            this.picChoice4.Size = new System.Drawing.Size(103, 85);
            this.picChoice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice4.TabIndex = 16;
            this.picChoice4.TabStop = false;
            this.picChoice4.Visible = false;
            // 
            // picChoice5
            // 
            this.picChoice5.Image = global::PictureBox_Animation.Properties.Resources.frame_6;
            this.picChoice5.Location = new System.Drawing.Point(588, 330);
            this.picChoice5.Name = "picChoice5";
            this.picChoice5.Size = new System.Drawing.Size(103, 85);
            this.picChoice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice5.TabIndex = 15;
            this.picChoice5.TabStop = false;
            this.picChoice5.Visible = false;
            // 
            // picChoice6
            // 
            this.picChoice6.Image = global::PictureBox_Animation.Properties.Resources.frame_7;
            this.picChoice6.Location = new System.Drawing.Point(697, 330);
            this.picChoice6.Name = "picChoice6";
            this.picChoice6.Size = new System.Drawing.Size(103, 85);
            this.picChoice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice6.TabIndex = 14;
            this.picChoice6.TabStop = false;
            this.picChoice6.Visible = false;
            // 
            // picChoice7
            // 
            this.picChoice7.Image = global::PictureBox_Animation.Properties.Resources.frame_8;
            this.picChoice7.Location = new System.Drawing.Point(806, 330);
            this.picChoice7.Name = "picChoice7";
            this.picChoice7.Size = new System.Drawing.Size(103, 85);
            this.picChoice7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice7.TabIndex = 13;
            this.picChoice7.TabStop = false;
            this.picChoice7.Visible = false;
            // 
            // picChoice0
            // 
            this.picChoice0.Image = global::PictureBox_Animation.Properties.Resources.frame_1;
            this.picChoice0.Location = new System.Drawing.Point(43, 330);
            this.picChoice0.Name = "picChoice0";
            this.picChoice0.Size = new System.Drawing.Size(103, 85);
            this.picChoice0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice0.TabIndex = 12;
            this.picChoice0.TabStop = false;
            this.picChoice0.Visible = false;
            // 
            // picChoice2
            // 
            this.picChoice2.Image = global::PictureBox_Animation.Properties.Resources.frame_3;
            this.picChoice2.Location = new System.Drawing.Point(261, 330);
            this.picChoice2.Name = "picChoice2";
            this.picChoice2.Size = new System.Drawing.Size(103, 85);
            this.picChoice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice2.TabIndex = 11;
            this.picChoice2.TabStop = false;
            this.picChoice2.Visible = false;
            // 
            // picChoice1
            // 
            this.picChoice1.Image = global::PictureBox_Animation.Properties.Resources.frame_2;
            this.picChoice1.Location = new System.Drawing.Point(152, 330);
            this.picChoice1.Name = "picChoice1";
            this.picChoice1.Size = new System.Drawing.Size(103, 85);
            this.picChoice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice1.TabIndex = 1;
            this.picChoice1.TabStop = false;
            this.picChoice1.Visible = false;
            // 
            // picDisplay
            // 
            this.picDisplay.Image = global::PictureBox_Animation.Properties.Resources.frame_1;
            this.picDisplay.Location = new System.Drawing.Point(360, 44);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(219, 201);
            this.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // timAnimation
            // 
            this.timAnimation.Tick += new System.EventHandler(this.timAnimation_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.picChoice3);
            this.Controls.Add(this.picChoice4);
            this.Controls.Add(this.picChoice5);
            this.Controls.Add(this.picChoice6);
            this.Controls.Add(this.picChoice7);
            this.Controls.Add(this.picChoice0);
            this.Controls.Add(this.picChoice2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picChoice1);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picChoice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.PictureBox picChoice1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picChoice2;
        private System.Windows.Forms.PictureBox picChoice0;
        private System.Windows.Forms.PictureBox picChoice7;
        private System.Windows.Forms.PictureBox picChoice6;
        private System.Windows.Forms.PictureBox picChoice5;
        private System.Windows.Forms.PictureBox picChoice4;
        private System.Windows.Forms.PictureBox picChoice3;
        private System.Windows.Forms.Timer timAnimation;
    }
}

