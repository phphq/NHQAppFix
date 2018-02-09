using System;
using System.Windows.Forms;

using NHQAppFix.Properties;

namespace NHQAppFix.Forms
{
    public partial class MedCompat : Form
    {
        public MedCompat()
        {
            InitializeComponent();
        }

        private void MedCompat_Load(object sender, EventArgs e)
        {
            pbMedCompat.Image = Resources.MedCompat;
        }
    }
}
