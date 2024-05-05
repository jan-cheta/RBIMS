using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IM
{
    public partial class Addnew : Form
    {
        
        public Addnew()
        {
            InitializeComponent();
            reInitDataGridView();
            inputDGV.ReadOnly = true;
            readOnlydgv.ReadOnly = true;
            inputDGV.MultiSelect = false; readOnlydgv.MultiSelect = false;

            newHouseholdpanel.Location = new Point(360, 135);
            newInhibitantpanel.Location = new Point(360, 135);
            newInhibitantpanel.Hide();

            roleInFamilyTB.Items.Add("HEAD");
            roleInFamilyTB.Items.Add("SPOUSE");
            roleInFamilyTB.Items.Add("CHILD");
        }

        private void reInitDataGridView()
        {
            MakeDataTable makeDataTable = new MakeDataTable();
            HouseholdCRUD householdCRUD = new HouseholdCRUD();
            DataTable add_household = makeDataTable.makeHouseholdDataTable(householdCRUD.readHousehold());
            inputDGV.DataSource = add_household;
            readOnlydgv.DataSource = add_household;
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
            newHouseholdpanel.Show();
            newInhibitantpanel.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newInhibitantpanel.Show();
            newHouseholdpanel.Hide();
        }

        private void Addnew_Load(object sender, EventArgs e)
        {
            
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

        private void button3_Click(object sender, EventArgs e)
        {
            newHouseholdpanel.Hide();
            inputDGV.Show();
        }

        private void newHousholdSubmit_Click(object sender, EventArgs e)
        {
            if (sitiotextBox.Text.Equals(""))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] addressInputs = { housetextBox.Text, streettextBox.Text, sitiotextBox.Text};

                NewRecord newRecord = new NewRecord();
                HouseholdCRUD householdCRUD = new HouseholdCRUD();
                householdCRUD.addHousehold(addressInputs[0], addressInputs[1], addressInputs[2]);
                reInitDataGridView();
                MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                housetextBox.Clear();
                streettextBox.Clear();
                sitiotextBox.Clear();
                citytextBox.Clear();
            }
        }

        private void newInhabitantSubmit_Click(object sender, EventArgs e)
        {
            NewRecord newRecord = new NewRecord();
            FamilyCRUD familyCRUD = new FamilyCRUD();
            InhabitantCRUD inhabitantCRUD = new InhabitantCRUD();

            if (firstNameTB.Text.Equals("") |
               middleNameTB.Text.Equals("") |
               lastNameTB.Text.Equals("") |
               occupationTB.Text.Equals("") |
               dateOfBirthTB.Text.Equals("") |
               civilStatusCB.Text.Equals("") |
               sexCB.Text.Equals("") |
               citizenTB.Text.Equals("") |
               contactNoTB.Text.Equals("") |
               educAttainmentTB.Text.Equals("") |
               roleInFamilyTB.Text.Equals("") |
               inputDGV.SelectedRows.Count == 0
               )
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //TODO: NEED FAMILY AND HOUSEHOLD TABLE TO PICK FROM BEFORE ENTERING A NEW INHABITANT
                //CLASSES TO BE USED FOR BACKEND: HouseholdCRUD, FamilyCRUD, InhabitantCRUD
                //SEARCH FUNCTION NEEDED
                string firstName = firstNameTB.Text.Trim(),
                    lastName = lastNameTB.Text.Trim(),
                    middleName = middleNameTB.Text.Trim(),
                    suffix = suffixTB.Text.Trim(),
                    occupation = occupationTB.Text.Trim(),
                    civilStatus = civilStatusCB.Text.Trim(),
                    sex = sexCB.Text.Trim(),
                    citizenship = citizenTB.Text.Trim(),
                    contactNo = contactNoTB.Text.Trim(),
                    educAttainment = educAttainmentTB.Text.Trim(),
                    headOfFamitly = familyHeadCB.Text.Trim(),
                    roleInFamily = roleInFamilyTB.Text.Trim();
                    string[] dateString = dateOfBirthTB.Text.Split('-');
                DateTime dateOfBirth = new DateTime(int.Parse(dateString[0]), int.Parse(dateString[1]), int.Parse(dateString[2]));
                int familyId, householdId = (int)inputDGV.SelectedRows[0].Cells["Household ID"].Value;
                if (headOfFamitly.Equals("NO DATA AVAILABLE") & !roleInFamily.Equals("HEAD"))
                {
                    MessageBox.Show("Family Does Not Exist In Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(headOfFamitly.Equals("NO DATA AVAILABLE") & roleInFamily.Equals("HEAD"))
                {
                    familyCRUD.addFamily(householdId);
                    familyId = newRecord.getFamily(householdId);
                    inhabitantCRUD.addInhabitant(firstName, lastName, middleName, suffix, occupation, dateOfBirth, sex, civilStatus, citizenship, contactNo, educAttainment, roleInFamily, "None", familyId, householdId);
                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    familyId = newRecord.getHeadOfFamilyId(headOfFamitly);
                    inhabitantCRUD.addInhabitant(firstName, lastName, middleName, suffix, occupation, dateOfBirth, sex, civilStatus, citizenship, contactNo, educAttainment, roleInFamily, "None", familyId, householdId);
                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void inputDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void familyHead_MClick(object sender, MouseEventArgs e)
        {
            familyHeadCB.Items.Clear();
            familyHeadCB.Items.Add("NO DATA AVAILABLE");
            int householdId = (int)inputDGV.SelectedRows[0].Cells["Household ID"].Value;
            NewRecord newRecord = new NewRecord();
            List<Inhabitant> familyHeadList = newRecord.findHeadOfFamily(householdId);
            foreach (Inhabitant inhabitant in familyHeadList)
            {
                familyHeadCB.Items.Add(inhabitant.LastName + ", " + inhabitant.FirstName + " " + inhabitant.LastName);
            }
        }
    }
}
