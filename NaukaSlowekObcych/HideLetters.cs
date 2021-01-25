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
       public override List<Word> generateAnswerList()
        {
            List<Word> answerhidden = new List<Word>(base.generateAnswerList());


            //dlaczego item.english =  item.english.Remove(1); zamiast item.english.Remove(1);



  
            foreach ( Word item in answerhidden)
            {      
                  item.english =  item.english.Remove(1);
            }

            return answerhidden;
        }

        
    }
}
