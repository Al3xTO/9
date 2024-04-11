namespace ComposeLab
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Колеса Тип1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Колеса Тип2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Колеса Тип3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Колеса", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Кузов Тип1");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Кузов Тип2");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Кузов Тип3");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Кузов", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Окна Тип1");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Окна Тип2");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Окна Тип3");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Окна", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_ComposeCar = new System.Windows.Forms.Button();
            this.btn_DecompCar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Колеса Тип1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Колеса Тип2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Колеса Тип3";
            treeNode4.Name = "nWheel";
            treeNode4.Text = "Колеса";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Кузов Тип1";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Кузов Тип2";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Кузов Тип3";
            treeNode8.Name = "nBody";
            treeNode8.Text = "Кузов";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Окна Тип1";
            treeNode10.Name = "Node12";
            treeNode10.Text = "Окна Тип2";
            treeNode11.Name = "Node11";
            treeNode11.Text = "Окна Тип3";
            treeNode12.Name = "nWindow";
            treeNode12.Text = "Окна";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(170, 158);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.BeforeCheck);
            // 
            // btn_ComposeCar
            // 
            this.btn_ComposeCar.Location = new System.Drawing.Point(12, 176);
            this.btn_ComposeCar.Name = "btn_ComposeCar";
            this.btn_ComposeCar.Size = new System.Drawing.Size(131, 23);
            this.btn_ComposeCar.TabIndex = 1;
            this.btn_ComposeCar.Text = "Зібрати карету";
            this.btn_ComposeCar.UseVisualStyleBackColor = true;
            this.btn_ComposeCar.Click += new System.EventHandler(this.btn_CompCarClick);
            // 
            // btn_DecompCar
            // 
            this.btn_DecompCar.Location = new System.Drawing.Point(211, 176);
            this.btn_DecompCar.Name = "btn_DecompCar";
            this.btn_DecompCar.Size = new System.Drawing.Size(131, 23);
            this.btn_DecompCar.TabIndex = 2;
            this.btn_DecompCar.Text = "Разобрати карету";
            this.btn_DecompCar.UseVisualStyleBackColor = true;
            this.btn_DecompCar.Click += new System.EventHandler(this.btnDecompCar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 158);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 217);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_DecompCar);
            this.Controls.Add(this.btn_ComposeCar);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_ComposeCar;
        private System.Windows.Forms.Button btn_DecompCar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

