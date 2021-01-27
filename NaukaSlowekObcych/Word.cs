using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
public class Word
   {
        private string Polish;
        public string polish
        {
            get { return Polish; }
            set { Polish = value; }
        }

        private string English;
        public string english { 
            get { return English; }
            set { English = value; }
        }

        public Word(string polish, string english)
        {
            this.polish = polish;
            this.english = english;
        }
    }
}
