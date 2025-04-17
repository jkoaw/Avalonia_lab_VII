using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Diagnostics;

namespace Avalonia_lab_VII.Views;

public partial class MainView : UserControl
{

    public MainView()
    {
        InitializeComponent();
    }
    public void doit(object source, RoutedEventArgs args)
    {
        int pomocnicza = -1;
        string cos = tojestto.Text;
        string pom = "";
        List<int> pomocy = new List<int>();
        List<string> pomocyy = new List<string>();
        for (int i = 0; i < cos.Length - 4; i++)
        {
            pom = cos.Substring(i, 4);
            for (int j = 0; j < pomocyy.Count; j++)
            {
                if (pom == pomocyy[j])
                {
                    pomocnicza = j;
                    break;
                }
            }
            if (pomocnicza != -1)
            {

            }
        }
    }
}
