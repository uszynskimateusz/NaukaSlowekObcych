﻿using System;
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
            
            answers.Add(new Word("pies", "dog"));
            answers.Add(new Word("kot", "cat"));
            answers.Add(new Word("rózga", "rod"));
            answers.Add(new Word("witam", "hello"));
            answers.Add(new Word("siema", "yobro"));
            return answers;
       }
    }
}
