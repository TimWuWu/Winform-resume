using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MyResume.Models
{
    public class Myresume
    {
		private BasicInfo mybasicinfo;
		private List<Education> myeducation;
		private List<Job> myjobs;
		private string myphotopath;
		private List<Skill> myskill;

		public List<Skill> MySkill
		{
			get { return myskill; }
			set { myskill = value; }
		}

		public string MyPhotoPath
		{
			get { return myphotopath; }
			set { myphotopath = value; }
		}

		public List<Job> MyJobs
		{
			get { return myjobs; }
			set { myjobs = value; }
		}

		public List<Education> MyEducation
		{
			get { return myeducation; }
			set { myeducation = value; }
		}

		public BasicInfo MybasicInfo
		{
			get { return mybasicinfo; }
			set { mybasicinfo = value; }
		}
		public Myresume()
		{
			mybasicinfo= new BasicInfo();
			myjobs= new List<Job>();
			myeducation= new List<Education>();
			myskill=new List<Skill>();
		}
        public static Myresume Create()
        {
            if (File.Exists("Myresume.xml"))
            {
                using (var stream = File.OpenRead("Myresume.xml"))
				{
                    var serializer = new XmlSerializer(typeof(Myresume));
                    return serializer.Deserialize(stream) as Myresume;
				}
			}
            else
                return new Myresume();
        }
		public void Save() 
		{
            using (var stream = File.Open("Myresume.xml", FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(Myresume));
                serializer.Serialize(stream, this);
            }
        }
    }
}
