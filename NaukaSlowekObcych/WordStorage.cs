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
        private WordStorage() { }
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

            public void set(int index, Word word)
            {
                wordStorage.words[index - 1] = word;
            }

            public int lenght()
            {
                return wordStorage.words.Count;
            }

            public void add(Word word)
            {
                wordStorage.words.Add(word);
            }
        }
    }
}
