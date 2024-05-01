using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IM
{
    public partial class Addnew : Form
    {
        public Addnew()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Close();
            mainForm.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            newhousehold.Text = "NEW HOUSEHOLD";
            newhousehold.Show();
            housetextBox.Show();
            streettextBox.Show();
            sitiotextBox.Show();
            citytextBox.Show();
            houselabel.Show();
            streetlabel.Show();
            sitiolabel.Show();
            citylabel.Show();
            submit.Show();


            household11.Hide();
            FNtextBox.Hide();
            MNtextBox.Hide();
            LNtextBox.Hide();
            SFtextBox.Hide();
            OtextBox.Hide();
            DBtextBox.Hide();
            CScomboBox.Hide();
            ScomboBox.Hide();
            CZtextBox.Hide();
            CNtextBox.Hide();
            EAtextBox.Hide();
            FHcomboBox.Hide();
            RFcomboBox.Hide();
            FN.Hide();
            MN.Hide();
            LN.Hide();
            SF.Hide();
            O.Hide();
            DB.Hide();
            CS.Hide();
            S.Hide();
            CZ.Hide();
            CN.Hide();
            EA.Hide();
            FH.Hide();
            RF.Hide();
            submit2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            housetextBox.Hide(); //30, 200
            streettextBox.Hide(); //152, 201
            sitiotextBox.Hide(); //359, 200
            citytextBox.Hide(); //565, 200
            houselabel.Hide();  //32, 231
            streetlabel.Hide(); //181, 231
            sitiolabel.Hide();  //394, 229
            citylabel.Hide();   //579, 229
            submit.Hide();  //357, 357

            newhousehold.Text = "NEW INHABITANT";
            household11.Show();
            FNtextBox.Show();
            MNtextBox.Show();
            LNtextBox.Show();
            SFtextBox.Show();
            OtextBox.Show();
            DBtextBox.Show();
            CScomboBox.Show();
            ScomboBox.Show();
            CZtextBox.Show();
            CNtextBox.Show();
            EAtextBox.Show();
            FHcomboBox.Show();
            RFcomboBox.Show();
            FN.Show();
            MN.Show();
            LN.Show();
            SF.Show();
            O.Show();
            DB.Show();
            CS.Show();
            S.Show();
            CZ.Show();
            CN.Show();
            EA.Show();
            FH.Show();
            RF.Show();
            submit2.Show();
        }

        private void Addnew_Load(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
            newhousehold.Text = "NEW HOUSEHOLD";
            newhousehold.Show();
            housetextBox.Show();
            streettextBox.Show();
            sitiotextBox.Show();
            citytextBox.Show();
            houselabel.Show();
            streetlabel.Show();
            sitiolabel.Show();
            citylabel.Show();
            submit.Show();


            household11.Hide();
            FNtextBox.Hide();
            MNtextBox.Hide();
            LNtextBox.Hide();
            SFtextBox.Hide();
            OtextBox.Hide();
            DBtextBox.Hide();
            CScomboBox.Hide();
            ScomboBox.Hide();
            CZtextBox.Hide();
            CNtextBox.Hide();
            EAtextBox.Hide();
            FHcomboBox.Hide();
            RFcomboBox.Hide();
            FN.Hide();
            MN.Hide();
            LN.Hide();
            SF.Hide();
            O.Hide();
            DB.Hide();
            CS.Hide();
            S.Hide();
            CZ.Hide();
            CN.Hide();
            EA.Hide();
            FH.Hide();
            RF.Hide();
            submit2.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Close();
            mainForm.Show();
        }
    }
}
