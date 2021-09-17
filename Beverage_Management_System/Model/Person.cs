using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Model
{
    class Person
    {
		private int id_person;
		private string username;
		private string password;
		private string name;
		private string dob;
		private string sex;
		private string phone;
		private string address;
		private int role;

	public Person()
		{
			this.id_person = 0;
			this.username = "";
			this.password = "";
			this.name = "";
			this.dob = "";
			this.sex = "";
			this.phone = "";
			this.address = "";
			this.role = -1;
		}

		public Person(int ID, string USERNAME, string PASSWORD, string NAME, string DOB, string SEX, string PHONE, string ADDRESS, int ROLE)
		{
			this.id_person = ID;
			this.username = USERNAME;
			this.password = PASSWORD;
			this.name = NAME;
			this.dob = DOB;
			this.sex = SEX;
			this.phone = PHONE;
			this.address = ADDRESS;
			this.role = ROLE;
		}

		public int getID() { return this.id_person; }
		public void setID(int ID) { this.id_person = ID; }

		public string getUSERNAME() { return this.username; }
		public void setUSERNAME(string USERNAME) { this.username = USERNAME; }

		public string getPASSWORD() { return this.password; }
		public void setPASSWORD(string PASSWORD) { this.password = PASSWORD; }

		public string getNAME() { return this.name; }
		public void setNAME(string NAME) { this.name = NAME; }

		public string getDOB() { return this.dob; }
		public void setDOB(string DOB) { this.dob = DOB; }

		public string getSEX() { return this.sex; }
		public void setSEX(string SEX) { this.sex = SEX; }

		public string getPHONE() { return this.phone; }
		public void setPHONE(string PHONE) { this.phone = PHONE; }

		public string getADDRESS() { return this.address; }
		public void setADDRESS(string ADDRESS) { this.address = ADDRESS; }

		public int getROLE() { return this.role; }
		public void setROLE(int ROLE) { this.role = ROLE; }

	}
}
