using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    public interface IPolaczenie
    {
        Word get(int index);
        int lenght();
        void add(Word word);
        void edit(Word word, Word newWord);
        void remove(Word word);
    }
}
