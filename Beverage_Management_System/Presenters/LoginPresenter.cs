using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beverage_Management_System.Model;
using Beverage_Management_System.View;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace Beverage_Management_System.Presenters
{
    class LoginPresenter
    {
        ILogin loginView;

        public LoginPresenter(ILogin view)
        {
            loginView = view;
        }

        public void Login(Login form)
        {
            string username = loginView.username.Trim();
            string password = loginView.password.Trim();

            SqlConnection sqlcon = new SqlConnection("Data Source=beverage-stores-erver.database.windows.net;Initial Catalog=beverage-store;User ID=votrungtin;Password=Trungtin0701@");
            sqlcon.Open();

            string querry = "Select * from PERSON where USERNAME = '" + username + "' and PASSWORD = '" + password + "';";
            SqlDataAdapter sda = new SqlDataAdapter(querry, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                form.Hide();

                foreach (DataRow row in dtbl.Rows)
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

                    Dashboard dashboard = new Dashboard(ID);
                    dashboard.Show();
                    setDashboard_WithRole(ROLE, NAME, dashboard);
                   
                }

                MyMessageBox.showBox("You have been successfully logged in", "Message");

            }
            else
            {
                form.Refresh_UsernameAndPassword();
                MyMessageBox.showBox("Your username or password is incorrect", "Message");
      
            }
            sqlcon.Close(); 
        }

        public void setDashboard_WithRole(int ROLE, string NAME, Dashboard dashboard)
        {
            switch (ROLE)
            {
                case 1:
                    dashboard.setDashboard_Waiter();
                    dashboard.setPersonalInformation(NAME, "Waiter");
                    break;
                case 2:
                    dashboard.setDashboard_Bartender();
                    dashboard.setPersonalInformation(NAME, "Bartender");
                    break;
                case 3:
                    dashboard.setDashboard_Accountant();
                    dashboard.setPersonalInformation(NAME, "Accountant");
                    break;
                default:
                    dashboard.setDashboard_Owner();
                    dashboard.setPersonalInformation(NAME, "Owner");
                    break;

            }
        }

    }

}
