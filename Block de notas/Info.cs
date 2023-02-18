using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Block_de_notas
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            Informacion();
        }

        public void Informacion()
        {
            label2.Text = "Por Jose Nathaniel Bonilla";
            label4.Text = "que este es una copia hecha con "
                +"fines de Practica a la programacion. ";
        }
    }
}
