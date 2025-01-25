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

        DbTableStatusEntities context = new DbTableStatusEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            var values = context.TblTables.ToList();

            int buttonWidth = 100;
            int buttonHeight = 50;
            int padding = 10;
            int xOffset = 10;
            int yOffset = 10;


            for(int i = 0; i <values.Count; i++)
            {
                var item = values[i];
                Button button = new Button();
                button.Text = item.TableNumber.ToString();
                button.Size=new Size(buttonWidth, buttonHeight);
                button.Location=new Point(xOffset+(i%4)*(buttonWidth+padding),
                    yOffset + (i / 4) * (buttonHeight + padding));
                button.BackColor = (bool)item.Status ? System.Drawing.Color.Green : System.Drawing.Color.Red;
                this.Controls.Add(button);
            }
        }
    }
}
