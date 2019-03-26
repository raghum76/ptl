using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jjuegoGuerra
{
    public partial class Form1 : Form
    {
        Nave nave1, nave2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nave1 = new Nave("Terricola");
            nave2 = new Nave("Marciana");
            textBox1.Text  = Batalla(nave1, nave2);
        }

        private string Batalla(Nave naveT, Nave naveM)
        {
            while (naveT.cuantosQuedan()>0 && naveM.cuantosQuedan()>0)
            {
                for (int turno=0;turno<10;turno++)
                {
                    naveM.RecibirDisparo(naveT.Disparar(turno));
                    naveT.RecibirDisparo(naveM.Disparar(turno));
                }
            }
            if (naveT.cuantosQuedan() > 0)
                return "ganamos los Terricolas, podemos seguir acabando el planeta";
            else
                return "Los marcianos llegaron Ya ! ! !...";
        }
    }
}
