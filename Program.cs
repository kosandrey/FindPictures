using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FindPic
{
    class FindPicDemo
    {
        public static string SelectedPath;
        private static string _CurrentPath;
        static public List<string> Pictures = new List<string>();

        private static string CurrentPath
        {
            get
            {
                if (_CurrentPath == null) return SelectedPath;
                else return _CurrentPath;            
            }
            set
            {
                _CurrentPath = value;
            }
        }       

        public static void SearchIm()
        {
            try
            {
                 DirectoryInfo directory = new DirectoryInfo(CurrentPath);            
                 DirectoryInfo[] Catalogs = directory.GetDirectories();
                 AddPictures(directory);
                 foreach(DirectoryInfo Catalog in Catalogs)
                 {
                     CurrentPath = Catalog.FullName;
                     SearchIm();
                 }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The path is empty");
                return;
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("This Folder doesn't exist");
                return;
            }
        }
        private static void AddPictures(DirectoryInfo directory)
        {
            FileInfo[] Files = directory.GetFiles();
            foreach(FileInfo File in Files)
            {
                if (File.FullName.EndsWith("jpg", StringComparison.CurrentCulture))
                    Pictures.Add(File.FullName);
            }

        }
    }
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
