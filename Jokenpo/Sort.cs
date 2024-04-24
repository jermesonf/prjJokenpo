using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    public class Sort
    {
        Random rd = new Random();

        public int Sorteio()
        {
           
            int randomico = rd.Next(3);
            int randomico2 = rd.Next(3);
            return randomico2;
            return randomico;
        }

    }
}
