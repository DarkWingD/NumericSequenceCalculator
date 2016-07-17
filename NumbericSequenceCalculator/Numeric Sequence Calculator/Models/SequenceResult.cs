﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Numeric_Sequence_Calculator.Models
{
    public class SequenceResult
    {
        public int MagicNumber { get; set; }
        public List<int> AllNumbersUpTo{ get; set; }
        public List<int> OddNumbersUpTo { get; set; }
        public List<int> EvenNumbersUpTo { get; set; }
        public List<string> AllNumbersConditional { get; set; }
        public List<int> FibonacciNumbersUpTo { get; set; }
    }
}