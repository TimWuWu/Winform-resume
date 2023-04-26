using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume.Models
{
    public class Education:ICloneable
    {
        private string schoolname;
        private string majoy;
        private string start;
        private string period;
        private string stage;

        public string Stage
        {
            get { return stage; }
            set { stage = value; }
        }


        public string SchoolName 
        { 
            get { return schoolname; } 
            set { schoolname = value; } 
        }
        
        public string Period
        {
            get { return period; }
            set { period = value; }
        }
        
        public string Majoy
        {
            get { return majoy; }
            set { majoy = value; }
        }

        public string Start
        {
            get { return start; }
            set { start = value; }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
