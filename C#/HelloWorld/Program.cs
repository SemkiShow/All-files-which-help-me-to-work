using System.Diagnostics;
// using System.ComponentModel;
// using System.Collections;
using System.Collections.Generic;
// using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
// using System.Threading;
using System;

namespace HelloWorld
{
    class Program
    {
        static void OpenExplorer(string path)
        {
            string fileToSelect = path;
            string args = string.Format("/Select, \"{0}\"", fileToSelect);
            ProcessStartInfo pfi = new ProcessStartInfo("Explorer.exe", args);
            Process.Start(pfi);
        }
        static void CreateInstaller(string text,string name)
        {
            FileStream file = File.Create("C:/Users/" + Environment.UserName + "/Desktop/" + name + ".txt"); 
            byte[] array = System.Text.Encoding.Default.GetBytes(text);
            file.Write(array, 0, array.Length);
            file.Close();
            Path.ChangeExtension("C:/Users/" + Environment.UserName + "/Desktop/" + name + ".txt",".exe");
        }
        static void Main()
        {
            // Console.WriteLine("\nWhat is your name?");
            // string name = Console.ReadLine();
            string SV13="";
            string OBS="";
            string VSCode="";
            string UnityHub="";
            string Google="";
            string Discord="";
            string Program="";
            string DotNet="";
            string name=@"Semki Show";
            DateTime date = DateTime.Now;
            Console.WriteLine("\nЗдравствуй, " + name + "! Дата: " + date.ToString("MM/dd/yyyy") + "! Время: " + date.ToString("HH:mm") + "!");
            while (true)
            {
                Console.WriteLine("\nМеню\n1.Открыть программу\n2.Помощник по математике\n3.Установка программ\n4.Выйти");
                string answer = Console.ReadLine();
                if (answer=="1")
                {
                    Console.WriteLine("\nОткрыть программу\n1.Видео\n2.Unity\n3.Кодиум\n4.Sony Vegas 13\n5.OBS\n6.VS Code\n7.Unity Hub\n8.Google\n9.Discord\n10.Program.exe - Проводник\n11.Program.exe\n12.В главное меню");
                    answer = Console.ReadLine();
                    if (answer=="1")
                    {
                        OpenExplorer(@"D:\Жоржик\vids\смонтированные");
                        OpenExplorer(@"D:\Жоржик\vids\смонтированные");
                        Process.Start(@"D:\Program Files\sony vegas pro 13\vegas130.exe");
                        Process.Start(@"D:\Program Files\obs-studio\bin\64bit\obs64.exe");
                    }
                    else if (answer=="2")
                    {
                        Process.Start(@"D:\Program Files\Unity Hub\Unity Hub.exe");
                        Process.Start(@"D:\Жоржик\VSCode-win32-x64-1.53.2\Code.exe");
                        Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
                    }
                    else if (answer=="3")
                    {
                        Process.Start(@"D:\Program Files\Unity Hub\Unity Hub.exe");
                        Process.Start(@"D:\Жоржик\VSCode-win32-x64-1.53.2\Code.exe");
                        Process.Start(@"C:\Users\medwed\AppData\Local\Discord\app-0.0.309\Discord.exe");
                    }
                    else if (answer=="4")
                    {
                        Process.Start(@"D:\Program Files\sony vegas pro 13\vegas130.exe");
                    }
                    else if (answer=="5")
                    {
                        Process.Start(@"D:\Program Files\obs-studio\bin\64bit\obs64.exe");
                    }
                    else if (answer=="6")
                    {
                        Process.Start(@"D:\Жоржик\VSCode-win32-x64-1.53.2\Code.exe");
                    }
                    else if (answer=="7")
                    {
                        Process.Start(@"D:\Program Files\Unity Hub\Unity Hub.exe");
                    }
                    else if (answer=="8")
                    {
                        Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
                    }
                    else if (answer=="9")
                    {
                        Process.Start(@"C:\Users\medwed\AppData\Local\Discord\app-0.0.309\Discord.exe");
                    }
                    if (answer=="10")
                    {
                        OpenExplorer(@"C:\Users\medwed\Desktop\HelloWorld\Program.exe");
                    }
                    if (answer=="11")
                    {
                        Process.Start(@"C:\Users\medwed\Desktop\HelloWorld\Program.exe");
                    }
                    else if (answer=="12")
                    {
                        Main();
                        break;
                    }
                }
                else if (answer=="2")
                {
                    Console.WriteLine("\nПомощник по математике\n1.Число кратное х, оканчивающееся на y\n2.Есть несколько чисел, расставьте между некоторыми знаки, чтобы получилось число х\n3.\n4.В главное меню");
                    answer = Console.ReadLine();
                    if (answer=="1")
                    {
                        int x;
                        string y;
                        bool isNotBreak;
                        int interation;
                        Console.WriteLine("Введите x");
                        x=Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Введите y");
                        y=Console.ReadLine();
                        isNotBreak=true;
                        interation=1;
                        while (isNotBreak)
                        {
                            if(Convert.ToString(x*interation).EndsWith(y))
                            {
                                Console.WriteLine("Это число "+Convert.ToString(x*interation));
                                isNotBreak=false;
                                Main();
                            }
                            else
                            {
                                Console.WriteLine(Convert.ToString(x*interation));
                                interation++;
                            }
                        }
                    }
                    else if (answer=="2")
                    {
                        Console.WriteLine("Введите числа через пробел");
                        string numbers=Console.ReadLine();
                        Console.WriteLine("Введите используемые знаки(+,-,*,/)");
                        string operators=Console.ReadLine();
                        Console.WriteLine("Введите х");
                        int x=Convert.ToInt16(Console.ReadLine());
                        string[] numbs=numbers.Split(new char[] {' '});
                        string[] opers=operators.Split(new char[] {' '});
                        List<int> operatorLocation = new List<int>();
                        bool isNotBreak=true;
                        int i=0;
                        while (isNotBreak)
                        {
                            operatorLocation.Add(i+1);
                            operatorLocation.Add(i+10);
                            i+=10;
                            if (Convert.ToString(i).Length>numbs.Length)
                            {
                                break;
                            }
                        }
                    }
                    else if (answer=="3")
                    {
                        Main();
                        break;
                    }
                    else if (answer=="4")
                    {
                        Main();
                        break;
                    }
                }
                if (answer=="1")
                {
                    Console.WriteLine("\nУстановка программ\n1.Sony Vegas 13\n2.OBS\n3.VS Code\n4.Unity Hub\n5.Google\n6.Discord\n7.Program.exe\n8.В главное меню");
                    answer = Console.ReadLine();
                    if (answer=="1")
                    {
                        CreateInstaller(SV13,"Sony Vegas 13 Installer");
                    }
                    else if (answer=="2")
                    {
                        CreateInstaller(OBS,"OBS Installer");
                    }
                    else if (answer=="3")
                    {
                        CreateInstaller(VSCode,"Visual Studio Code Installer");
                    }
                    else if (answer=="4")
                    {
                        CreateInstaller(UnityHub,"Unity Hub Installer");
                    }
                    else if (answer=="5")
                    {
                        CreateInstaller(Google,"Chrome Installer");
                    }
                    else if (answer=="6")
                    {
                        CreateInstaller(Discord,"Discord Installer");
                    }
                    else if (answer=="7")
                    {
                        CreateInstaller(Program,"Program");
                    }
                    else if (answer=="7")
                    {
                        CreateInstaller(DotNet,".Net Installer");
                    }
                    else if (answer=="9")
                    {
                        Main();
                        break;
                    }
                }
                else if (answer=="4")
                {
                    Console.Write("\nНажмите любую клавишу, чтобы выйти...");
                    Console.ReadKey(true);
                    break;
                }
            }
        }
    }
}

// for run:
// dotnet run

// for compile:
// C:\Windows\Microsoft.NET\Framework\v2.0.50727\csc.exe /t:exe Program.cs
