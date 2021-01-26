using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class Answer : AnswerInterface
    {
       List<Word> answers = new List<Word>();

       public override List<Word> generateAnswerList(IPolaczenie polaczenie)
        {            
            for (int i = 0; i < polaczenie.lenght(); i++)
            {
                Word word = new Word(polaczenie.get(i).getPolish(), polaczenie.get(i).getEnglish());
                answers.Add(word);
            }
            return answers;
       }
    }
}
