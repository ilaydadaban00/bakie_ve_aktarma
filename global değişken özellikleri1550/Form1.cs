using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace global_değişken_özellikleri1550
{
    public partial class Form1 : Form
    {
        //burdaki değişkenler globaldır.,"
        double bakiye = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text="bakiye:"+bakiye.ToString();
            lblBakiye.ForeColor = Color.Green;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            bakiye += 50;
            lblBakiye.Text = "bakiye:" + bakiye.ToString();
            lblBakiye.ForeColor = Color.Green;
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            bakiye-= 8;
            lblBakiye.Text = "bakiye:" + bakiye.ToString();

            if (bakiye >= 8)
            {

            
                bakiye += -8;
                lblBakiye.Text = "bakiye:" + bakiye.ToString();

            }
            else 
            {
                lblBakiye.Text = "paranmı var fakir yürü.....";
                lblBakiye.ForeColor=Color.Red;

            }
        }
    }
}
