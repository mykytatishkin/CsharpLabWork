using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab2109
{
    public class FIleWordSearch
    {
        public string path3 = @"/Users/mykytatishkin/Projects/Lab2109/Output/WordReplace.txt";

        public void FileWordReplaceing(string replacingWord, string wordToReplace)
        {
            if(File.Exists(path3))
            {
                File.WriteAllText(path3, File.ReadAllText(path3).Replace(wordToReplace, replacingWord));
            }
            else
            {
                string tempText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    "\nLorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. " +
                    "\nIt has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "\nIt was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

                File.Create(path3);

                File.WriteAllText(path3, tempText);



            }
        }
    }
}

