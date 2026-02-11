using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierDuPereNoel
{
    internal class Lutin 
    {
        private readonly string _nom;
        public Lutin(string nom)
        {
            _nom = nom;
        }
        public void RecevoirNotification(string message)
        {
            Console.WriteLine($" {_nom} reçoit : {message}");
        }

       
    }
}
