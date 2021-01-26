using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class Language
    {
        private IState state;

        public Language(IState state)
        {
            this.state = state;
        }
        public void ChangeState(IState state)
        {
            this.state = state;
            this.state.SetLanguageState(this);
        }

        public int GetPoint()
        {
            return state.GetPoint();
        }
    }
}
