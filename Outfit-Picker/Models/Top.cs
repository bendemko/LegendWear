﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Outfit_Picker.Models
{
    public class Top
    {
        
        public int TopID { get; set; }

        [Required, StringLength(40)]
        public string TopName { get; set; }

        public string PhotoPath { get; set; }

        [Required, StringLength(40)]
        public string Type { get; set; }

        [Required]
        public int ColorID { get; set; }

        [Required]
        public int SeasonID { get; set; }

        [Required]
        public int OccasionID { get; set; }

        //Navigation Properties 
        public virtual Color Color { get; set; }
        public virtual Season Season { get; set; }
        public virtual Occasion Occasion { get; set; }
        //IEnumerable shows you can have multiple Outfits for each top
        public virtual IEnumerable<Outfit>Outfit { get; set; }

    }
}