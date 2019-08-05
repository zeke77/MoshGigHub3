﻿using MoshGigHub3.Models;
using System.Collections.Generic;

namespace MoshGigHub3.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }

       
        public IEnumerable<Genre> Genres { get; set; }
    }
}