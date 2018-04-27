using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assn2_11
{
    class jrvarsity_HSBasketball : HS_Basketball
    {
        private string position;
        private int age;

        public jrvarsity_HSBasketball()
            : base()
        {
            position = "unknown";
            age = 0;
        }
        public jrvarsity_HSBasketball(string id, string fname,
            string lname, string pos, int pAge)
            : base(id, lname, fname)
        {
            position = pos;
            age = pAge;
        }
    }

}
