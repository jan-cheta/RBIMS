using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IM
{
    public class SearchMe
    {
        MakeDataTable makeDataTable = new MakeDataTable();

        public DataTable SearchAlgorithm(string searchText, List<Inhabitant> inhabitantList)
        {

            DataTable oldInhabitantDT = makeDataTable.makeInhabitantDataTable(inhabitantList);
          
            List<int> validRows = new List<int>();

            for (int i = 0; i < oldInhabitantDT.Rows.Count; i++)
            {
                for (int j = 0; j < oldInhabitantDT.Columns.Count; j++)
                {
                    if (oldInhabitantDT.Rows[i][j] != null & oldInhabitantDT.Rows[i][j].ToString().ToLower().Contains(searchText))
                    {
                        validRows.Add(Convert.ToInt16(oldInhabitantDT.Rows[i][0]));
                        break;
                    }
                }
            }
            InhabitantCRUD inhabitantCRUD = new InhabitantCRUD();
            List<Inhabitant> inhabitants = inhabitantCRUD.readInhabitant();
            List<Inhabitant> filteredInhabitants = new List<Inhabitant>();

            foreach (int row in validRows)
            {
                foreach (Inhabitant inhabitant in inhabitants)
                {
                    if (inhabitant.InhabitantId == row)
                    {
                        filteredInhabitants.Add(inhabitant);
                    }
                }
            }

            return makeDataTable.makeInhabitantDataTable(filteredInhabitants);
        }
    }
    }      

