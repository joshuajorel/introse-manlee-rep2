using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    public class Address
    {
        private UInt16 stno;

        public UInt16 Stno
        {
            get { return stno; }
            set { stno = value; }
        }
        private string addline;

        public string Addline
        {
            get { return addline; }
            set { addline = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string region;

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        public Address()
        {
            stno = 0;
            addline = "";
            city = "";
            region = "";

        }
        public Address(UInt16 n, string a, string c, string r)
        {
            stno = n;
            addline = a;
            city = c;
            region = r;
        }
    }
}
