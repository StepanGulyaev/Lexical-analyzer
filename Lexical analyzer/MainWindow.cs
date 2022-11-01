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
        public MainWindow()
            {
            InitializeComponent();
            }

        private void InitializeComponent()
            {
            this.SuspendLayout();
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1790, 900);
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

            }

        public void createButton(string text, Control parent, Point location, Size size, EventHandler onclick)
            {
            Button btn = new Button();
            this.Controls.Add(btn);
            btn.Parent = parent;
            btn.Text = text;
            btn.Size = size;
            btn.Location = location;
            btn.Click += onclick;
            }


        private void MainWindow_Load(object sender, EventArgs e)
            {
            createButton("calculate",this,MainWindow);
            }
        }
    }
