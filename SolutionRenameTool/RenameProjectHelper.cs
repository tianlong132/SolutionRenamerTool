using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Configuration;

namespace RenameProjectTool
{
    class RenameProjectHelper
    {
        public static void RenameProject(string projectPath, string oldCompanyName, string oldProjectName, string newCompanyName, string newProjectName)
        {
            string renameFileExtensions = ConfigurationManager.AppSettings["renameFileExtensions"];
            string[] filter = renameFileExtensions.Split(',');

            RenameDirectories(projectPath, oldCompanyName, oldProjectName, newCompanyName, newProjectName);
            RenameFiles(projectPath, oldCompanyName, oldProjectName, newCompanyName, newProjectName, filter);
        }

        /// <summary>
        /// 递归重命名所有目录
        /// </summary>
        private static void RenameDirectories(string path, string oldCompanyName, string oldProjectName, string newCompanyName, string newProjectName)
        {
            string[] paths = Directory.GetDirectories(path);

            foreach (var tempPath in paths)
            {
                RenameDirectories(tempPath, oldCompanyName, oldProjectName, newCompanyName, newProjectName);

                DirectoryInfo directoryInfo = new DirectoryInfo(tempPath);

                if (directoryInfo.Name.Contains(oldCompanyName) || directoryInfo.Name.Contains(oldProjectName))
                {
                    var newName = directoryInfo.Name;

                    if (!string.IsNullOrEmpty(oldCompanyName))
                    {
                        newName = newName.Replace(oldCompanyName, newCompanyName);
                    }
                    newName = newName.Replace(oldProjectName, newProjectName);

                    var newPath = Path.Combine(directoryInfo.Parent.FullName, newName);

                    if (directoryInfo.FullName != newPath)
                    {
                        directoryInfo.MoveTo(newPath);
                    }
                }
            }
        }

        /// <summary>
        /// 重命名所有文件
        /// </summary>
        private static void RenameFiles(string rootDir, string oldCompanyName, string oldProjectName, string newCompanyName, string newProjectName, string[] filter)
        {
            //获取当前目录所有指定文件扩展名的文件
            List<FileInfo> files = new DirectoryInfo(rootDir).GetFiles()
                                        .Where(m => filter.Any(f => f == m.Extension)).ToList();

            //重命名当前目录文件和文件内容
            foreach (var file in files)
            {
                var text = File.ReadAllText(file.FullName, Encoding.UTF8);
                if (!string.IsNullOrEmpty(oldCompanyName))
                {
                    text = text.Replace(oldCompanyName, newCompanyName);
                }

                text = text.Replace(oldProjectName, newProjectName);
                if (file.Name.Contains(oldCompanyName) || file.Name.Contains(oldProjectName))
                {
                    var newName = file.Name;

                    if (!string.IsNullOrEmpty(oldCompanyName))
                    {
                        newName = newName.Replace(oldCompanyName, newCompanyName);
                    }
                    newName = newName.Replace(oldProjectName, newProjectName);
                    var newFullName = Path.Combine(file.DirectoryName, newName);
                    File.WriteAllText(newFullName, text, Encoding.UTF8);
                    if (newFullName != file.FullName)
                    {
                        File.Delete(file.FullName);
                    }
                }
                else
                {
                    File.WriteAllText(file.FullName, text, Encoding.UTF8);
                }
            }

            //获取子目录
            string[] dirs = Directory.GetDirectories(rootDir);

            foreach (var dir in dirs)
            {
                RenameFiles(dir, oldCompanyName, oldProjectName, newCompanyName, newProjectName, filter);
            }
        }
    }
}