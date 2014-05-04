using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    /// <summary>
    /// Class for clock.
    /// </summary>
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Writes current time in label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerTick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToLongTimeString();
        }

         private void label1_Click(object sender, EventArgs e)
         {

         }

    }
}
