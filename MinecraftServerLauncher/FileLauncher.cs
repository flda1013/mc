using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftServerLauncher
{
    class FileLauncher
    {

        String path = AppDomain.CurrentDomain.BaseDirectory;
        String ConfigFileName = "LauncherConfig.txt";
        String fullPath = null;
        public FileLauncher()
        {
            fullPath = System.IO.Path.Combine(path, ConfigFileName);
        }



        public bool fileCheck(String test)
        {
            if (String.IsNullOrEmpty(test) || String.IsNullOrWhiteSpace(test))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void writeInConfigFile(String minRam, String maxRam,string JarFile)
        {
            string[] contents = new string[3];
            contents[0] = minRam;
            contents[1] = maxRam;
            contents[2] = JarFile;
            System.IO.File.WriteAllLines(fullPath, contents);
        }

        public string[] readConfigFile()
        {
            if(File.Exists(fullPath))
            {
                string[] lines = System.IO.File.ReadAllLines(fullPath);
                return lines;
            }
            else
            {
                return null;
            }
        }

        public string[] loadConfig()
        {
            if (File.Exists(fullPath))
            {
               string[] lines = System.IO.File.ReadAllLines(fullPath);
                return lines;
            }
            else
            {
                return null;
            }
        }

    }
}
