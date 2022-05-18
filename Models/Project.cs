﻿using System.ComponentModel.DataAnnotations;

namespace DotNetCorePortfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
    }
}
