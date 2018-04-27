using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assn2_11
{
    class varsity_HSBasketball : HS_Basketball
    {
        private string position;
        private int playerNum;

        public varsity_HSBasketball()
            : base()
        {
            position = "unknown";
            playerNum = 0;
        }
        public varsity_HSBasketball(string id, string fname,
            string lname, string pos, int pNum)
            : base(id, lname, fname)
        {
            position = pos;
            playerNum = pNum;
        }
    }
   
}
