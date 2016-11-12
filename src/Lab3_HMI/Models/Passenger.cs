﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3_HMI.Models
{
    public class Passenger
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Телефон")]
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual Flight Flight { get; set; }

        public virtual List<Baggage> Baggage { get; set; }
    }
}