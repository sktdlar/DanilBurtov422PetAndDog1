using DanilBurtov422PetAndDog.Components.DataBase;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DanilBurtov422PetAndDog
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static DanilBurtov422_PetsEntities db = new DanilBurtov422_PetsEntities(); 
    } 
}
