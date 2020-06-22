using System;
using System.IO;
using System.Collections.Generic;
using ExercicioHashIgualdade.Entities; 

namespace ExercicioHashIgualdade
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            string path = @"C:\Users\gerba\Desktop\College\Rebeca Coding\Curso online - Orientado Objetos C#\12- Generics, Set e dictionary\ExercicioHashIgualdade\text.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, instant));
                    }
                    Console.WriteLine("Total users: " + set.Count);

                }


            }catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
