using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DandD.Models
{
    public class apiData: BaseDataObject
    {
        int error_code = 0;
        string msg = string.Empty;
        string name = string.Empty;
        string attribute = string.Empty;
        int val;
        
        [PrimaryKey, AutoIncrement]
        public int ApiID { get; set; }

        public int Error_Code
        {
            get { return error_code; }
            set { SetProperty(ref error_code, value); }
        }

        public string Msg
        {
            get { return msg; }
            set { SetProperty(ref msg, value); }
        }

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        public string Attribute
        {
            get { return attribute; }
            set { SetProperty(ref attribute, value); }
        }

        public int Value
        {
            get { return val; }
            set { SetProperty(ref val, value); }
        }

        public string concat { get { return Attribute + ": " + Value; } }

    }
}
