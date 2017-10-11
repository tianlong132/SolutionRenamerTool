using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameProjectTool
{
    public partial class SolutionRenameTool : Form
    {
        public SolutionRenameTool()
        {
            InitializeComponent();
        }
        private void tb_ProjectPath_MouseDown(object sender, MouseEventArgs e)
        {
            projectFolderBrowserDialog = new FolderBrowserDialog();
            projectFolderBrowserDialog.ShowDialog();
            this.tb_ProjectPath.Text = projectFolderBrowserDialog.SelectedPath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string projectPath = this.tb_ProjectPath.Text;

            if (string.IsNullOrEmpty(projectPath))
            {
                MessageBox.Show("ProjectPath can't be empty!");
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(projectPath);

            //Check the path contains .sln file.
            if (directoryInfo.GetFiles().Where(fileInfo => fileInfo.Extension == ".sln").Count() == 0)
            {
                if (MessageBox.Show("The projectPath can't find .sln file,please make sure is that project path？", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            var oldCompanyName = this.tb_OldCompanyName.Text;
            var oldProjectName = this.tb_OldProjectName.Text;
            var newCompanyName = this.tb_NewCompanyName.Text;
            var newProjectName = this.tb_NewProjectName.Text;

            if (string.IsNullOrEmpty(oldProjectName) || string.IsNullOrEmpty(newProjectName))
            {
                MessageBox.Show("OldProjectName or NewProjectName can't be empty!");
                return;
            }

            if (MessageBox.Show("This operation can not be resumed,please sure you want do that？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RenameProjectHelper.RenameProject(projectPath, oldCompanyName, oldProjectName, newCompanyName, newProjectName);
            }

            MessageBox.Show("Done!!!");
        }
    }
}
