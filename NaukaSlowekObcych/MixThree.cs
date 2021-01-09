using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaSlowekObcych
{
    class MixThree : AnswerDecorator
    {
        public MixThree(AnswerInterface answerInterface) : base(answerInterface)
        {

        }
        public override List<Word> generateAnswerList()
        {
            List<Word> answerhidden = new List<Word>(base.generateAnswerList());

            List<Word> helplist = new List<Word>();


            

            Random rnd = new Random();
            int atmoment;
            int checkflag;
            int[] tabforrandomnumbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                tabforrandomnumbers[i] = 5;
            }
            atmoment = rnd.Next(0, 3);
            tabforrandomnumbers[0] = atmoment;
            helplist.Add(answerhidden[atmoment]);

            for (int i = 1; i < 3; i++)
            {
                checkflag = 0;
                atmoment = rnd.Next(0, 3);
                for (int j = 1; j < 3; j++)
                {
                    if (tabforrandomnumbers[j] == atmoment)
                    {
                        checkflag = -1;
                    }
                }

                if (checkflag != -1)
                {
                    helplist.Add(answerhidden[atmoment]);
                }


            }
  

            return helplist;
        }
    }
}
