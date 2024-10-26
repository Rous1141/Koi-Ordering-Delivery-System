﻿
using System;
using KDOS_Web_API.Models.Domains;
using System.ComponentModel.DataAnnotations;

namespace KDOS_Web_API.Models.DTOs
{
	public class AddNewFishProfileDTO
	{
        [Required]
        required public float Weight { get; set; }
        [Required] 
        public string Name { get; set; }
        [Required]
        required public string Gender { get; set; }
        [Required]
        required public string Notes { get; set; }
        [Required]
        required public string Image { get; set; }
        [Required]
        public int KoiFishId { get; set; }
        [Required]
        public int CustomerId { get; set; }
    }
}

