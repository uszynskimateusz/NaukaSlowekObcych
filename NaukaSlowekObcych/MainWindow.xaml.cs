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
        int flag = 0;
        int automaticrun = 0;
        int pkt = 0;

        Language language;
        IPolaczenie polaczenie;
            
        //proba
        public MainWindow()
        {
            InitializeComponent();

            welcomeGrid.Visibility = Visibility.Visible;
            learnGrid.Visibility = Visibility.Hidden;
            testGrid.Visibility = Visibility.Hidden;

            polaczenie = WordStorage.GetPolaczenie();

            language = new Language(new StateTest());
        }

       private void Level4()
        {
            //poziom z 5cioma przyciskami
            AnswerInterface answer = new Answer();
            answer = new MixAnswers(answer);
            List<Word> testowy = new List<Word>(answer.generateAnswerList(polaczenie));
            List<Word> helplistwo = new List<Word>();
            
            Random rnd = new Random();
            int wordwelookingfor;
            wordwelookingfor = rnd.Next(0, 5);


            helplistwo.Add(testowy[wordwelookingfor]);

            int i = 0; ;
            while(helplistwo.Count-1 <5)
            {
                if (helplistwo[0] != testowy[i])
                {
                    helplistwo.Add(testowy[i]);
                }
                i++;
            }
               
            if (languageside == 0)
            {
                wordLabel.Content = testowy[wordwelookingfor].getEnglish();
                rightword = testowy[wordwelookingfor].getPolish();

                answerButton1.Content = testowy[0].getPolish();
                answerButton2.Content = testowy[1].getPolish();
                answerButton3.Content = testowy[2].getPolish();
                answerButton4.Content = testowy[3].getPolish();
                answerButton5.Content = testowy[4].getPolish();
            } else if(languageside == 1)
            {
                wordLabel.Content = testowy[wordwelookingfor].getPolish();
                rightword = testowy[wordwelookingfor].getEnglish();

                answerButton1.Content = testowy[0].getEnglish();
                answerButton2.Content = testowy[1].getEnglish();
                answerButton3.Content = testowy[2].getEnglish();
                answerButton4.Content = testowy[3].getEnglish();
                answerButton5.Content = testowy[4].getEnglish();
            } 
        }

        private void Level3()
        {
            //poziom z 4roma przyciskami

            Random rnd = new Random();
            int wordwelookingfor;
            wordwelookingfor = rnd.Next(0, 4);

            AnswerInterface answer = new Answer();
            answer = new MixAnswers(answer);
            List<Word> testowy = new List<Word>(answer.generateAnswerList(polaczenie));

            
            if (languageside == 0)
            {
                wordLabel.Content = testowy[wordwelookingfor].getEnglish();
                rightword = testowy[wordwelookingfor].getPolish();

                answerButton1.Content = testowy[0].getPolish();
                answerButton2.Content = testowy[1].getPolish();
                answerButton3.Content = testowy[2].getPolish();
                answerButton4.Content = testowy[3].getPolish();
            }

            if (languageside == 1)
            {
                wordLabel.Content = testowy[wordwelookingfor].getPolish();
                rightword = testowy[wordwelookingfor].getEnglish();

                answerButton1.Content = testowy[0].getEnglish();
                answerButton2.Content = testowy[1].getEnglish();
                answerButton3.Content = testowy[2].getEnglish();
                answerButton4.Content = testowy[3].getEnglish();
            }
        }

        private void Level2()
        {
            //poziom z 3ma przyciskami
            Random rnd = new Random();
            int wordwelookingfor;
            wordwelookingfor = rnd.Next(0, 3);

            AnswerInterface answer = new Answer();
            answer = new MixAnswers(answer);
            List<Word> testowy = new List<Word>(answer.generateAnswerList(polaczenie));

            if (languageside == 0)
            {
                wordLabel.Content = testowy[wordwelookingfor].getEnglish();
                rightword = testowy[wordwelookingfor].getPolish();


                answerButton1.Content = testowy[0].getPolish();
                answerButton2.Content = testowy[1].getPolish();
                answerButton3.Content = testowy[2].getPolish();
            }

            if (languageside == 1)
            {
                wordLabel.Content = testowy[wordwelookingfor].getPolish();
                rightword = testowy[wordwelookingfor].getEnglish();

                answerButton1.Content = testowy[0].getEnglish();
                answerButton2.Content = testowy[1].getEnglish();
                answerButton3.Content = testowy[2].getEnglish();
            }
        }

        private void Level1()
        {
            //poziom z 2ma przyciskami
            Random rnd = new Random();
            int wordwelookingfor;
            wordwelookingfor = rnd.Next(0, 2);

            AnswerInterface answer = new Answer();
            answer = new MixAnswers(answer);
            List<Word> testowy = new List<Word>(answer.generateAnswerList(polaczenie));

            if (languageside == 0)
            {
                wordLabel.Content = testowy[wordwelookingfor].getEnglish();
                rightword = testowy[wordwelookingfor].getPolish();

                answerButton1.Content = testowy[0].getPolish();
                answerButton2.Content = testowy[1].getPolish();
            }

            if (languageside == 1)
            {
                wordLabel.Content = testowy[wordwelookingfor].getPolish();
                rightword = testowy[wordwelookingfor].getEnglish();

                answerButton1.Content = testowy[0].getEnglish();
                answerButton2.Content = testowy[1].getEnglish();
            }
        }

       private void Level5() 
       {
            Random rnd = new Random();
            int wordwelookingfor;
            wordwelookingfor = rnd.Next(0, 5);

            AnswerInterface answer = new Answer();
            List<Word> listforanswer = new List<Word>(answer.generateAnswerList(polaczenie));

            rightword = listforanswer[wordwelookingfor].getEnglish();

            answer = new HideLetters(answer);
            List<Word> testowy = new List<Word>(answer.generateAnswerList(polaczenie));

            answerTextBox.Text = testowy[wordwelookingfor].getEnglish();
            wordLabel.Content = testowy[wordwelookingfor].getPolish();
       }

        private void LevelTest()
        {
            Random rnd = new Random();
            int wordwelookingfor;
            wordwelookingfor = rnd.Next(0, 5);

            AnswerInterface answer = new Answer();
            answer = new MixAnswers(answer);
            List<Word> testowy = new List<Word>(answer.generateAnswerList(polaczenie));

            wordTestLabel.Content = testowy[wordwelookingfor].getPolish();
            rightword = testowy[wordwelookingfor].getEnglish();

            answerTestButton1.Content = testowy[0].getEnglish();
            answerTestButton2.Content = testowy[1].getEnglish();
            answerTestButton3.Content = testowy[2].getEnglish();
            answerTestButton4.Content = testowy[3].getEnglish();
            answerTestButton5.Content = testowy[4].getEnglish();
            
            automaticrun++;
            if (automaticrun == 6)
            {
                MessageBoxResult result = MessageBox.Show("Twoje punkty: " + pkt, "Wynik testu");

                switch (result)
                {
                    case MessageBoxResult.OK:
                        testGrid.Visibility = Visibility.Hidden;
                        welcomeGrid.Visibility = Visibility.Visible;
                        break;
                }
             }
        }

        private void buttonAnswerClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if(button.Content.ToString() == rightword && flag == 4)
            {
                Level4();
            } else if (button.Content.ToString() == rightword && flag == 3)
            {
                Level3();
            } else if (button.Content.ToString() == rightword && flag == 2)
            {
                Level2();
            } else if (button.Content.ToString() == rightword && flag == 1)
            {
                Level1();
            }

            if (flag == 6 && automaticrun < 6)
            {
                if (button.Content.ToString() == rightword)
                {
                    pkt++;
                }
                LevelTest();
            }
        }

        private void learnButtonClick(object sender, RoutedEventArgs e)
        {
            welcomeGrid.Visibility = Visibility.Hidden;
            testGrid.Visibility = Visibility.Hidden;
            learnGrid.Visibility = Visibility.Visible;

            answerButton1.Visibility = Visibility.Hidden;
            answerButton2.Visibility = Visibility.Hidden;
            answerButton3.Visibility = Visibility.Hidden;
            answerButton4.Visibility = Visibility.Hidden;
            answerButton5.Visibility = Visibility.Hidden;

            sentenceLabel.Visibility = Visibility.Hidden;
            wordLabel.Visibility = Visibility.Hidden;
            answerTextBox.Visibility = Visibility.Hidden;
            checkButton.Visibility = Visibility.Hidden;
            runLvlAgainLabel.Visibility = Visibility.Hidden;
        }

        private void testButtonClick(object sender, RoutedEventArgs e)
        {
            welcomeGrid.Visibility = Visibility.Hidden;
            learnGrid.Visibility = Visibility.Hidden;

            testGrid.Visibility = Visibility.Visible;

            flag = 6;
            pkt = 0;
            automaticrun = 0;
            LevelTest();
        }

        private void setLvl1Visibility()
        {
            answerButton1.Visibility = Visibility.Visible;
            answerButton2.Visibility = Visibility.Visible;
            answerButton3.Visibility = Visibility.Hidden;
            answerButton4.Visibility = Visibility.Hidden;
            answerButton5.Visibility = Visibility.Hidden;

            answerTextBox.Visibility = Visibility.Hidden;
            checkButton.Visibility = Visibility.Hidden;

            runLvlAgainLabel.Visibility = Visibility.Hidden;
        }

        private void setLvl2Visibility()
        {
            answerButton1.Visibility = Visibility.Visible;
            answerButton2.Visibility = Visibility.Visible;
            answerButton3.Visibility = Visibility.Visible;
            answerButton4.Visibility = Visibility.Hidden;
            answerButton5.Visibility = Visibility.Hidden;

            answerTextBox.Visibility = Visibility.Hidden;
            checkButton.Visibility = Visibility.Hidden;

            runLvlAgainLabel.Visibility = Visibility.Hidden;
        }

        private void setLvl3Visibility()
        {
            answerButton1.Visibility = Visibility.Visible;
            answerButton2.Visibility = Visibility.Visible;
            answerButton3.Visibility = Visibility.Visible;
            answerButton4.Visibility = Visibility.Visible;
            answerButton5.Visibility = Visibility.Hidden;

            answerTextBox.Visibility = Visibility.Hidden;
            checkButton.Visibility = Visibility.Hidden;

            runLvlAgainLabel.Visibility = Visibility.Hidden;
        }

        private void setLvl4Visibility()
        {
            answerButton1.Visibility = Visibility.Visible;
            answerButton2.Visibility = Visibility.Visible;
            answerButton3.Visibility = Visibility.Visible;
            answerButton4.Visibility = Visibility.Visible;
            answerButton5.Visibility = Visibility.Visible;

            answerTextBox.Visibility = Visibility.Hidden;
            checkButton.Visibility = Visibility.Hidden;

            runLvlAgainLabel.Visibility = Visibility.Hidden;
        }

        private void setLvl5Visibility()
        {
            answerButton1.Visibility = Visibility.Hidden;
            answerButton2.Visibility = Visibility.Hidden;
            answerButton3.Visibility = Visibility.Hidden;
            answerButton4.Visibility = Visibility.Hidden;
            answerButton5.Visibility = Visibility.Hidden;

            answerTextBox.Visibility = Visibility.Visible;
            checkButton.Visibility = Visibility.Visible;

            runLvlAgainLabel.Visibility = Visibility.Hidden;
        }


        private void levelButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            sentenceLabel.Visibility = Visibility.Visible;
            wordLabel.Visibility = Visibility.Visible;

            if (button.Name == lvl1Button.Name)
            {
                setLvl1Visibility();

                flag = 1;
                Level1();
            } else if (button.Name == lvl2Button.Name)
            {
                setLvl2Visibility();

                flag = 2;
                Level2();
            } else if (button.Name == lvl3Button.Name)
            {
                setLvl3Visibility();

                flag = 3;
                Level3();
            } else if (button.Name == lvl4Button.Name)
            {
                setLvl4Visibility();

                flag = 4;
                Level4();
            } else if (button.Name == lvl5Button.Name)
            {
                setLvl5Visibility();

                flag = 5;
                Level5();
            }
        }

        private void languagePolishClick(object sender, RoutedEventArgs e)
        {
            language.ChangeState(new StateLearn());
            runLvlAgainLabel.Visibility = Visibility.Visible;
            languageside = language.GetPoint();
        }

        private void languageEnglishClick(object sender, RoutedEventArgs e)
        {
            language.ChangeState(new StateTest());
            runLvlAgainLabel.Visibility = Visibility.Visible;
            languageside = language.GetPoint();
        }

        private void checkButtonClick(object sender, RoutedEventArgs e)
        {
            if (answerTextBox.Text.ToString() == rightword)
            {
                Level5();
            }
        }

        private void backButtonClick(object sender, RoutedEventArgs e)
        {
            welcomeGrid.Visibility = Visibility.Visible;
            learnGrid.Visibility = Visibility.Hidden;
            testGrid.Visibility = Visibility.Hidden;
            baseGrid.Visibility = Visibility.Hidden;
        }

        private void addWordButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(polishWordTextBox.Text) && string.IsNullOrWhiteSpace(englishWordTextBox.Text))
            { } else 
            {
                polaczenie.add(new Word(polishWordTextBox.Text.ToString(), englishWordTextBox.Text.ToString()));
            }
            polishWordTextBox.Text = " ";
            englishWordTextBox.Text = " ";
        }

        private void deleteWordButton_Click(object sender, RoutedEventArgs e)
        {
            Word word = (Word)wordListComboBox.SelectedItem;
            polaczenie.remove(word);
        }

        private void manageWordButton_Click(object sender, RoutedEventArgs e)
        {
            List<Word> words = new List<Word>();

            for (int i = 0; i < polaczenie.lenght(); i++)
            {
                words.Add(polaczenie.get(i));
            }
            wordListComboBox.ItemsSource = words;

            welcomeGrid.Visibility = Visibility.Hidden;
            baseGrid.Visibility = Visibility.Visible;
        }

        private void editWordButton_Click(object sender, RoutedEventArgs e)
        {
            Word word = (Word)wordListComboBox.SelectedItem;

            if (string.IsNullOrWhiteSpace(polishWordTextBox.Text) && string.IsNullOrWhiteSpace(englishWordTextBox.Text))
            { }
            else
            {
                polaczenie.edit(word, new Word(polishWordTextBox.Text.ToString(), englishWordTextBox.Text.ToString()));
            }
            polishWordTextBox.Text = " ";
            englishWordTextBox.Text = " ";
        }

        private void messageBoxButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, world!");
        }
    }
}
