using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IM
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            bigbrglogo2.Show(); //243, 64
            welcome2.Show(); //491, 78
            firstname2.Show(); //522, 144
            time2.Show(); //1107, 88
            date2.Show(); //1107, 154
            inhabitantlists.Show(); //536, 316
            rbirecords.Show(); //846, 316
            printcertificate.Show(); //846, 316
            statisticss2.Show(); //846, 512

            statlogo2.Hide(); //243, 65
            statisticss3.Hide(); //363, 68
            date3.Hide(); //363, 115
            numberhousehold2.Hide(); //313, 203
            numberfamilies2.Hide(); //622, 203
            numberinhabitants2.Hide(); //929, 204
            numbersenior2.Hide(); //313, 380
            numberpwd2.Hide(); //622, 381
            numberminor2.Hide(); //930, 382
            numberadults2.Hide(); //313, 556
            numbermale2.Hide(); //621, 556
            numberfemale2.Hide(); //930, 557
        }

        private void label8_Click(object sender, EventArgs e)
        {
            bigbrglogo2.Hide(); //243, 64
            welcome2.Hide(); //491, 78
            firstname2.Hide(); //522, 144
            time2.Hide(); //1107, 88
            date2.Hide(); //1107, 154
            inhabitantlists.Hide(); //536, 316
            rbirecords.Hide(); //846, 316
            printcertificate.Hide(); //846, 316
            statisticss2.Hide(); //846, 512

            statlogo2.Show(); //243, 65
            statisticss3.Show(); //363, 68
            date3.Show(); //363, 115
            numberhousehold2.Show(); //313, 203
            numberfamilies2.Show(); //622, 203
            numberinhabitants2.Show(); //929, 204
            numbersenior2.Show(); //313, 380
            numberpwd2.Show(); //622, 381
            numberminor2.Show(); //930, 382
            numberadults2.Show(); //313, 556
            numbermale2.Show(); //621, 556
            numberfemale2.Show(); //930, 557
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
            this.Hide();
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {
            bigbrglogo2.Show(); //243, 64
            welcome2.Show(); //491, 78
            firstname2.Show(); //522, 144
            time2.Show(); //1107, 88
            date2.Show(); //1107, 154
            inhabitantlists.Show(); //536, 316
            rbirecords.Show(); //846, 316
            printcertificate.Show(); //846, 316
            statisticss2.Show(); //846, 512

            statlogo2.Hide(); //243, 65
            statisticss3.Hide(); //363, 68
            date3.Hide(); //363, 115
            numberhousehold2.Hide(); //313, 203
            numberfamilies2.Hide(); //622, 203
            numberinhabitants2.Hide(); //929, 204
            numbersenior2.Hide(); //313, 380
            numberpwd2.Hide(); //622, 381
            numberminor2.Hide(); //930, 382
            numberadults2.Hide(); //313, 556
            numbermale2.Hide(); //621, 556
            numberfemale2.Hide(); //930, 557
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
