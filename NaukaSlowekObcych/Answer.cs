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
        

       public override List<Word> generateAnswerList()
        {            
            IPolaczenie p1 = WordStorage.GetPolaczenie();
            for (int i = 0; i < p1.lenght(); i++)
            {
                Word word = new Word(p1.get(i).getPolish(), p1.get(i).getEnglish());
                answers.Add(word);
            }
            return answers;
       }
    }
}
