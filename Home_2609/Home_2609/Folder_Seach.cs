using System;
using static System.Console;
namespace Home_2609
{
    public class Folder_Seach
    {
        // К сожалению у меня 1 диск и я на маке, так что не могу указать директорию которая была данна в задании.
        protected string pathFolder = $"/Users/mykytatishkin/Projects/Home_2609/Folder_Search/";
        protected string pathFilter;

        public Folder_Seach(string pathFilter)
        {
            this.pathFilter = pathFilter;
        }

        public void FileSearchInMainDirectory()
        {
            string[] files = Directory.GetFiles(pathFolder, pathFilter);
            foreach(var file in files)
                WriteLine(file);
        }
        public void FileSearchInNotMainDirectory()
        {
            string[] directories = Directory.GetDirectories(pathFolder, pathFilter);
            for(int i = 0; i < directories.Length; i++)
            {
                string[] files = Directory.GetFiles(pathFolder + directories[i], pathFilter);
                foreach(var file in files)
                    WriteLine(file);
            }
        }
        public void FileDeletingInMainDirectory()
        {
            string[] files = Directory.GetFiles(pathFolder, pathFilter);
            foreach (var file in files)
                File.Delete(file);
        }
        public void FileDeletingInNotMainDirectory()
        {
            string[] directories = Directory.GetDirectories(pathFolder, pathFilter);
            for (int i = 0; i < directories.Length; i++)
            {
                string[] files = Directory.GetFiles(pathFolder + directories[i], pathFilter);
                foreach (var file in files)
                    File.Delete(file);
            }
        }
        public void FileDeletingInNotMainDirectoryOfDirectory()
        {
            string[] directories = Directory.GetDirectories(pathFolder, pathFilter);
            for (int i = 0; i < directories.Length; i++)
            {
                string[] directories2 = Directory.GetFiles(pathFolder + directories[i], pathFilter);
                for(int j = 0; j < directories2.Length; j++)
                {
                    string[] files = Directory.GetFiles(pathFolder + directories2[i], pathFilter);
                    foreach (var file in files)
                        File.Delete(file);
                }
            }
        }
        public void task_6()
        {
            string[] files = Directory.GetFiles(pathFolder, pathFilter);
            string[] directories = Directory.GetDirectories(pathFolder, pathFilter);
            foreach (var file in files)
                WriteLine(file);

            foreach (var dir in directories)
                WriteLine(dir);
        }
    }
}

