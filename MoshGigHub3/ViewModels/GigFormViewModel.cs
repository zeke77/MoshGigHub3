﻿using MoshGigHub3.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace MoshGigHub3.ViewModels
{
    public class GigFormViewModel
    {
        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate(ErrorMessage = "Date must be in the future!")]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Genre { get; set; }

       
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime GetDateTime()
        {
           return DateTime.Parse(string.Format("{0} {1}", Date, Time)); }
        }
}