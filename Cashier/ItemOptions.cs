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
    public partial class ItemOptions : UserControl
    {
        String activity, ItemCode;
        public ItemOptions(String activity,String itemCode)
        {
            this.activity = activity;
            this.ItemCode = itemCode;
            InitializeComponent();
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (activity == "add")
            {
                    bool y=new Activities().addNewItem(txtItemCode.Text,txtName.Text,txtPrice.Text,txtSize.Text,"");
                if (y == true)
                {
                    MessageBox.Show("item added");
                }
                else
                {
                    MessageBox.Show("something wrong");


                }
            }
            else if (activity == "update")
            {

            }
            else
            {

            }
        }

        private void ItemOptions_Load(object sender, EventArgs e)
        {
            txtItemCode.Text = (int.Parse(ItemCode)+1).ToString();
        }
    }
}
