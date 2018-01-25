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
        public String Name { get; set; }

        public DateTime ? BirthDate { get; set; }

        

        public bool IsSubscribedToNewsLetter { get; set; }

        public int MembershipTypeId { get; set; }

        public virtual MembershipType MembershipType { get; set; }
        
    }
}