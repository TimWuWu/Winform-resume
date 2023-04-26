using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume
{
    public class Job:ICloneable
    {
        private string companyName;
        private string title;
        private string duty;
        private string input;
        private string output;

        public string CompanyName 
        { 
            get { return companyName; } 
            set 
            { 
                companyName = value;
                OnPropertyChanged(nameof(CompanyName));
            } 
        }
        public string Title 
        { 
            get { return title; } 
            set 
            { 
                title = value; 
                OnPropertyChanged(nameof(Title)); 
            } 
        }
        public string Duty 
        { 
            get { return duty; } 
            set 
            { 
                duty = value;
                OnPropertyChanged(nameof(Duty));
            } 
        }
        public string Input 
        { 
            get { return input; } 
            set 
            { 
                input = value;
                OnPropertyChanged(nameof(Input));
            } 
        }
        public string Output 
        { 
            get { return output; } 
            set 
            { 
                output = value; 
                OnPropertyChanged(nameof(Output));
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
