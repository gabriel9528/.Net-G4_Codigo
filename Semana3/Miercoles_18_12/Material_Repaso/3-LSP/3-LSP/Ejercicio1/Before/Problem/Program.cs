﻿using LSPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Program
    {   
        static void Main(string[] args)
        {
            Player player = new TennisPlayer();
            player.FirstName = "Gabriel";
            player.LastName = "Retamozo";
            player.AssignTeam(new Team {Name= "Melgar" });
            player.SetCategory(PlayerCategory.Amateur);
            

            Console.Write($"{player.FirstName} {player.LastName} equipo: {player.GetTeam()} categoria:  {player.Category}");
            Console.ReadLine();
        }
    }
}
