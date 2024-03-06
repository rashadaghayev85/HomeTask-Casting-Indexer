using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_Casting_Operatoroverloding_Indexer
{
    internal class Player
    {
        public int Id { get; set; }
        public int Age { get; set; }

        public static bool operator >(Player pla1,Player pla2)
        {
            return pla1.Age > pla2.Age;
        }
        public static bool operator <(Player pla1, Player pla2)
        {
            return pla1.Age < pla2.Age;
        }
    }
}
