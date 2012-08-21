using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    public class Contact
    {
        private int home;

        public int Home
        {
            get { return home; }
            set { home = value; }
        }
        private int work;

        public int Work
        {
            get { return work; }
            set { work = value; }
        }
        private int mobile;

        public int Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        private int other;

        public int Other
        {
            get { return other; }
            set { other = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Contact()
        {
        }
        public Contact(int h, int w, int m, int o)
        {
            home = h;
            work = w;
            mobile = m;
            other = o;
        }
    }
}
