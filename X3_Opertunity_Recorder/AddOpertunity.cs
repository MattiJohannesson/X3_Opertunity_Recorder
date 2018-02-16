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
    public partial class AddOpertunity : Form
    {

        Opertunity _Opertunity = null;

        public AddOpertunity()
        {
            InitializeComponent();
        }

        public Opertunity Opertunity
        {
            get { return _Opertunity; }
            set { _Opertunity = value; }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _Opertunity.Name = textBoxName.Text;
            _Opertunity.Sector = textBoxSector.Text;

            string[] _resource;
            _resource = textBoxResource.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < _resource.Length; i++)
            {
                _Opertunity.Resource.Add(_resource[i]);
            }

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
