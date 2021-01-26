using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    public abstract class IState
    {
        public Word word;
        public void SetWordState(Word word)
        {
            this.word = word;
        }
        public abstract int GetPoint();

    }
}
