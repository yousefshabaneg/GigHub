﻿using System;
using System.Collections.Generic;
using GigHub.Models;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        
        public string Date { get; set; }
        public string Time { get; set; }
        public DateTime DateTime => DateTime.Parse($"{Date} {Time}");
        
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}