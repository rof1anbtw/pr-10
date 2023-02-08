using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface Interface
    {
        T Create<T>(T list);
        T Read<T>(T list, List<dynamic> GetElement);
        T Update<T>(int PosY, T list);
        T Delete<T>(T list, List<dynamic> GetElement);
    }
}