﻿using System;
using RT.Util.ExtensionMethods;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using KtaneStuff.Modeling;
using RT.PostBuild;
using RT.Util;
using RT.Util.Geometry;
using RT.Util.Consoles;
using System.Collections.Generic;

[assembly: AssemblyTitle("KtaneStuff")]
[assembly: AssemblyDescription("Contains some ancillary code used in the creation of some Keep Talking and Nobody Explodes mods.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("KtaneStuff")]
[assembly: AssemblyCopyright("Copyright © Timwi 2016–2020")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: Guid("95055383-2e25-42be-97b7-e1411a695e1d")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

namespace KtaneStuff
{
    partial class Program
    {
        [STAThread]
        static int Main(string[] args)
        {
            try { Console.OutputEncoding = Encoding.UTF8; }
            catch { }

            if (args.Length == 2 && args[0] == "--post-build-check")
                return PostBuildChecker.RunPostBuildChecks(args[1], Assembly.GetExecutingAssembly());


            Variety.DoModels();


            Console.WriteLine("Done.");
            Console.ReadLine();
            return 0;
        }
    }
}
