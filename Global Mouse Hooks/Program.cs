﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_Mouse_Hooks
{
    class Program
    {
        static void Main(string[] args)
        {
            ClickDetector.ListenForMouseEvents();
            
            //Run the app as a windows forma application
            Application.Run(new ApplicationContext());
        }
    }
}
