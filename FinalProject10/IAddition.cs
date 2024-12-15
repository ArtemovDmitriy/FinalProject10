using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject10
{
    internal interface IAddition
    {
        long Sum(long Value1, long Value2);
        void ShowResult(long Value1, long Value2, long result);
    }
}
