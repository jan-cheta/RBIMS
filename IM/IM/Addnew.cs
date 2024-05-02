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

        private void submit_Click(object sender, EventArgs e)
        {
            if(housetextBox.Text.Equals("") | streettextBox.Text.Equals("") | sitiotextBox.Text.Equals("") | citytextBox.Text.Equals(""))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] addressInputs = { housetextBox.Text, streettextBox.Text, sitiotextBox.Text, citytextBox.Text };
                string address = String.Join(", ", addressInputs);
                NewRecord newRecord = new NewRecord();
                HouseholdCRUD householdCRUD = new HouseholdCRUD();
                if (newRecord.validateNewHouseHold(address))
                {
                    householdCRUD.addHousehold(address);
                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    housetextBox.Clear();
                    streettextBox.Clear();
                    sitiotextBox.Clear();
                    citytextBox.Clear();
                }
                else
                {
                    MessageBox.Show(address + " already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           //TODO: CREATE DATAGRIDVIEW FOR HOUSEHOLDS FOR EASY REFERENCE FOR THE USER
        }

        private void submit2_Click(object sender, EventArgs e)
        {
            if(FNtextBox.Text.Equals("")|
                MNtextBox.Text.Equals("")|
                LNtextBox.Text.Equals("")|
                OtextBox.Text.Equals("")|
                DBtextBox.Text.Equals("")|
                CScomboBox.Text.Equals("")|
                ScomboBox.Text.Equals("")|
                CZtextBox.Text.Equals("")|
                CNtextBox.Text.Equals("")|
                EAtextBox.Text.Equals("")|
                RFcomboBox.Text.Equals("")|
                FHcomboBox.Text.Equals("")
                )
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //TODO: NEED FAMILY AND HOUSEHOLD TABLE TO PICK FROM BEFORE ENTERING A NEW INHABITANT
                //CLASSES TO BE USED FOR BACKEND: HouseholdCRUD, FamilyCRUD, InhabitantCRUD
                //SEARCH FUNCTION NEEDED
            }
        }
    }
}
