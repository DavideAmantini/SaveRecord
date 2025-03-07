﻿using System;
using Amantini.Davide._4H.SaveRecord.Models;

namespace Amantini.Davide._4H.SaveRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SaveRecord - 2021 - amantinidavide@gmail.com");
            
            // 1)
            // Leggere un file CSV con i comuni etrasformarlo in una list<Comune>
            Comuni c = new Comuni( "Comuni.csv" );
            Console.WriteLine($"Ho letto {c.Count} righe...");

            // 2)
            // Scrivere la List<Comune> in un file binario
            c.Save();

            // 3)
            // Rileggere il file binario i una List<Comune>
            c.Load();
            Console.WriteLine($"Ho letto {c.Count} righe dal file binario...");
        }
    }
}