﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Magenta.WannaPlay.UI.WinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // TODO: Add ninject resolution
            new WannaPlayApplication().Run();
        }
    }
}