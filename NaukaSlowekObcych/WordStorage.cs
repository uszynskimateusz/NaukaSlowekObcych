using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class WordStorage
    {
        private List<Word> words = new List<Word>();
        DatabaseFacade databaseFacade;
        private WordStorage() {
            databaseFacade = new EntityFramework();
            words = databaseFacade.getWords();
        }
        public static IPolaczenie GetPolaczenie()
        {
            return Polaczenie.getInstance();
        }

        private class Polaczenie : IPolaczenie
        {
            private WordStorage wordStorage;

            private static Polaczenie _instance;

            public Polaczenie(WordStorage wordStorage)
            {
                this.wordStorage = wordStorage;
            }

            public static IPolaczenie getInstance()
            {
                if (_instance == null)
                {
                    WordStorage wordStorage = new WordStorage();
                    _instance = new Polaczenie(wordStorage);
                }
                return _instance;
            }

            public Word get(int index)
            {
                if (wordStorage.words[index] == null)
                {
                    return null;
                }
                return wordStorage.words[index];
            }

            public int lenght()
            {
                return wordStorage.words.Count;
            }

            public void add(Word word)
            {
                wordStorage.words.Add(word);
                wordStorage.databaseFacade.addWord(word);
            }

            public void edit(Word word, Word newWord)
            {
                foreach(Word oldWord in wordStorage.words)
                {
                    if (oldWord.getPolish() == word.getPolish() && oldWord.getEnglish() == word.getEnglish())
                    {
                        oldWord.polish = newWord.getPolish();
                        oldWord.english = newWord.getEnglish();
                        wordStorage.databaseFacade.editWord(oldWord, newWord);
                    }
                }
            }

            public void remove(Word word)
            {
                wordStorage.words.Remove(word);
                wordStorage.databaseFacade.removeWord(word);
            }
        }
    }
}
