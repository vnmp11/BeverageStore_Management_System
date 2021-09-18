using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using Beverage_Management_System.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Management_System.Presenters
{
    class StaffPresenter
    {
        IStaff staffView;

        public StaffPresenter(IStaff view)
        {
            staffView = view;
        }
        public void setDataGV_Fill(DataGridView dtGridView)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<Person> list = new List<Person>();

            string querry = "Select * from PERSON;";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    if (Convert.ToInt32(row["ROLE"]) != 0)
                    {
                        int ID = Convert.ToInt32(row["ID_PERSON"]);
                        string USERNAME = row["USERNAME"].ToString();
                        string PASSWORD = row["PASSWORD"].ToString();
                        string NAME = row["NAME"].ToString();

                        DateTime date = Convert.ToDateTime(row["DOB"]);
                        string DOB = date.ToString("dd-MM-yyyy");

                        string SEX = row["SEX"].ToString();
                        string PHONE = row["PHONE"].ToString();
                        string ADDRESS = row["ADDRESS"].ToString();
                        int ROLE = Convert.ToInt32(row["ROLE"]);

                        Person person = new Person(ID, USERNAME, PASSWORD, NAME, DOB, SEX, PHONE, ADDRESS, ROLE);
                        list.Add(person);
                    }
                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dtGridView.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();
                row.Cells[1].Value = list[i].getUSERNAME();
                row.Cells[2].Value = list[i].getPASSWORD();
                row.Cells[3].Value = list[i].getNAME();
                row.Cells[4].Value = list[i].getDOB();
                row.Cells[5].Value = list[i].getSEX();
                row.Cells[6].Value = list[i].getPHONE();
                row.Cells[7].Value = list[i].getADDRESS();
                row.Cells[8].Value = getRole(list[i].getROLE());

                dtGridView.Rows.Add(row);

            }

            myConnection.sqlcon.Close();

        }

        private string getRole(int ROLE)
        {
            switch (ROLE)
            {
                case 1:
                    return "Waiter";
                    break;
                case 2:
                    return "Bartender";
                    break;
                case 3:
                    return "Accountant";
                    break;
                default:
                    return "Owner";
                    break;

            }
        }
    }
}
