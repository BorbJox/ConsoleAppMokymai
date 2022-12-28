using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _001_BasicMokymai
{
    internal class AsyncPractice
    {
        public static void Run()
        {
            Task<string> fetchTask = LoadDataFromUrlAsync("http://isjonahhillfat.com/");

            string content = fetchTask.Result;
            string match = Regex.Match(content, "Current Status: (.+)</").Groups[1].Value;
            Console.WriteLine($"Jonah Hill status: {match}");

        }

        static async Task<string> LoadDataFromUrlAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                string result = await httpClient.GetStringAsync(url);
                sw.Stop();
                Debug.WriteLine($"Fetched in {sw.Elapsed.TotalSeconds} seconds");
                return result;
            }
        }

        public static async Task<string> FryFoodAsync()
        {
            Console.WriteLine("Starting to fry...");
            await Task.Delay(1000);
            Console.WriteLine("Sizzle sizzle...");
            await Task.Delay(1000);
            Console.WriteLine("Sizzzzzle...");
            await Task.Delay(1000);
            Console.WriteLine("Done sizzling!");
            return ("Food");
        }
        public static async Task<string> PourDrinkAsync()
        {
            Console.WriteLine("Grabbing water...");
            await Task.Delay(800);
            Console.WriteLine("Glug glug...");
            await Task.Delay(800);
            Console.WriteLine("Glug...");
            await Task.Delay(800);
            Console.WriteLine("Done pouring!");
            return ("Drink");
        }
    }
}
