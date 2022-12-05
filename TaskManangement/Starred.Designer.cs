namespace TaskManangement
{
    partial class Starred
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starred));
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.xuiBtn_AddTask = new XanderUI.XUIButton();
            this.pnlStarred = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.xuiGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.DarkSlateBlue;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Indigo;
            this.xuiGradientPanel1.Controls.Add(this.button2);
            this.xuiGradientPanel1.Controls.Add(this.button1);
            this.xuiGradientPanel1.Controls.Add(this.btn_Add);
            this.xuiGradientPanel1.Controls.Add(this.btn_Home);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(220, 700);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 1;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.Cyan;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Navy;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 80);
            this.button1.TabIndex = 3;
            this.button1.Text = "STARRED";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.AutoSize = true;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.Location = new System.Drawing.Point(0, 300);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(217, 80);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "ADD TASK";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.AutoSize = true;
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(0, 200);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(217, 80);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "HOME";
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // xuiBtn_AddTask
            // 
            this.xuiBtn_AddTask.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiBtn_AddTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xuiBtn_AddTask.BackgroundImage")));
            this.xuiBtn_AddTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.xuiBtn_AddTask.ButtonImage = null;
            this.xuiBtn_AddTask.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiBtn_AddTask.ButtonText = "ADD TASK";
            this.xuiBtn_AddTask.ClickBackColor = System.Drawing.Color.RoyalBlue;
            this.xuiBtn_AddTask.ClickTextColor = System.Drawing.Color.RoyalBlue;
            this.xuiBtn_AddTask.CornerRadius = 5;
            this.xuiBtn_AddTask.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBtn_AddTask.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBtn_AddTask.HoverBackgroundColor = System.Drawing.Color.RoyalBlue;
            this.xuiBtn_AddTask.HoverTextColor = System.Drawing.Color.Transparent;
            this.xuiBtn_AddTask.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiBtn_AddTask.Location = new System.Drawing.Point(310, 587);
            this.xuiBtn_AddTask.Name = "xuiBtn_AddTask";
            this.xuiBtn_AddTask.Size = new System.Drawing.Size(592, 64);
            this.xuiBtn_AddTask.TabIndex = 4;
            this.xuiBtn_AddTask.TextColor = System.Drawing.Color.RoyalBlue;
            this.xuiBtn_AddTask.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBtn_AddTask.Click += new System.EventHandler(this.xuiBtn_AddTask_Click);
            // 
            // pnlStarred
            // 
            this.pnlStarred.Location = new System.Drawing.Point(236, 120);
            this.pnlStarred.Name = "pnlStarred";
            this.pnlStarred.Size = new System.Drawing.Size(752, 414);
            this.pnlStarred.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "STARRED";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 35);
            this.button2.TabIndex = 5;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Starred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlStarred);
            this.Controls.Add(this.xuiBtn_AddTask);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Starred";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starred";
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Home;
        private XanderUI.XUIButton xuiBtn_AddTask;
        private System.Windows.Forms.Panel pnlStarred;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}