using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    interface DatabaseFacade
    {
        Word getRandomWord();
        void SaveChanges();
        void addWord();
        void removeWord(Word word);
    }
}
