﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel
{
    public class Hotel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get;
            set;
        }
        [StringLength(50)]
        public string Name
        {
            get;
            set;
        }
        [StringLength(50)]
        public string City
        {
            get;
            set;
        }
    }
}
