using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class AnswerTwo : AnswerInterface
    {

        List<Word> answers = new List<Word>();



        public override List<Word> generateAnswerList()
        {

            answers.Add(new Word("pies", "dog"));
            answers.Add(new Word("kot", "cat"));
           
            return answers;
        }
    }
}

