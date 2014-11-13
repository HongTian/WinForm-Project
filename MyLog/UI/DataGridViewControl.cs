using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLog.UI
{
    public partial class DataGridViewControl : UserControl
    {
        public DataGridViewControl()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.DataGridView DataGridView
        {
            get
            {
                return dataGridView1;
            }
            set
            {
                dataGridView1 = value;
            }
        }
    }
}
