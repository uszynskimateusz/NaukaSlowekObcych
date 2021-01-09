using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    interface IPolaczenie
    {
        Word get(int index);
        void set(int index, Word word);
        int lenght();
        void add(Word word);
    }
}
