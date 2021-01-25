using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NaukaSlowekObcych
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String rightword;
        int languageside = 0;
        int start = 0;
        int flag = 0;
        int automaticrun = 0;
        int pkt = 0;
     

        //proba
        public MainWindow()
        {
            InitializeComponent();

            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
            label1.Visibility = Visibility.Hidden;
            labelsentence.Visibility = Visibility.Hidden;
            btnlvl1.Visibility = Visibility.Hidden;
            btnlvl2.Visibility = Visibility.Hidden;
            btnlvl3.Visibility = Visibility.Hidden;
            btnlvl4.Visibility = Visibility.Hidden;
            btnlvl5.Visibility = Visibility.Hidden;
            btnlangeng.Visibility = Visibility.Hidden;
            btnlangpolish.Visibility = Visibility.Hidden;
            labelchooselang.Visibility = Visibility.Hidden;
            btncheck.Visibility = Visibility.Hidden;
            textbox1.Visibility = Visibility.Hidden;

            labelrunlvlagain.Visibility = Visibility.Hidden;


        }




       public void Level4()
        {
            //poziom z 5cioma przyciskami

            Random rnd = new Random();
            int wordwelookingfor;
            wordwelookingfor = rnd.Next(0, 5);

            AnswerInterface answer = new Answer();
            answer = new MixFive(answer);
            List<Word> testowy = new List<Word>(answer.generateAnswerList());


            if(languageside == 0)
            {
                label1.Content = testowy[wordwelookingfor].english;
                rightword = testowy[wordwelookingfor].polish;


                button1.Content = testowy[0].polish;
                button2.Content = testowy[1].polish;
                button6.Content = testowy[2].polish;
                button4.Content = testowy[3].polish;
                button5.Content = testowy[4].polish;
            }
           
            if(languageside == 1)
            {
                label1.Content = testowy[wordwelookingfor].polish;
                rightword = testowy[wordwelookingfor].english;


                button1.Content = testowy[0].english;
                button2.Content = testowy[1].english;
                button6.Content = testowy[2].english;
                button4.Content = testowy[3].english;
                button5.Content = testowy[4].english;
            }
          
        }

        public void Level3()
        {
            //poziom z 4roma przyciskami

            Random rnd = new Random();
            int wordwelookingfor;
            wordwelookingfor = rnd.Next(0, 4);

            AnswerInterface answer = new AnswerFour();
            answer = new MixFour(answer);
            List<Word> testowy = new List<Word>(answer.generateAnswerList());


            if (languageside == 0)
            {
                label1.Content = testowy[wordwelookingfor].english;
                rightword = testowy[wordwelookingfor].polish;


                button1.Content = testowy[0].polish;
                button2.Content = testowy[1].polish;
                button6.Content = testowy[2].polish;
                button4.Content = testowy[3].polish;

            }

            if (languageside == 1)
            {
                label1.Content = testowy[wordwelookingfor].polish;
                rightword = testowy[wordwelookingfor].english;


                button1.Content = testowy[0].english;
                button2.Content = testowy[1].english;
                button6.Content = testowy[2].english;
                button4.Content = testowy[3].english;

            }

        }

        public void Level2()
        {
            //poziom z 3ma przyciskami

            Random rnd = new Random();
            int wordwelookingfor;
            wordwelookingfor = rnd.Next(0, 3);

            AnswerInterface answer = new AnswerThree();
            answer = new MixThree(answer);
            List<Word> testowy = new List<Word>(answer.generateAnswerList());

       

            if (languageside == 0)
            {
                label1.Content = testowy[wordwelookingfor].english;
                rightword = testowy[wordwelookingfor].polish;


                button1.Content = testowy[0].polish;
                button2.Content = testowy[1].polish;
                button6.Content = testowy[2].polish;

            }

            if (languageside == 1)
            {
                label1.Content = testowy[wordwelookingfor].polish;
                rightword = testowy[wordwelookingfor].english;


                button1.Content = testowy[0].english;
                button2.Content = testowy[1].english;
                button6.Content = testowy[2].english;

            }


        }

        public void Level1()
        {
            //poziom z 2ma przyciskami


            Random rnd = new Random();
            int wordwelookingfor;
            wordwelookingfor = rnd.Next(0, 2);

            AnswerInterface answer = new AnswerTwo();
            answer = new MixThree(answer);
            List<Word> testowy = new List<Word>(answer.generateAnswerList());


            if (languageside == 0)
            {
                label1.Content = testowy[wordwelookingfor].english;
                rightword = testowy[wordwelookingfor].polish;


                button1.Content = testowy[0].polish;
                button2.Content = testowy[1].polish;

            }

            if (languageside == 1)
            {
                label1.Content = testowy[wordwelookingfor].polish;
                rightword = testowy[wordwelookingfor].english;


                button1.Content = testowy[0].english;
                button2.Content = testowy[1].english;

            }




        }

       public  void Level5() 
       {
            Random rnd = new Random();
            int wordwelookingfor;
            wordwelookingfor = rnd.Next(0, 5);

            AnswerInterface answer = new Answer();

            List<Word> listforanswer = new List<Word>(answer.generateAnswerList());

           // btnlvl1.Content = listforanswer[wordwelookingfor].english;
            rightword = listforanswer[wordwelookingfor].english;

            answer = new HideLetters(answer);


            List<Word> testowy = new List<Word>(answer.generateAnswerList());

            textbox1.Text = testowy[wordwelookingfor].english;

            label1.Content = testowy[wordwelookingfor].polish;

       
       }

        public void LevelTest()
        {
            
            
                Random rnd = new Random();
                int wordwelookingfor;
                wordwelookingfor = rnd.Next(0, 5);

                AnswerInterface answer = new Answer();
                answer = new MixFive(answer);
                List<Word> testowy = new List<Word>(answer.generateAnswerList());

                label1.Content = testowy[wordwelookingfor].polish;
                rightword = testowy[wordwelookingfor].english;

                button1.Content = testowy[0].english;
                button2.Content = testowy[1].english;
                button6.Content = testowy[2].english;
                button4.Content = testowy[3].english;
                button5.Content = testowy[4].english;

            automaticrun++;
            if (automaticrun == 6)
            {
                checklabel.Content = "Twoje punkty: " + pkt;
            }
        }





        public void testSingleton()
        {
            IPolaczenie p1 = WordStorage.GetPolaczenie();
            IPolaczenie p2 = WordStorage.GetPolaczenie();
            IPolaczenie p3 = WordStorage.GetPolaczenie();


            p1.add(new Word("polski", "polish"));
            p2.add(new Word("kot", "cat"));
            p3.add(new Word("pies", "dog"));

            Console.WriteLine("P1 --------------------------");
            Console.WriteLine(p1.get(0).getPolish());
            Console.WriteLine(p1.get(1).getPolish());
            Console.WriteLine(p1.get(2).getPolish());

            Console.WriteLine("P2 --------------------------");
            Console.WriteLine(p2.get(0).getPolish());
            Console.WriteLine(p2.get(1).getPolish());
            Console.WriteLine(p2.get(2).getPolish());

            Console.WriteLine("P3 --------------------------");
            Console.WriteLine(p3.get(0).getPolish());
            Console.WriteLine(p3.get(1).getPolish());
            Console.WriteLine(p3.get(2).getPolish());

            DatabaseFacade databaseFacade = new EntityFramework();
            databaseFacade.addWord();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (button1.Content.ToString() == rightword && flag == 4)
            {
                checklabel.Content = "Super !";
                Level4();
            }

            if (button1.Content.ToString() == rightword && flag == 3)
            {
                checklabel.Content = "Super 2";
                Level3();
            }

            if (button1.Content.ToString() == rightword && flag == 2)
            {
                checklabel.Content = "Super 2";
                Level2();
            }

            if (button1.Content.ToString() == rightword && flag == 1)
            {
                checklabel.Content = "Super 1";
                Level1();
            }

            if(flag == 6 && automaticrun < 6 )
            {
                if (button1.Content.ToString() == rightword)
                {
                    pkt++;
                }
                LevelTest();
            }

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (button2.Content.ToString() == rightword && flag == 4)
            {
                checklabel.Content = "Super 4";
                Level4();
            }

            if (button2.Content.ToString() == rightword && flag == 3)
            {
                checklabel.Content = "Super 3";
                Level3();
            }

            if (button2.Content.ToString() == rightword && flag == 2)
            {
                checklabel.Content = "Super 2";
                Level2();
            }

            if (button2.Content.ToString() == rightword && flag == 1)
            {
                checklabel.Content = "Super 1";
                Level1();
            }

            if (flag == 6 && automaticrun < 6)
            {
                if (button2.Content.ToString() == rightword)
                {
                    pkt++;
                }
                LevelTest();
            }

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (button6.Content.ToString() == rightword && flag == 4)
            {
                checklabel.Content = "Super !";
                Level4();
            }

            if (button6.Content.ToString() == rightword && flag == 3)
            {
                checklabel.Content = "Super 2";
                Level3();
            }

            if (button6.Content.ToString() == rightword && flag == 2)
            {
                checklabel.Content = "Super 2";
                Level2();
            }

            if (button6.Content.ToString() == rightword && flag == 1)
            {
                checklabel.Content = "Super 1";
                Level1();
            }

            if (flag == 6 && automaticrun < 6)
            {
                if (button6.Content.ToString() == rightword)
                {
                    pkt++;
                }
                LevelTest();
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (button4.Content.ToString() == rightword && flag == 4)
            {
                checklabel.Content = "Super !";
                Level4();
            }

            if (button4.Content.ToString() == rightword && flag == 3)
            {
                checklabel.Content = "Super 2";
                Level3();
            }

            if (button4.Content.ToString() == rightword && flag == 2)
            {
                checklabel.Content = "Super 2";
                Level2();
            }

            if (button4.Content.ToString() == rightword && flag == 1)
            {
                checklabel.Content = "Super 1";
                Level1();
            }

            if (flag == 6 && automaticrun < 6)
            {
                if (button4.Content.ToString() == rightword)
                {
                    pkt++;
                }
                LevelTest();
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (button5.Content.ToString() == rightword && flag == 4)
            {
                checklabel.Content = "Super !";
                Level4();
            }

            if (button5.Content.ToString() == rightword && flag == 3)
            {
                checklabel.Content = "Super 2";
                Level3();
            }

            if (button5.Content.ToString() == rightword && flag == 2)
            {
                checklabel.Content = "Super 2";
                Level2();
            }

            if (button5.Content.ToString() == rightword && flag == 1)
            {
                checklabel.Content = "Super 1";
                Level1();
            }

            if (flag == 6 && automaticrun < 6)
            {
                if (button5.Content.ToString() == rightword)
                {
                    pkt++;
                }
                LevelTest();
            }

        }

        private void btnlearn_Click(object sender, RoutedEventArgs e)
        {
            btnlvl1.Visibility = Visibility.Visible;
            btnlvl2.Visibility = Visibility.Visible;
            btnlvl3.Visibility = Visibility.Visible;
            btnlvl4.Visibility = Visibility.Visible;
            btnlvl5.Visibility = Visibility.Visible;
            btnlangeng.Visibility = Visibility.Visible;
            btnlangpolish.Visibility = Visibility.Visible;
            labelchooselang.Visibility = Visibility.Visible;

            labelwelcome.Visibility = Visibility.Hidden;
            btnlearn.Visibility = Visibility.Hidden;
            btntest.Visibility = Visibility.Hidden;

          
            
        }

        private void btntest_Click(object sender, RoutedEventArgs e)
        {

            button1.Visibility = Visibility.Visible;
            button2.Visibility = Visibility.Visible;
            button6.Visibility = Visibility.Visible;
            button4.Visibility = Visibility.Visible;
            button5.Visibility = Visibility.Visible;


            label1.Visibility = Visibility.Visible;
            labelsentence.Visibility = Visibility.Visible;

            labelwelcome.Visibility = Visibility.Hidden;
            btnlearn.Visibility = Visibility.Hidden;
            btntest.Visibility = Visibility.Hidden;

            flag = 6;
            pkt = 0;
            automaticrun = 0;
            LevelTest();

        }

        private void btnlvl1_Click(object sender, RoutedEventArgs e)
        {
            labelrunlvlagain.Visibility = Visibility.Hidden;
            flag = 1;

            button1.Visibility = Visibility.Visible;
            button2.Visibility = Visibility.Visible;

            button6.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;

            label1.Visibility = Visibility.Visible;
            labelsentence.Visibility = Visibility.Visible;

            btncheck.Visibility = Visibility.Hidden;
            textbox1.Visibility = Visibility.Hidden;

            Level1();
        }

        private void btnlvl2_Click(object sender, RoutedEventArgs e)
        {
            labelrunlvlagain.Visibility = Visibility.Hidden;
            flag = 2;

            button1.Visibility = Visibility.Visible;
            button2.Visibility = Visibility.Visible;
            button6.Visibility = Visibility.Visible;

            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;

            label1.Visibility = Visibility.Visible;
            labelsentence.Visibility = Visibility.Visible;

            btncheck.Visibility = Visibility.Hidden;
            textbox1.Visibility = Visibility.Hidden;

            Level2();
        }

        private void btnlvl3_Click(object sender, RoutedEventArgs e)
        {
            labelrunlvlagain.Visibility = Visibility.Hidden;
            flag = 3;

            button1.Visibility = Visibility.Visible;
            button2.Visibility = Visibility.Visible;
            button6.Visibility = Visibility.Visible;
            button4.Visibility = Visibility.Visible;

            button5.Visibility = Visibility.Hidden;

            label1.Visibility = Visibility.Visible;
            labelsentence.Visibility = Visibility.Visible;

            btncheck.Visibility = Visibility.Hidden;
            textbox1.Visibility = Visibility.Hidden;

            Level3();
        }

        private void btnlvl4_Click(object sender, RoutedEventArgs e)
        {
            labelrunlvlagain.Visibility = Visibility.Hidden;
            flag = 4;

            button1.Visibility = Visibility.Visible;
            button2.Visibility = Visibility.Visible;
            button6.Visibility = Visibility.Visible;
            button4.Visibility = Visibility.Visible;
            button5.Visibility = Visibility.Visible;

            btncheck.Visibility = Visibility.Hidden;
            textbox1.Visibility = Visibility.Hidden;

            label1.Visibility = Visibility.Visible;
            labelsentence.Visibility = Visibility.Visible;
            Level4();

        }

        private void btnlangpolish_Click(object sender, RoutedEventArgs e)
        {
            labelrunlvlagain.Visibility = Visibility.Visible;
            languageside = 0;
        }

        private void btnlangeng_Click(object sender, RoutedEventArgs e)
        {
            labelrunlvlagain.Visibility = Visibility.Visible;
            languageside = 1;
        }

        private void btnlvl5_Click(object sender, RoutedEventArgs e)
        {
            flag = 5;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;

            btncheck.Visibility = Visibility.Visible;
            textbox1.Visibility = Visibility.Visible;

            label1.Visibility = Visibility.Visible;
            labelsentence.Visibility = Visibility.Visible;

            Level5();
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btncheck_Click(object sender, RoutedEventArgs e)
        {
            if(textbox1.Text.ToString() == rightword)
            {
                Level5();
            }
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
            label1.Visibility = Visibility.Hidden;
            labelsentence.Visibility = Visibility.Hidden;
            btnlvl1.Visibility = Visibility.Hidden;
            btnlvl2.Visibility = Visibility.Hidden;
            btnlvl3.Visibility = Visibility.Hidden;
            btnlvl4.Visibility = Visibility.Hidden;
            btnlvl5.Visibility = Visibility.Hidden;
            btnlangeng.Visibility = Visibility.Hidden;
            btnlangpolish.Visibility = Visibility.Hidden;
            labelchooselang.Visibility = Visibility.Hidden;
            btncheck.Visibility = Visibility.Hidden;
            textbox1.Visibility = Visibility.Hidden;

            labelwelcome.Visibility = Visibility.Visible;
            btnlearn.Visibility = Visibility.Visible;
            btntest.Visibility = Visibility.Visible;
        }
    }
}
