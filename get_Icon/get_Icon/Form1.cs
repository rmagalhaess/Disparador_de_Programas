using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace get_Icon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = this.pnl_Azul.Top;
            for( cont=this.pnl_Azul.Top; cont>10; cont--)
            {
                this.pnl_Azul.Top = cont;
                Thread.Sleep(5);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont = this.pnl_Azul.Top;
            for( cont=this.pnl_Azul.Top; cont<80; cont++)
            {
                this.pnl_Azul.Top = cont;
                Thread.Sleep(5);
            }
        }
    }
}
