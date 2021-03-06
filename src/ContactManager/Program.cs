﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace ContactManager
{
  static class Program
  {
    public const string Namespace = "http://www.mapa.com/apps/paige/ContactManager";

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      SkinManager.EnableFormSkins();
      SkinManager.Default.RegisterAssembly(typeof(Office2010BlackBlue).Assembly);
      UserLookAndFeel.Default.SetSkinStyle("Office2010BlackBlue");

      Application.Run(new MainForm());
    }
  }
}
