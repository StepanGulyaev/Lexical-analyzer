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
            string input = inputStringBox.Text;
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
            List<Block> inputblocks = splitInBlocks(lexes);
            long blocksum = 0;
            foreach(Block block in inputblocks)
                {
                blocksum += block.value;
                }
            numberBox.Text = blocksum.ToString();
            }

        private List<Block> splitInBlocks(List<Lexeme> lexes)
            {
            List<Block> blocks = new List<Block>();
            List<Lexeme> blockLexes = new List<Lexeme>();
            while (lexes.Count > 0)
                {
                if (lexes[0].type == "rank_words" && lexes[0] != lexes.Last())
                    {
                    int i = 1;
                    while(lexes[i].type != "rank_words"){i++;}
                    if(lexes[0].value > lexes[i].value)
                        {
                        blockLexes.Add(lexes[0]);
                        lexes.RemoveAt(0);
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
        }
    }
