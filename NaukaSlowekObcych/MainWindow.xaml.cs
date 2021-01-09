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
        //proba
        public MainWindow()
        {
            InitializeComponent();
            testSingleton();
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
    }
}
