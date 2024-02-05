using KR2_Stepanova.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KR2_Stepanova
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static KR2_StepanovaEntities1 DB = new KR2_StepanovaEntities1();
        public static User loggedUser;
    }
}
