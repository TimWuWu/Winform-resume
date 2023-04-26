using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyResume.Models
{
	
    public class BasicInfo
    {		
		private string name;
        private string address;
        private string age;
        private string email;
        private string phonenumber;
        private string experience;
        public string Name
		{
			get { return name; }
			set 
			{ 
				name = value;
			}
		}

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		public string Age
		{
            get { return age; }
            set { age = value; }
        }

		public string Email
		{
			get { return email; }
			set 
			{
				//Regex check if input correct email
				//string pattem = "[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\\.[a-zA-Z0-9_-]+)+$";
				//bool isright= Regex.IsMatch(pattem, value);
				//if (isright)
				//{
					email = value;
				//}
				//else
				//{
				//	throw new Exception("Wrong Email,please input correct Email");
				//}
			}
		}

		public string PhoneNumber
		{
			get { return phonenumber; }
			set { phonenumber = value; }
		}

		public string Experience
        {
			get { return experience; }
			set { experience = value; }
		}
	}
}
