using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class Word
    {
        string polish;
        string english;

        public Word (string polish, string english)
        {

            this.polish = polish;
            this.english = english;
        }

        public String getPolish()
        {
            return polish;
        }

        public String getEnglish()
        {
            return english;
        }
    }
}
