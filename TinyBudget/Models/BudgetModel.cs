﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class BudgetModel
    {
        [Key]
        public int id { get; set; }
    }
}