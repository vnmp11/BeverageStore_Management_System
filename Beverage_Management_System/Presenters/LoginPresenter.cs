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
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                MyMessageBox.showBox("You have been successfully logged in", "Message");
                //MessageBox.Show("You have been successfully logged in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                form.Refresh_UsernameAndPassword();
                MyMessageBox.showBox("Your username or password is incorrect", "Message");
                //MessageBox.Show("Your username or password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
            }
            sqlcon.Close(); 
        }

    }
}
