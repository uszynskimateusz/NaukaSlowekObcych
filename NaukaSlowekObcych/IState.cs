using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    abstract class IState
    {
        protected Language language;
        public void SetLanguageState(Language language)
        {
            this.language = language;
        }
        public abstract int GetPoint();
    }
}
