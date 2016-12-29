using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 甲状腺随访系统
{
    public partial class UC_diagnosis : UserControl
    {
        public UC_diagnosis()
        {
            InitializeComponent();
        }

 

        private void switch_laryngoscope_ValueChanged(object sender, EventArgs e)
        {
            if (switch_laryngoscope.Value)
            {
                cbe_op.Enabled = false;
            }
            else {
                cbe_op.Enabled = true;
            }
        }



    }
}
