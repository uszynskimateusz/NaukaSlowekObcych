using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
   abstract class AnswerDecorator : AnswerInterface
    {
        protected AnswerInterface _answerInterface;


        public AnswerDecorator(AnswerInterface answerInterface)
        {
            _answerInterface = answerInterface;
        }

        public override List<Word> generateAnswerList()
        {
            return _answerInterface.generateAnswerList();
        }

    }
}
