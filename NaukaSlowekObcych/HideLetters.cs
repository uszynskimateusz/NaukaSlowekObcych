using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class HideLetters : AnswerDecorator
    {
        public HideLetters(AnswerInterface answerInterface) : base(answerInterface)
        {
        }
       public override List<Word> generateAnswerList(IPolaczenie polaczenie)
       {
            List<Word> answerhidden = new List<Word>(base.generateAnswerList(polaczenie));

            foreach ( Word item in answerhidden)
            {      
                item.english = item.english.Remove(1);
            }

            return answerhidden;
        }
    }
}
