using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    abstract class IState
    {
        protected Question question;
        public void SetQuestion(Question question)
        {
            this.question = question;
        }
        public abstract void GetPoint();

    }
}
