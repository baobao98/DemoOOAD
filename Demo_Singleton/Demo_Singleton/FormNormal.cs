using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Singleton
{
    public partial class FormNormal : Form
    {
        public FormNormal()
        {
            InitializeComponent();
        }
        public FormNormal(int index)
        {
            InitializeComponent();
            lblTittle.Text = "Instance " + index;
        }

    }
}
