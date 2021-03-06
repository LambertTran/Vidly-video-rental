﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Birthday { get; set; }

        public bool IsSubscribedToNewLetter { get; set; }

        [Required]
        public MembershipType MembershipType { get; set; }

        [Required]
        [Display(Name= "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}