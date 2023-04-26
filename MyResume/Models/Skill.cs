using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyResume.Models
{
    public class Skill
    {
		private string topic;

		private string componentsone;
		private string componentstwo;
		private string componentsthree;
		private string componentsfour;


		public string ComponentsFour
		{
			get { return componentsfour; }
			set { componentsfour = value; }
		}

		public string ComponentsThree	
		{
			get { return componentsthree; }
			set { componentsthree = value; }
		}

		public string ComponentsTwo
		{
			get { return componentstwo; }
			set { componentstwo = value; }
		}

		public string ComponentsOne
		{
			get { return componentsone; }
			set { componentsone = value; }
		}

		public string Topic
		{
			get { return topic; }
			set { topic = value; }
		}
	}
}
