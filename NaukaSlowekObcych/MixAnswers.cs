using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class MixAnswers : AnswerDecorator
    {
        public MixAnswers(AnswerInterface answerInterface) : base(answerInterface)
        {

        }
        public override List<Word> generateAnswerList(IPolaczenie polaczenie)
        {
            List<Word> answerhidden = new List<Word>(base.generateAnswerList(polaczenie));

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
