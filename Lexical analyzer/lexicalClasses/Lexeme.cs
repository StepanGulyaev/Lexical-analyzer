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
        public string value;

        public Lexeme(string inputStr)
            {
            lexeme = inputStr;
            type = getType(inputStr);
            }

        public string getType(string lexeme)
            {
            type = lexeme;
            var dictionaryList = typeof(Dictionaries).GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            var dictionaryListNames = Array.ConvertAll(dictionaryList, field => field.Name);
            /*foreach (var name in dictionaryList)
                {
                if (Dictionaries.)
                    {

                    }
                }
            if (Dictionaries.one_to_nine.ContainsKey(lexeme))
                {
                return 
                }*/
            return lexeme;
            }
        }
    }
