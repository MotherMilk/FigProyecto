using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigProyecto
{
    public partial class frmCIRCULO : Form
    {

        public frmCIRCULO()
        {
            InitializeComponent();
        }

        private void CIRCULO_Load(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
        }
    }
}
