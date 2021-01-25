using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class LearningMethods
    {
        

        void Level5() 
        {
            AnswerInterface answer = new Answer();
            answer = new MixFive(answer);

            List<Word> testowy = new List<Word>(answer.generateAnswerList());
            //button1.Content = testowy[0].polish;

        }



    }
}
