namespace ch11_02
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("베토벤", 1, 1);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("슈베르트", 1, 1);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("모차르트", 1, 1);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("클래식", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Britney Spears", 1, 1);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Mariah Carey", 1, 1);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Carpenters", 1, 1);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("팝", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("이승환", 1, 1);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("전인권", 1, 1);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("이효리", 1, 1);
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("가요", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(60, 46);
            this.treeView1.Name = "treeView1";
            treeNode13.ImageIndex = 1;
            treeNode13.Name = "노드1";
            treeNode13.SelectedImageIndex = 1;
            treeNode13.Text = "베토벤";
            treeNode14.ImageIndex = 1;
            treeNode14.Name = "노드2";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "슈베르트";
            treeNode15.ImageIndex = 1;
            treeNode15.Name = "노드3";
            treeNode15.SelectedImageIndex = 1;
            treeNode15.Text = "모차르트";
            treeNode16.ImageIndex = 0;
            treeNode16.Name = "노드0";
            treeNode16.SelectedImageIndex = 0;
            treeNode16.Text = "클래식";
            treeNode17.ImageIndex = 1;
            treeNode17.Name = "노드5";
            treeNode17.SelectedImageIndex = 1;
            treeNode17.Text = "Britney Spears";
            treeNode18.ImageIndex = 1;
            treeNode18.Name = "노드6";
            treeNode18.SelectedImageIndex = 1;
            treeNode18.Text = "Mariah Carey";
            treeNode19.ImageIndex = 1;
            treeNode19.Name = "노드7";
            treeNode19.SelectedImageIndex = 1;
            treeNode19.Text = "Carpenters";
            treeNode20.ImageIndex = 0;
            treeNode20.Name = "노드4";
            treeNode20.SelectedImageIndex = 0;
            treeNode20.Text = "팝";
            treeNode21.ImageIndex = 1;
            treeNode21.Name = "노드9";
            treeNode21.SelectedImageIndex = 1;
            treeNode21.Text = "이승환";
            treeNode22.ImageIndex = 1;
            treeNode22.Name = "노드10";
            treeNode22.SelectedImageIndex = 1;
            treeNode22.Text = "전인권";
            treeNode23.ImageIndex = 1;
            treeNode23.Name = "노드11";
            treeNode23.SelectedImageIndex = 1;
            treeNode23.Text = "이효리";
            treeNode24.ImageIndex = 0;
            treeNode24.Name = "노드8";
            treeNode24.SelectedImageIndex = 0;
            treeNode24.Text = "가요";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode20,
            treeNode24});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(448, 237);
            this.treeView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 28);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "노드 추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "노드 삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "cd.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "TreeViewApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

