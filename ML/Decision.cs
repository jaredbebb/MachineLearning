using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Decision
    {
        private int yes;
        private int no;
        int error;

        public Decision()
        {
            this.yes = 0;
            this.no = 0;
        }
        public int getYes()
        {
            return yes;
        }
        public int getNo()
        {
            return no;
        }
        public void setYes(int yes)
        {
            this.yes = yes;
        }
        public void setNo(int no)
        {
            this.no = no;
        }

        public void setError()
        {
            //if yes <= no, then error = yes. Else error = no
            error  = ((yes <= no) ? yes : no);
        }
        public int getError()
        {
            return error;
        }
    }
}
