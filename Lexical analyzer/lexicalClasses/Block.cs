using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexical_analyzer
    {
    internal class Block
        {
        public List<Lexeme> lexArr = new List<Lexeme>();
        public List<long> rankArr = new List<long>();
        public long value;

        public Block(List<Lexeme> lexes)
            {
            foreach (Lexeme lex in lexes)
                {
                lexArr.Add(lex);
                if (lex.type == "rank_words")
                    {
                    rankArr.Add(lex.value);
                    }
                }
            value = calculateBlockValue(lexArr);
            }

        public long calculateBlockValue(List<Lexeme> lexes)
            {
            long value = 0;
            foreach (Lexeme lex in lexes)
                {
                if(lex.type == "rank_words") {value *= lex.value;}
                else {value += lex.value;}
                }
            return value;
            }
        }
    }
