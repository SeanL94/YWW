﻿using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Sean Little | n9106201
namespace YWW.core.Models
{
    [Table("goals")]
    public class Goals
    {
        [PrimaryKey, AutoIncrement]
        public int Goalid { get; set; }
        public int GoalCounter { get; set; }
        public int GoalStatus { get; set; }
    }
}
