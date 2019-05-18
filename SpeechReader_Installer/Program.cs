using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;

namespace SpeechReader_Installer
{
    class Program
    {
        static string program = "SpeechReader";
        static string name = WindowsIdentity.GetCurrent().Name
            .Substring(WindowsIdentity.GetCurrent().Name.IndexOf("\\")).Replace("\\", "");
        static string basePath = AppDomain.CurrentDomain.BaseDirectory;
        static string rootPath = "C:\\Users\\" + name + "\\Documents";
        static string destPath = rootPath + "\\" + program;
        static bool IsRunning = false;
        static void Main(string[] args)
        {

            Console.WriteLine($"[ {program} ]");

            Console.WriteLine("Bem-vindo Caro. " +  name + ", a instalação de Speech Reader.");

            Console.WriteLine("Nota: a aplicação será instalada na pasta de Documentos.");
            Console.Write($"Tens a certeza que pretendes instalar {program} no seu PC? (yes - y || no - n): ");
            var res = Console.ReadKey();

            Console.WriteLine("");

            if (res.KeyChar == 'y')
            {
                Console.WriteLine("Instalação em progresso...");

                DirectoryStructure.GetDirectoryContents(basePath + "bin.set");
                var allfiles = DirectoryStructure.AllFiles.OrderBy(x => x.Id).ToList();
                DirectoryStructure.AllFiles = new System.Collections.Generic.List<DirectoryItem>();
                DirectoryStructure.GetDirectoryContents(basePath + "dependencies");
                var dependencies = DirectoryStructure.AllFiles;

                try
                {

                    if (!Directory.Exists(destPath))
                        Directory.CreateDirectory(destPath);

                    var exe = "";

                    foreach (var f in allfiles)
                    {
                        Console.WriteLine(" Instalando " + f.Name);

                        var target = destPath + f.FullPath.Substring(f.FullPath.IndexOf("bin.set")).Replace("bin.set", "");

                        if (f.Type == DirectoryItemType.Folder)
                        {
                            if (!Directory.Exists(target))
                                Directory.CreateDirectory(target);
                        }
                        else if (f.Type == DirectoryItemType.File) {

                            if (!File.Exists(target))
                            {
                                var ff = File.Create(target);
                                ff.Close();
                            }
                            File.Copy(f.FullPath, target, true);

                            if (new FileInfo(f.FullPath).Extension == ".exe")
                                exe = target;
                        }
                        
                    }

                    Console.WriteLine("Instalando as Dependências: ");
                    foreach (var item in dependencies)
                    {
                        Console.WriteLine(" " + item.Name);
                        InstallDependency(item.FullPath);
                    }

                    Console.WriteLine("Instalação terminada. Obrigado pela paciência ;-) ");

                    Console.Write($"Pretende executa-lo? (yes - y || no - n): ");
                    var r = Console.ReadKey();

                    if (r.KeyChar == 'y')
                    {
                        IsRunning = true;
                        Process.Start(exe);
                        
                    }

                    Console.WriteLine("\nAdeus!");

                }
                catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }

            }
            else if (res.KeyChar == 'n')
            {
                Console.WriteLine("\n :'( Adeus!");
            }
            else
            {

                Console.WriteLine("\nResposta inválida... :'( Adeus!");
            }

            if(!IsRunning)
                Console.ReadKey();

        }

        public static void InstallDependency(string path)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "msiexec.exe";
                p.StartInfo.Arguments = "/i" + path +"/qn";
                p.Start();
                p.WaitForExit();

                Console.WriteLine("Dependência Instalada ");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Algo correu mal, por favor, faça a instalação manualmente." +
                    "\nCaminho: " + path + "\n\nErro: " + ex.Message);
            }
        }

    }
}
