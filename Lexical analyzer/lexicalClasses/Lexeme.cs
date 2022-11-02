using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Lexical_analyzer
    {
    internal class Lexeme
        {
        public string lexeme;
        public string type;
        public long value;

        public Lexeme(string inputStr)
            {
            lexeme = inputStr;
            type = getType(lexeme);
            value = getValue(lexeme);
            }

        public string getType(string lexeme)
            {
            string typeStr = "undefined";
            if (MainWindow.one_to_nine.ContainsKey(lexeme))
                {
                typeStr = "one_to_nine";
                }
            else if (MainWindow.ten_to_ninteen.ContainsKey(lexeme))
                {
                typeStr = "ten_to_ninteen";
                }
            else if (MainWindow.tens.ContainsKey(lexeme))
                {
                typeStr = "tens";
                }
            else if (MainWindow.rank_words.ContainsKey(lexeme))
                {
                typeStr = "rank_words";
                }
            return typeStr;
            }

        public long getValue(string lexeme)
            {
            long value = 0;
            if (MainWindow.one_to_nine.ContainsKey(lexeme))
                {
                value = MainWindow.one_to_nine[lexeme];
                }
            else if (MainWindow.ten_to_ninteen.ContainsKey(lexeme))
                {
                value = MainWindow.ten_to_ninteen[lexeme];
                }
            else if (MainWindow.tens.ContainsKey(lexeme))
                {
                value = MainWindow.tens[lexeme];
                }
            else if (MainWindow.rank_words.ContainsKey(lexeme))
                {
                value = MainWindow.rank_words[lexeme];
                }
            return value;
            }

        public bool input_error()
            {
            if (type == "undefined")
                {
                return true;
                }
            else
                {
                return false;
                }
            }
        }
    }
