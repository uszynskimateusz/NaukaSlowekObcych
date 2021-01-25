using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class MixFour : AnswerDecorator
    {
        public MixFour(AnswerInterface answerInterface) : base(answerInterface)
        {

        }
        public override List<Word> generateAnswerList()
        {
            List<Word> answerhidden = new List<Word>(base.generateAnswerList());

            Random rng = new Random();

            int n = answerhidden.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Word value = answerhidden[k];
                answerhidden[k] = answerhidden[n];
                answerhidden[n] = value;
            }


            return answerhidden;
        }
    }
}
