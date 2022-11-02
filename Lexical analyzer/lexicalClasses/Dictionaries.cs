﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexical_analyzer
    {
    internal class Dictionaries
        {
        internal static Dictionary<string, long> one_to_nine = new Dictionary<string, long>()
            {
                {"one",1},{"two",2},{"three",3},{"four",4},{"five",5},{"six",6},{"seven",7},{"eight",8},
                {"nine",9}
            };

        internal static Dictionary<string, long> ten_to_ninteen = new Dictionary<string, long>()
            {
                {"ten",10 },{"eleven",11},{"twelwe",12},{"thirteen",13},{"fourteen",14},{"fifteen",15},{"sixteen",16},{"seventeen",17},{"eighteen",18},
                {"nineteen",19}
            };

        internal static Dictionary<string, long> tens = new Dictionary<string, long>()
            {
                {"twenty",20},{"thirty",30},{"fourty",40},{"fifty",50},{"sixty",60},{"seventy",70},{"eighty",80},
                {"ninety",90}
            };

        internal static Dictionary<string, long> rank_words = new Dictionary<string, long>()
            {
                {"hundred",100},{"thousand",1000},{"million",1000000},{"billion",1000000000}
            };

        /*private Dictionary<string, long> getDictionary(string name)
            {
            return name;
            }*/
        }
    }
