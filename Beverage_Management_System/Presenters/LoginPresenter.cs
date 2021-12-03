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
using Beverage_Management_System.Connection;

namespace Beverage_Management_System.Presenters
{
    class LoginPresenter
    {
        ILogin loginView;
        public Person person = new Person();

        public LoginPresenter(ILogin view)
        {
            loginView = view;
        }

        public void Login()
        {
            string username = loginView.username.Trim();
            string password = loginView.password.Trim();

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            string querry = "Select * from PERSON where USERNAME = '" + username + "' and PASSWORD = '" + password + "';";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
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

                    person = new Person(ID, USERNAME, PASSWORD, NAME, DOB, SEX, PHONE, ADDRESS, ROLE);
                }

            }
            else
            {
            }
            myConnection.sqlcon.Close();
        }


        public void handle_FaildLogin(Guna.UI2.WinForms.Guna2TextBox txt_Username, Guna.UI2.WinForms.Guna2TextBox txt_Password)
        {
            txt_Username.Text = "";
            txt_Password.Text = "";
            MyMessageBox.showBox("Your username or password is incorrect", "Message");
        }

        public void handle_SuccessfulLogin(Form form, Dashboard dashboard)
        {
            form.Hide();
            dashboard.Show();
            setDashboard_WithRole(dashboard);
            MyMessageBox.showBox("You have been successfully logged in", "Message");
        }

        public void setDashboard_WithRole(Dashboard dashboard)
        {
            switch (person.getROLE())
            {
                case 1:
                    dashboard.setDashboard_Waiter();
                    dashboard.setPersonalInformation(person.getNAME(), "Waiter");
                    break;
                case 2:
                    dashboard.setDashboard_Bartender();
                    dashboard.setPersonalInformation(person.getNAME(), "Bartender");
                    break;
                case 3:
                    dashboard.setDashboard_Accountant();
                    dashboard.setPersonalInformation(person.getNAME(), "Accountant");
                    break;
                default:
                    dashboard.setDashboard_Owner();
                    dashboard.setPersonalInformation(person.getNAME(), "Owner");
                    break;

            }
        }

    }

}
