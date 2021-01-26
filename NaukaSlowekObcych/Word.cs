using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
public class Word
   {
        private string polish { get; set; }
        private string english { get; set; }

        public Word(string polish, string english)
        {

            this.polish = polish;
            this.english = english;
        }

        public String getPolish()
        {
            return polish;
        }

        public void setPolish(string polish)
        {
            this.polish = polish;
        }

        public String getEnglish()
        {
            return english;
        }

        public void setEnglish(string english)
        {
            this.english = english;
        }
    }
}
