namespace RenameProjectTool
{
    partial class SolutionRenameTool
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ProjectPath = new System.Windows.Forms.TextBox();
            this.tb_OldCompanyName = new System.Windows.Forms.TextBox();
            this.tb_OldProjectName = new System.Windows.Forms.TextBox();
            this.tb_NewCompanyName = new System.Windows.Forms.TextBox();
            this.tb_NewProjectName = new System.Windows.Forms.TextBox();
            this.projectFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 33);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(357, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "OK";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_ProjectPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_OldCompanyName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_OldProjectName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_NewCompanyName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_NewProjectName, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 210);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProjectPath：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "OldCompanyName：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "OldProjectName：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "NewCompanyName：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "NewProjectName：";
            // 
            // tb_ProjectPath
            // 
            this.tb_ProjectPath.AccessibleName = "";
            this.tb_ProjectPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_ProjectPath.Location = new System.Drawing.Point(115, 10);
            this.tb_ProjectPath.Name = "tb_ProjectPath";
            this.tb_ProjectPath.Size = new System.Drawing.Size(317, 21);
            this.tb_ProjectPath.TabIndex = 1;
            this.tb_ProjectPath.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_ProjectPath_MouseDown);
            // 
            // tb_OldCompanyName
            // 
            this.tb_OldCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_OldCompanyName.Location = new System.Drawing.Point(115, 52);
            this.tb_OldCompanyName.Name = "tb_OldCompanyName";
            this.tb_OldCompanyName.Size = new System.Drawing.Size(317, 21);
            this.tb_OldCompanyName.TabIndex = 1;
            // 
            // tb_OldProjectName
            // 
            this.tb_OldProjectName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_OldProjectName.Location = new System.Drawing.Point(115, 94);
            this.tb_OldProjectName.Name = "tb_OldProjectName";
            this.tb_OldProjectName.Size = new System.Drawing.Size(317, 21);
            this.tb_OldProjectName.TabIndex = 1;
            // 
            // tb_NewCompanyName
            // 
            this.tb_NewCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_NewCompanyName.Location = new System.Drawing.Point(115, 136);
            this.tb_NewCompanyName.Name = "tb_NewCompanyName";
            this.tb_NewCompanyName.Size = new System.Drawing.Size(317, 21);
            this.tb_NewCompanyName.TabIndex = 1;
            // 
            // tb_NewProjectName
            // 
            this.tb_NewProjectName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_NewProjectName.Location = new System.Drawing.Point(115, 178);
            this.tb_NewProjectName.Name = "tb_NewProjectName";
            this.tb_NewProjectName.Size = new System.Drawing.Size(317, 21);
            this.tb_NewProjectName.TabIndex = 1;
            // 
            // SolutionRenameTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 243);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SolutionRenameTool";
            this.Text = "SolutionRenameTool";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ProjectPath;
        private System.Windows.Forms.TextBox tb_OldCompanyName;
        private System.Windows.Forms.TextBox tb_OldProjectName;
        private System.Windows.Forms.TextBox tb_NewCompanyName;
        private System.Windows.Forms.TextBox tb_NewProjectName;
        private System.Windows.Forms.FolderBrowserDialog projectFolderBrowserDialog;


    }
}

