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
        public Question(IState state)
        {
            this.ChangeState(state);
        }

        void Request() { }


        public void ChangeState(IState state)
        {
            this.state = state;
            this.state.SetQuestion(this);
        }
    }
}
