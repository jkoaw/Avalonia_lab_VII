using Avalonia.Controls;
using Avalonia.Interactivity;
using DynamicData;
using System.Collections.Generic;
using System.Diagnostics;

namespace Avalonia_lab_VII.Views;

public partial class MainView : UserControl
{
    string pom = "";
    List<int> pomocy = new List<int>();
    List<string> pomocyy = new List<string>();
    List<TextBlock> labele = new List<TextBlock>();
    public MainView()
    {
        InitializeComponent();
        labele.Add(label1);
        labele.Add(label2);
        labele.Add(label3);
        labele.Add(label4);
        labele.Add(label5);
        labele.Add(label6);
    }
    public void doit(object source, RoutedEventArgs args)
    {
        if (tojestto.Text.Length < 1)
        {
            return;
        }
        int pomocnicza = -1;
        string cos = tojestto.Text;
        pom = "";
        for (int i = 0; i < cos.Length - 4; i++)
        {
            pom = cos.Substring(i, 4);
            pomocnicza = pomocyy.FindIndex(x => x == pom);
            if (pomocnicza != -1)
            {
                pomocy[pomocnicza] += 1;
            }
            else
            {
                pomocyy.Add(pom);
                pomocy.Add(1);
            }
        }
        int z = 0;
        int ahhhh = 0;
        pom = "";
        for (int i = 0; i < pomocyy.Count; i++)
        {
            pom += pomocyy[i];
            pom += ": ";
            pom += pomocy[i];
            if (ahhhh == 4)
            {
                labele[z].Text = pom;
                pom = "";
                ahhhh = 0;
                z++;
            }
            else
            {
                pom += ";";
                ahhhh++;
            }
        }
        if (pom != "")
        {
            labele[z].Text = pom;
            pom = "";
        }
    }
}
