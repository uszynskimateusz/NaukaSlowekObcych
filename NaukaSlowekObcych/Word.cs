using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
public class Word
   {
        public string polish { get; set; }
        public string english { get; set; }

        public Word(string polish, string english)
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
