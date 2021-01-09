using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class Question
    {
        Word word;
        List<Word> answers = new List<Word>();
        int questionid;
        Level level;
        //siema

        void Request() { }

        //Od state
        private IState state;

        public Question(IState state)
        {
            this.ChangeState(state);
        }


        public void ChangeState(IState state)
        {
            this.state = state;
            this.state.SetQuestion(this);
        }
        //Koniec od state

    }
}
