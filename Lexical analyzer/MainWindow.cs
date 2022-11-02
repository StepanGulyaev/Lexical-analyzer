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
            this.inputStringBox = new System.Windows.Forms.TextBox();
            this.inputStringLabel = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputStringBox
            // 
            this.inputStringBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputStringBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputStringBox.Location = new System.Drawing.Point(150, 75);
            this.inputStringBox.Name = "inputStringBox";
            this.inputStringBox.Size = new System.Drawing.Size(1100, 35);
            this.inputStringBox.TabIndex = 0;
            // 
            // inputStringLabel
            // 
            this.inputStringLabel.AutoSize = true;
            this.inputStringLabel.Enabled = false;
            this.inputStringLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputStringLabel.Location = new System.Drawing.Point(145, 44);
            this.inputStringLabel.Name = "inputStringLabel";
            this.inputStringLabel.Size = new System.Drawing.Size(91, 28);
            this.inputStringLabel.TabIndex = 1;
            this.inputStringLabel.Text = "String:";
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox.Location = new System.Drawing.Point(150, 170);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(1100, 35);
            this.numberBox.TabIndex = 2;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Enabled = false;
            this.numberLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(145, 142);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(113, 28);
            this.numberLabel.TabIndex = 3;
            this.numberLabel.Text = "Number:";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(150, 270);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(1100, 90);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // MainWindow
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1374, 441);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.inputStringLabel);
            this.Controls.Add(this.inputStringBox);
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }


        private void MainWindow_Load(object sender, EventArgs e)
            {

            }

        private void calculateButton_Click(object sender, EventArgs e)
            {

            }
        }
    }
