using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class StateTest : IState
    {
        public override int GetPoint()
        {
            //tu jesli if prawdziwy np slowo nauczone to wtedy stan sie zmieni
            return 0;
        }
    }
}
