using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class AnswerThree : AnswerInterface
    {

        List<Word> answersthree = new List<Word>();

        public override List<Word> generateAnswerList()
        {

            answersthree.Add(new Word("pies", "dog"));
            answersthree.Add(new Word("kot", "cat"));
            answersthree.Add(new Word("rózga", "rod"));
           
            return answersthree;
        }
    }
}