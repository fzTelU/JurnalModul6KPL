﻿using System;

namespace modul6_kelompok_7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataMahasiswa1302204062 faza = new DataMahasiswa1302204062();
            faza.ReadJSON();
            TeamMembers1302204062 team = new TeamMembers1302204062();
            team.ReadJSON();
        }
    }
}