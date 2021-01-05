using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class Question
    {
        private IState state;
        Word word;
        List<Word> answers = new List<Word>();
       
        int questionid;
        Level level;
        //siema


        void Request() { }

        public void SetQuestion(IState state)
        {
            this.state = state;
        }
    }
}
