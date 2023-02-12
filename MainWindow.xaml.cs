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
using System.IO;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using System.Dynamic;
using System.ComponentModel;

namespace ujprojekt_2023._02
{
    public partial class MainWindow : Window
    {
        
        int click = 1;
        
        List<Adatok> tanulok = new List <Adatok>();
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            
            if (Open.ShowDialog() == true)
            {
                foreach (var item in File.ReadLines(Open.FileName))
                {
                    Adatok diak = new Adatok(item);
                    tanulok.Add(diak);
                }
            }
            Grid1.ItemsSource = tanulok;
            Grid1.AlternatingRowBackground = Brushes.Gray;

            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog Save = new SaveFileDialog();
            if (Save.ShowDialog() == true)
            {
                StreamWriter sw = new StreamWriter(Save.FileName);
                for (int i = 0; i < tanulok.Count; i++)
                {
                    sw.WriteLine(tanulok[i].nev + "," + tanulok[i].hazi1 + "," + tanulok[i].hazi2 + "," + tanulok[i].hazi3 + "," + tanulok[i].hazi4 + "," + tanulok[i].hazi5 + "," + tanulok[i].hazi6 + "," + tanulok[i].hazi7 + "," + tanulok[i].hazi8);
                }
                sw.Close();
            }
        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {
            int hazik = 0;
            for (int i = 0; i < tanulok.Count; i++)
            {
                if (tanulok[i].hazi1 == "")
                { hazik++; }
                if (tanulok[i].hazi2 == "")
                { hazik++; }
                if (tanulok[i].hazi3 == "")
                { hazik++; }
                if (tanulok[i].hazi4 == "")
                { hazik++; }
                if (tanulok[i].hazi5 == "")
                { hazik++; }
                if (tanulok[i].hazi6 == "")
                { hazik++; }
                if (tanulok[i].hazi7 == "")
                { hazik++; }
                if (tanulok[i].hazi8 == "")
                { hazik++; }


                Label.Content = hazik;

            }
        }
        
        private void AddC_Click(object sender, RoutedEventArgs e)
        {
            click++;
            DataGridTextColumn textColumn = new DataGridTextColumn();
            textColumn.Header = "Házi "+ click;
            textColumn.Binding = new Binding("hazi");
            Grid1.Columns.Add(textColumn);

        }


        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Grid1_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex()).ToString();
        }
    }
}

//Mivel az iskolában az órákon minimális lehetőségünk volt ezzel a feladattal foglalkozni és az otthoni időpontegyeztetések sem túl egyszerűek (mindenkinek más időpontban vannak edzések és más különböző elfoglaltságok) ezért ezalatt a minimális idő alatt amit a projekttel tudott a csapat foglalkozni, így sikerült megoldania feladatot. Üdvözlettel: Nádházi Nándor, Túri Viktor, Nyíri Antal.
