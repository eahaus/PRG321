using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assn2_11
{
    public partial class HS_Basketball : Form
    {
        private string playerPosition;
        private string lastName;
        private string firstName;
        private int age;

        public HS_Basketball()
        {
            playerPosition = "";
            lastName = "unknown";
            firstName = string.Empty;
            age = 0;
        }
        public HS_Basketball(string pp, string lname, string fname, int anAge)
        {
            playerPosition = pp;
            lastName = lname;
            firstName = fname;
            age = anAge;
        }
        public HS_Basketball(string pp, string lname, string fname)
        {
            playerPosition = pp;
            lastName = lname;
            firstName = fname;
            age = 0;
        }
        public HS_Basketball(string pp)
        {
            playerPosition = pp;
            lastName = "unknown";
            firstName = string.Empty;
            age = 0;
        }
       
          
        
    }
}
