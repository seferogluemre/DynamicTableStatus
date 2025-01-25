using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicTableStatus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int buttonWidth = 100;
            int buttonHeight = 50;
            int padding = 10;
            int xOffset = 10;
            int yOffset = 10;


            for(int i = 0; i <= 12; i++)
            {
                Button button = new Button();
                button.Text = $"Masa{i+1}";
                button.Size=new Size(buttonWidth, buttonHeight);
                button.Location=new Point(xOffset+(i%4)*(buttonWidth+padding),
                    yOffset + (i / 4) * (buttonHeight + padding));
                this.Controls.Add(button);
            }
        }
    }
}
