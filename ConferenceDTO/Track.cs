﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConferenceDTO
{
    class Track
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}