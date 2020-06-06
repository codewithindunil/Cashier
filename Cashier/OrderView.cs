using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier
{
    public partial class OrderView : UserControl
    {
        public OrderView()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Bill item = new Bill();
            panel3.Controls.Clear();
            item.Top = 1;
            item.Left = 1;
            panel3.Controls.Add(item);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
          
        }
    }
}
