using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Список_директорий
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FileInfo> files = ListOfFile();
            List<DirectoryInfo> infos = GetAlbums(files);

            Console.ReadLine();
        }

        public static List<DirectoryInfo> GetAlbums(List<FileInfo> files)
        {
            List<DirectoryInfo> dir = new List<DirectoryInfo>();

            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].Extension == ".mp3")
                {
                    if (dir.Exists(ExistDirect))
                        dir.Add(files[i].Directory);
                }
            }

            return dir;
        }

        private static bool ExistDirect(DirectoryInfo dir)
        {
            //return true;
            return dir.Exists;
        }

        public static List<FileInfo> ListOfFile()
        {
            string pathToDirectory = @"F:\Музыка";
            DirectoryInfo directory = new DirectoryInfo(pathToDirectory);
            FileInfo[] fileInfos = directory.GetFiles("*,*", SearchOption.AllDirectories);

            List<FileInfo> listFile = new List<FileInfo>();

            foreach (FileInfo file in fileInfos)
            {
                listFile.Add(file);
            }


            return listFile;

        }
    }
}
