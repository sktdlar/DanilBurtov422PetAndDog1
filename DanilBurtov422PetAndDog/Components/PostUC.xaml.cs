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
using DanilBurtov422PetAndDog.Components.DataBase;

namespace DanilBurtov422PetAndDog.Components
{
    /// <summary>
    /// Логика взаимодействия для PostUC.xaml
    /// </summary>
    public partial class PostUC : UserControl
    {
        public PostUC(Posts posts)
        {
            InitializeComponent();
            DataContext = posts;
        }
    }
}
