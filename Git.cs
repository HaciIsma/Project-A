using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Can_I_do
{
    static class Git
    {
        private static string GenerateString(int length = 25)
        {
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }
        static public void GitPush()
        {
            string commit = "\'" + GenerateString() + "\'";
            string remoteControl = "https://github.com/HaciIsma/Can-I-do-.git";
            string path = $@"{Directory.GetCurrentDirectory()}\Files";
            string command = $"cd {path}; git init;git add .; git commit -m {commit};git remote add origin {remoteControl} ;git push -u origin master;";


            #region CMD
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine(command);
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            //Console.WriteLine(process.StandardOutput.ReadToEnd());
            #endregion



            #region PowerShell

            //Process process = new Process();
            //string destination = "Powershell.exe";
            //Console.Write("Enter commit: ");
            //commit = Console.ReadLine();
            //commit = "\'" + commit + "\'";
            //process.StartInfo = new ProcessStartInfo(destination, command);
            //process.Start();
            #endregion
        }
    }
}
