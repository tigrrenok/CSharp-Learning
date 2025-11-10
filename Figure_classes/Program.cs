using System;
using System.Globalization;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System.Collections.Generic;
using static Figure_classes.Utils;

namespace Figure_classes
{
    class Program
    {
        public static void Main()
        {
            Figure figure = new Figure(3, "красный", 6.3, "серый");
            figure.Draw();
        }

    }
}