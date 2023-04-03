using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doancs
{
    public partial class ask_form : Form
    {
        public bool result = false;
        public ask_form()
        {
            InitializeComponent();
        }

        protected void OK_Click(object sender, EventArgs e)
        {
            result = true;
            this.Close();
        }

        protected void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
