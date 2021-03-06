﻿using System;
using System.Reflection;

namespace K33P3R
{
    class Login
    {
        Core core = new Core();
        Updater updater = new Updater();

        public void Main()
        {
            string _version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Console.Clear();
            Console.Title = "Password K&S - Login";

            Console.WriteLine("┌────────────────────────────────────────────────────┐");
            Console.WriteLine("│ << Keep & Secure by xGabbro & Aspired v." + _version + " >> │");
            Console.WriteLine("└────────────────────────────────────────────────────┘" + "\n");

            Console.Write("Inserisci la password per accedere: ");
            string _pass = Console.ReadLine(); 

            if (_pass == Properties.Settings.Default.LoginPassword) core.Main();
            else if (_pass == "" || _pass == null) Console.WriteLine("\n" + "Errore! Inserire una password!");
            else Console.WriteLine("\n" + "ERRORE! Password errata!");      

            Console.ReadKey();
            Main();
        }


    }
}
