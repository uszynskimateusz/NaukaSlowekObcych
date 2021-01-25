using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class AnswerFour : AnswerInterface
    {

        List<Word> answersfour = new List<Word>();



        public override List<Word> generateAnswerList()
        {

            answersfour.Add(new Word("pies", "dog"));
            answersfour.Add(new Word("kot", "cat"));
            answersfour.Add(new Word("rózga", "rod"));
            answersfour.Add(new Word("witam", "hello"));
            return answersfour;
        }
    }
}
