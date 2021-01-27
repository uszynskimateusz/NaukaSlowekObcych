using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    interface DatabaseFacade
    {
        List<Word> getWords();
        void addWord(Word word);
        void removeWord(Word word);
        void editWord(Word word, Word editWord);
    }
}
