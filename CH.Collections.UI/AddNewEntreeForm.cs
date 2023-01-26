using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH.Collections.UI
{
    public partial class AddNewEntreeForm : Form
    {
        public string EntreeName { get; private set; } = "";
        public AddNewEntreeForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            EntreeName = txtEntreeName.Text;
            DialogResult = DialogResult.OK; //DialogResult is a inum   
            Close();
        }
    }
}
