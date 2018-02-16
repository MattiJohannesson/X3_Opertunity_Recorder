using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X3_Opertunity_Recorder
{
    public partial class Form1 : Form
    {
        List<Opertunity> _opertunity = new List<Opertunity>();

        Opertunity _Opertunity = new Opertunity("", "", new List<string>());

        public Form1()
        {
            InitializeComponent();
        }

        private void addOpertunityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOpertunity addOpertunity = new AddOpertunity();
            addOpertunity.Opertunity = _Opertunity;

            if(addOpertunity.ShowDialog() == DialogResult.OK)
            {
                _opertunity.Add(addOpertunity.Opertunity);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < _opertunity.Count; i++)
            {
               ;
            }
        }
    }
}
