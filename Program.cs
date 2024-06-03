using System;
using System.Collections.Generic;
using Entities;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("en-US");
            
            List<Lesson> list = new List<Lesson>();
            
            Console.Write("Quantas aulas tem o curso? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Dados da {i}ª aula:");
                Console.Write("Conteúdo ou tarefa (c/t)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Título: ");
                string title = Console.ReadLine();
                
                if (option == 'c')
                {
                    Console.Write("URL do vídeo: ");
                    string url = Console.ReadLine();
                    Console.Write("Duração em segundos: ");
                    int seconds = int.Parse(Console.ReadLine());
                    list.Add(new Video(title, url, seconds));
                }
                else
                {
                    Console.Write("Descrição: ");
                    string description = Console.ReadLine();
                    Console.Write("Quantidade de questões: ");
                    int questionCount = int.Parse(Console.ReadLine());
                    list.Add(new Task(title, description, questionCount));
                }
            }
            
            Console.WriteLine();
            int sum = 0;
            foreach (Lesson lesson in list)
            {
                sum += lesson.Duration();
            }
            Console.WriteLine($"DURAÇÃO TOTAL DO CURSO = {sum} segundos");
        }
    }
}