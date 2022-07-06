using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TestFourier
{
    class verification
    {
        public int correct;
        public int prcntl;
        public int tempVar;

        public void translation(int n) => tempVar = n;
        public int translationRevers() { return tempVar; }

    }
}
