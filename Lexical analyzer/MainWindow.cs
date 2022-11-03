using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lexical_analyzer
    {
    public partial class MainWindow : Form
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

        public MainWindow()
            {
            InitializeComponent();
            }

        private void MainWindow_Load(object sender, EventArgs e)
            {
            }

        private void calculateButton_Click(object sender, EventArgs e)
            {
            string input = inputStringBox.Text.Trim();
            calculate(input);
            }

        private void calculate(string input)
            {
            string[] words = input.Split(' ');
            List<Lexeme> lexes = new List<Lexeme>();
            foreach (string word in words)
                {
                Lexeme lex = new Lexeme(word);
                lexes.Add(lex);
                }
            if (!searchErrors(lexes))
                {
                List<Block> inputblocks = splitInBlocks(lexes);
                long blocksum = 0;
                foreach (Block block in inputblocks)
                    {
                    blocksum += block.value;
                    }
                numberBox.Text = blocksum.ToString();
                }
            }

        private List<Block> splitInBlocks(List<Lexeme> lexes)
            {
            List<Block> blocks = new List<Block>();
            List<Lexeme> blockLexes = new List<Lexeme>();
            while (lexes.Count > 0)
                {
                if (lexes[0].type == "rank_words" && lexes[0] != lexes.Last())
                    {
                    Lexeme cur_rang_lex = lexes[0];
                    Lexeme next_rang_lex = null;
                    blockLexes.Add(lexes[0]);
                    lexes.RemoveAt(0);
                    for (int i = 1; i < lexes.Count; i++)
                        {
                        if(lexes[i].type == "rank_words") {next_rang_lex=lexes[i]; break;}
                        }
                    if (next_rang_lex == null || cur_rang_lex.value > next_rang_lex.value)
                        {
                        Block block = new Block(blockLexes);
                        blockLexes.Clear();
                        blocks.Add(block);
                        }
                    }
                else if(lexes[0] == lexes.Last())
                    {
                    blockLexes.Add(lexes[0]);
                    lexes.RemoveAt(0);
                    Block block = new Block(blockLexes);
                    blockLexes.Clear();
                    blocks.Add(block);
                    }
                else
                    {
                    blockLexes.Add(lexes[0]);
                    lexes.RemoveAt(0);
                    }
                }
            return blocks;
            }

        private bool searchErrors(List<Lexeme> lexes)
            {
            if(inputError(lexes) || syntaxError(lexes))
                {
                return true;
                }
            return false;
            }

        private bool inputError(List<Lexeme> lexes)
            {
            List<Lexeme> undefined_lexemes = new List<Lexeme>();
            foreach (Lexeme lex in lexes)
                {
                if (lex.type == "undefined")
                    {
                    undefined_lexemes.Add(lex);
                    }
                }
            if (undefined_lexemes.Count == 0) {return false;}
            else 
                {
                string error_string = "Слова ";
                foreach(Lexeme lex in undefined_lexemes) { error_string += $" \"{lex.lexeme}\","; }
                error_string = error_string.Remove(error_string.Length - 1);
                error_string += " написаны неправильно или не являются числительными английского языка";
                MessageBox.Show(error_string, "Неккоректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
                }
            }

        private bool syntaxError(List<Lexeme> lexes)
            {
            List<List<Lexeme>> pairs = new List<List<Lexeme>>();
            for (int i = 0; i < lexes.Count - 1; i++)
                {
                if ( (lexes[i].type == lexes[i + 1].type) && (lexes[i].type != "rank_words") && (lexes[i+1].type != "rank_words"))
                    {
                    List<Lexeme> pair= new List<Lexeme>();
                    pair.Add(lexes[i]);
                    pair.Add(lexes[i + 1]);
                    pairs.Add(pair);
                    }
                }

            if(pairs.Count == 0) { return false;}
            else
                {
                string error_string = "Словосочетания ";
                foreach(List<Lexeme> pair in pairs)
                    {
                    error_string += $" \"{pair[0].lexeme}\" \"{pair[1].lexeme}\";";
                    }
                error_string = error_string.Remove(error_string.Length - 1);
                error_string += " неккоректно составлены и не соответсвуют правилам английского языка;";
                MessageBox.Show(error_string, "Неккоректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
                }
            }
        }
    }
