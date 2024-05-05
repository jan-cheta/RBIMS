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
    public partial class MainForm : Form
    {
        DataTable ListOFInhabitants = new DataTable();
        DataTable RBI = new DataTable();

        public MainForm()
        {
            InitializeComponent();
            MakeDataTable makeDataTable = new MakeDataTable();
            InhabitantCRUD inhabitantCRUD = new InhabitantCRUD();
            DataTable inhabitantDT = makeDataTable.makeInhabitantDataTable(inhabitantCRUD.readInhabitant());
            dataGridViewList_Of_Inhabitants.DataSource = inhabitantDT;

            RBI.Columns.Add("HOUSE HOLD NO.", typeof(int));
            RBI.Columns.Add("NO. OF FAMILIES", typeof(int));
            RBI.Columns.Add("NAME OF THE HEAD OF THE FAMILY", typeof(string));
            RBI.Columns.Add("OCCUPATION", typeof(string));
            RBI.Columns.Add("FAMILY HEAD BIRTHDAY", typeof(string));
            RBI.Columns.Add("NAME OF WIFES/SPOUSE", typeof(string));
            RBI.Columns.Add("SPOUSE OCCUPATION", typeof(string));
            RBI.Columns.Add("WIFE/SPOUSE BIRTHDAY", typeof(string));
            RBI.Columns.Add("NAME OF CHILDREN", typeof(string));
            RBI.Columns.Add("CHILDREN BIRTHDAY", typeof(string));
            RBI.Columns.Add("OCCUPATION REMARKS", typeof(string));
            dataGridViewRBI_Record.DataSource = RBI;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            dataGridViewRBI_Record.Hide();
            dataGridViewList_Of_Inhabitants.Hide();

            label1.ForeColor = Color.Gold;
            label2.ForeColor = Color.Gold;
            label16.ForeColor = Color.White;
            label3.ForeColor = Color.Gold;
            label4.ForeColor = Color.Gold;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.Gold;
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.Gold;
            label9.ForeColor = Color.Gold;
            label10.ForeColor = Color.Gold;

            bigbrglogo.Hide(); //18, 5
            welcome.Hide(); //491, 78
            firstname.Hide(); //522, 144
            time.Hide(); //1107, 88
            date.Hide(); //1107, 154
            panelvl.Hide(); //388, 349
            panelch.Hide(); //647, 349
            panelstatistic.Hide(); //904, 349
            panelur.Hide(); //388, 520
            panelpc.Hide(); //200, 124
            panellogout.Hide(); //904, 520

            smallbrglogo.Show(); //48, 114
            barangaysiblot.Show(); //353, 67
            sannicolas.Show(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Show(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Show(); //884, 66
            barinfo2.Show(); //861, 116
            pictureBrginfo.Show(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void label2_Click(object sender, EventArgs e)
        {
            dataGridViewRBI_Record.Hide();
            dataGridViewList_Of_Inhabitants.Hide();

            label1.ForeColor = Color.Gold;
            label2.ForeColor = Color.White;
            label16.ForeColor = Color.Gold;
            label3.ForeColor = Color.Gold;
            label4.ForeColor = Color.Gold;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.Gold;
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.Gold;
            label9.ForeColor = Color.Gold;
            label10.ForeColor = Color.Gold;


            bigbrglogo.Hide(); //18, 5
            welcome.Hide(); //491, 78
            firstname.Hide(); //522, 144
            time.Hide(); //1107, 88
            date.Hide(); //1107, 154
            panelvl.Hide(); //388, 349
            panelch.Hide(); //647, 349
            panelstatistic.Hide(); //904, 349
            panelur.Hide(); //388, 520
            panelpc.Hide(); //200, 124
            panellogout.Hide(); //904, 520

            smallbrglogo.Show(); //48, 114
            barangaysiblot.Show(); //353, 67
            sannicolas.Show(); //377, 112
            myhome.Show(); //383, 142
            picture1off.Show(); //269, 182
            picture2off.Show(); //448, 331
            picture3off.Show(); //263, 501
            picture4off.Show(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Show(); //669, 56
            barangayofficials.Show(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }


        private void label1_Click(object sender, EventArgs e)
        {
            dataGridViewRBI_Record.Hide();
            dataGridViewList_Of_Inhabitants.Hide();

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.Gold;
            label16.ForeColor = Color.Gold;
            label3.ForeColor = Color.Gold;
            label4.ForeColor = Color.Gold;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.Gold;
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.Gold;
            label9.ForeColor = Color.Gold;
            label10.ForeColor = Color.Gold;

            bigbrglogo.Show(); //18, 5
            welcome.Show(); //491, 78
            firstname.Show(); //522, 144
            time.Show(); //1107, 88
            date.Show(); //1107, 154
            panelvl.Show(); //388, 349
            panelch.Show(); //647, 349
            panelstatistic.Show(); //904, 349
            panelur.Show(); //388, 520
            panelpc.Show(); //200, 124
            panellogout.Show(); //904, 520

            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Hide(); //669, 56
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MakeDataTable makeDataTable = new MakeDataTable();
            InhabitantCRUD inhabitantCRUD = new InhabitantCRUD();
            DataTable inhabitantDT = makeDataTable.makeInhabitantDataTable(inhabitantCRUD.readInhabitant());
            dataGridViewList_Of_Inhabitants.DataSource = inhabitantDT;

            dataGridViewRBI_Record.Hide();

            dataGridViewList_Of_Inhabitants.Show();
            



            label1.ForeColor = Color.Gold;
            label2.ForeColor = Color.Gold;
            label16.ForeColor = Color.Gold;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.Gold;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.Gold;
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.Gold;
            label9.ForeColor = Color.Gold;
            label10.ForeColor = Color.Gold;

            bigbrglogo.Hide(); //18, 5
            welcome.Hide(); //491, 78
            firstname.Hide(); //522, 144
            time.Hide(); //1107, 88
            date.Hide(); //1107, 154
            panelvl.Hide(); //388, 349
            panelch.Hide(); //647, 349
            panelstatistic.Hide(); //904, 349
            panelur.Hide(); //388, 520
            panelpc.Hide(); //200, 124
            panellogout.Hide(); //904, 520

            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Hide(); //669, 56
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Show(); //245, 151
            x.Show(); //488, 154
            searchbutton.Show(); //525, 142

            listofinhabitants.Show(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void label4_Click(object sender, EventArgs e)
        {
            dataGridViewList_Of_Inhabitants.Hide();

            dataGridViewRBI_Record.Show();
            


            label1.ForeColor = Color.Gold;
            label2.ForeColor = Color.Gold;
            label16.ForeColor = Color.Gold;
            label3.ForeColor = Color.Gold;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.Gold;
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.Gold;
            label9.ForeColor = Color.Gold;
            label10.ForeColor = Color.Gold;

            bigbrglogo.Hide(); //18, 5
            welcome.Hide(); //491, 78
            firstname.Hide(); //522, 144
            time.Hide(); //1107, 88
            date.Hide(); //1107, 154
            panelvl.Hide(); //388, 349
            panelch.Hide(); //647, 349
            panelstatistic.Hide(); //904, 349
            panelur.Hide(); //388, 520
            panelpc.Hide(); //200, 124
            panellogout.Hide(); //904, 520

            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Hide(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Show(); //400, 78
            searchbox.Show(); //245, 151
            x.Show(); //488, 154
            searchbutton.Show(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void label5_Click(object sender, EventArgs e)
        {

            Addnew addnew = new Addnew();
            this.Hide();
            addnew.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            dataGridViewList_Of_Inhabitants.Hide();
            dataGridViewRBI_Record.Hide();

            label1.ForeColor = Color.Gold;
            label2.ForeColor = Color.Gold;
            label16.ForeColor = Color.Gold;
            label3.ForeColor = Color.Gold;
            label4.ForeColor = Color.Gold;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.Gold;
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.Gold;
            label10.ForeColor = Color.Gold;

            bigbrglogo.Hide(); //18, 5
            welcome.Hide(); //491, 78
            firstname.Hide(); //522, 144
            time.Hide(); //1107, 88
            date.Hide(); //1107, 154
            panelvl.Hide(); //388, 349
            panelch.Hide(); //647, 349
            panelstatistic.Hide(); //904, 349
            panelur.Hide(); //388, 520
            panelpc.Hide(); //200, 124
            panellogout.Hide(); //904, 520

            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Hide(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Show(); //72, 344
            statisticss.Show(); //355, 64
            date2.Show(); //355, 111
            numberhousehold.Show(); //313, 203
            numberfamilies.Show(); //622, 203
            numberinhabitants.Show(); //929, 204
            numbersenior.Show(); //313, 380
            numberpwd.Show(); //622, 381
            numberminor.Show(); //930, 382
            numberadults.Show(); //313, 556
            numbermale.Show(); //621, 556
            numberfemale.Show(); //930, 557

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Signup signingup = new Signup();

            this.Hide();
            signingup.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridViewRBI_Record.Hide();
            dataGridViewList_Of_Inhabitants.Hide();

            label1.ForeColor = Color.White;
            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Hide(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void label6_Click(object sender, EventArgs e)
        {
            dataGridViewList_Of_Inhabitants.Hide();
            dataGridViewRBI_Record.Hide();

            label1.ForeColor = Color.Gold;
            label2.ForeColor = Color.Gold;
            label16.ForeColor = Color.Gold;
            label3.ForeColor = Color.Gold;
            label4.ForeColor = Color.Gold;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.Gold;
            label9.ForeColor = Color.Gold;
            label10.ForeColor = Color.Gold;

            bigbrglogo.Hide(); //18, 5
            welcome.Hide(); //491, 78
            firstname.Hide(); //522, 144
            time.Hide(); //1107, 88
            date.Hide(); //1107, 154
            panelvl.Hide(); //388, 349
            panelch.Hide(); //647, 349
            panelstatistic.Hide(); //904, 349
            panelur.Hide(); //388, 520
            panelpc.Hide(); //200, 124
            panellogout.Hide(); //904, 520

            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Hide(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void label7_Click(object sender, EventArgs e)
        {
            dataGridViewList_Of_Inhabitants.Hide();
            dataGridViewRBI_Record.Hide();

            label1.ForeColor = Color.Gold;
            label2.ForeColor = Color.Gold;
            label16.ForeColor = Color.Gold;
            label3.ForeColor = Color.Gold;
            label4.ForeColor = Color.Gold;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.Gold;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.Gold;
            label9.ForeColor = Color.Gold;
            label10.ForeColor = Color.Gold;

            bigbrglogo.Hide(); //18, 5
            welcome.Hide(); //491, 78
            firstname.Hide(); //522, 144
            time.Hide(); //1107, 88
            date.Hide(); //1107, 154
            panelvl.Hide(); //388, 349
            panelch.Hide(); //647, 349
            panelstatistic.Hide(); //904, 349
            panelur.Hide(); //388, 520
            panelpc.Hide(); //200, 124
            panellogout.Hide(); //904, 520

            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Hide(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void picture4off_Click(object sender, EventArgs e)
        {
            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Show();
            Bigpicture4off.Location = new Point(250, 0);
            line.Hide(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void picture1off_Click(object sender, EventArgs e)
        {
            
            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Show();
            Bigpicture1off.Location = new Point(150, 0);
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Hide(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557

        }

        private void picture3off_Click(object sender, EventArgs e)
        {
            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Show();
            Bigpicture3off.Location = new Point(150, 0);
            Bigpicture4off.Hide();
            line.Hide(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }
        //216, 55
        private void picture2off_Click_1(object sender, EventArgs e)
        {
            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Show();
            Bigpicture2off.Location = new Point(150, 0);
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Hide(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void panelvl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridViewList_Of_Inhabitants.Show();

            label1.ForeColor = Color.Gold;
            label2.ForeColor = Color.Gold;
            label16.ForeColor = Color.Gold;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.Gold;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.Gold;
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.Gold;
            label9.ForeColor = Color.Gold;
            label10.ForeColor = Color.Gold;

            bigbrglogo.Hide(); //18, 5
            welcome.Hide(); //491, 78
            firstname.Hide(); //522, 144
            time.Hide(); //1107, 88
            date.Hide(); //1107, 154
            panelvl.Hide(); //388, 349
            panelch.Hide(); //647, 349
            panelstatistic.Hide(); //904, 349
            panelur.Hide(); //388, 520
            panelpc.Hide(); //200, 124
            panellogout.Hide(); //904, 520

            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Hide(); //669, 56
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Show(); //245, 151
            x.Show(); //488, 154
            searchbutton.Show(); //525, 142

            listofinhabitants.Show(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Addnew addnew = new Addnew();
            this.Hide();
            addnew.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            dataGridViewList_Of_Inhabitants.Hide();
            dataGridViewRBI_Record.Hide();

            label1.ForeColor = Color.Gold;
            label2.ForeColor = Color.Gold;
            label16.ForeColor = Color.Gold;
            label3.ForeColor = Color.Gold;
            label4.ForeColor = Color.Gold;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.Gold;
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.Gold;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.Gold;

            bigbrglogo.Hide(); //18, 5
            welcome.Hide(); //491, 78
            firstname.Hide(); //522, 144
            time.Hide(); //1107, 88
            date.Hide(); //1107, 154
            panelvl.Hide(); //388, 349
            panelch.Hide(); //647, 349
            panelstatistic.Hide(); //904, 349
            panelur.Hide(); //388, 520
            panelpc.Hide(); //200, 124
            panellogout.Hide(); //904, 520

            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Show(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            dataGridViewRBI_Record.Show();

            label1.ForeColor = Color.Gold;
            label2.ForeColor = Color.Gold;
            label16.ForeColor = Color.Gold;
            label3.ForeColor = Color.Gold;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.Gold;
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.Gold;
            label9.ForeColor = Color.Gold;
            label10.ForeColor = Color.Gold;

            bigbrglogo.Hide(); //18, 5
            welcome.Hide(); //491, 78
            firstname.Hide(); //522, 144
            time.Hide(); //1107, 88
            date.Hide(); //1107, 154
            panelvl.Hide(); //388, 349
            panelch.Hide(); //647, 349
            panelstatistic.Hide(); //904, 349
            panelur.Hide(); //388, 520
            panelpc.Hide(); //200, 124
            panellogout.Hide(); //904, 520

            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Hide(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Show(); //400, 78
            searchbox.Show(); //245, 151
            x.Show(); //488, 154
            searchbutton.Show(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gold;
            label2.ForeColor = Color.Gold;
            label16.ForeColor = Color.Gold;
            label3.ForeColor = Color.Gold;
            label4.ForeColor = Color.Gold;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.Gold;
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.Gold;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.Gold;

            bigbrglogo.Hide(); //18, 5
            welcome.Hide(); //491, 78
            firstname.Hide(); //522, 144
            time.Hide(); //1107, 88
            date.Hide(); //1107, 154
            panelvl.Hide(); //388, 349
            panelch.Hide(); //647, 349
            panelstatistic.Hide(); //904, 349
            panelur.Hide(); //388, 520
            panelpc.Hide(); //200, 124
            panellogout.Hide(); //904, 520

            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Show(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gold;
            label2.ForeColor = Color.Gold;
            label16.ForeColor = Color.Gold;
            label3.ForeColor = Color.Gold;
            label4.ForeColor = Color.Gold;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.Gold;
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.Gold;
            label10.ForeColor = Color.Gold;

            bigbrglogo.Hide(); //18, 5
            welcome.Hide(); //491, 78
            firstname.Hide(); //522, 144
            time.Hide(); //1107, 88
            date.Hide(); //1107, 154
            panelvl.Hide(); //388, 349
            panelch.Hide(); //647, 349
            panelstatistic.Hide(); //904, 349
            panelur.Hide(); //388, 520
            panelpc.Hide(); //200, 124
            panellogout.Hide(); //904, 520

            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Hide(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Show(); //72, 344
            statisticss.Show(); //355, 64
            date2.Show(); //355, 111
            numberhousehold.Show(); //313, 203
            numberfamilies.Show(); //622, 203
            numberinhabitants.Show(); //929, 204
            numbersenior.Show(); //313, 380
            numberpwd.Show(); //622, 381
            numberminor.Show(); //930, 382
            numberadults.Show(); //313, 556
            numbermale.Show(); //621, 556
            numberfemale.Show(); //930, 557
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gold;
            label2.ForeColor = Color.Gold;
            label16.ForeColor = Color.Gold;
            label3.ForeColor = Color.Gold;
            label4.ForeColor = Color.Gold;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.Gold;
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.Gold;
            label10.ForeColor = Color.Gold;

            bigbrglogo.Hide(); //18, 5
            welcome.Hide(); //491, 78
            firstname.Hide(); //522, 144
            time.Hide(); //1107, 88
            date.Hide(); //1107, 154
            panelvl.Hide(); //388, 349
            panelch.Hide(); //647, 349
            panelstatistic.Hide(); //904, 349
            panelur.Hide(); //388, 520
            panelpc.Hide(); //200, 124
            panellogout.Hide(); //904, 520

            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Hide(); //669, 59
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridViewRBI_Record.Hide();
            dataGridViewList_Of_Inhabitants.Hide();

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.Gold;
            label16.ForeColor = Color.Gold;
            label3.ForeColor = Color.Gold;
            label4.ForeColor = Color.Gold;
            label5.ForeColor = Color.Gold;
            label6.ForeColor = Color.Gold;
            label7.ForeColor = Color.Gold;
            label8.ForeColor = Color.Gold;
            label9.ForeColor = Color.Gold;
            label10.ForeColor = Color.Gold;

            bigbrglogo.Show(); //18, 5
            welcome.Show(); //491, 78
            firstname.Show(); //522, 144
            time.Show(); //1107, 88
            date.Show(); //1107, 154
            panelvl.Show(); //388, 349
            panelch.Show(); //647, 349
            panelstatistic.Show(); //904, 349
            panelur.Show(); //388, 520
            panelpc.Show(); //200, 124
            panellogout.Show(); //904, 520

            smallbrglogo.Hide(); //48, 114
            barangaysiblot.Hide(); //353, 67
            sannicolas.Hide(); //377, 112
            myhome.Hide(); //383, 142
            picture1off.Hide(); //269, 182
            picture2off.Hide(); //448, 331
            picture3off.Hide(); //263, 501
            picture4off.Hide(); //734, 149
            Bigpicture1off.Hide();
            Bigpicture2off.Hide();
            Bigpicture3off.Hide();
            Bigpicture4off.Hide();
            line.Hide(); //669, 56
            barangayofficials.Hide(); //759, 85

            barinfo1.Hide(); //884, 66
            barinfo2.Hide(); //861, 116
            pictureBrginfo.Hide(); //394, 182

            registrybrg.Hide(); //400, 78
            searchbox.Hide(); //245, 151
            x.Hide(); //488, 154
            searchbutton.Hide(); //525, 142

            listofinhabitants.Hide(); //529, 78

            statlogo.Hide(); //72, 344
            statisticss.Hide(); //355, 64
            date2.Hide(); //355, 111
            numberhousehold.Hide(); //313, 203
            numberfamilies.Hide(); //622, 203
            numberinhabitants.Hide(); //929, 204
            numbersenior.Hide(); //313, 380
            numberpwd.Hide(); //622, 381
            numberminor.Hide(); //930, 382
            numberadults.Hide(); //313, 556
            numbermale.Hide(); //621, 556
            numberfemale.Hide(); //930, 557
        }

        private void Bigpicture3off_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            MakeDataTable makeDataTable = new MakeDataTable();
            InhabitantCRUD inhabitant = new InhabitantCRUD();
            if (searchbox.Text.Equals(""))
            {
                DataTable defaultDT = makeDataTable.makeInhabitantDataTable(inhabitant.readInhabitant());
                dataGridViewList_Of_Inhabitants.DataSource = defaultDT;
            }
            else
            {
                SearchMe searchMe = new SearchMe();
                string searchText = searchbox.Text;
                DataTable searchedDT = searchMe.SearchAlgorithm(searchText, inhabitant.readInhabitant());
                dataGridViewList_Of_Inhabitants.DataSource = searchedDT;
            }
            
        }
    }
}
