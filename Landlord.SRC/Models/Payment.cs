﻿using System;

namespace Landlord.SRC.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateOverdue { get; set; }
        public bool Paid { get; set; }
        public int PropertyId { get; set; }
        public Property Property { get; set; }
    }
}
