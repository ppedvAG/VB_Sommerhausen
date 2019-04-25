﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using HalloKlassen;
using Microsoft.Win32;

namespace AutoGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //HalloKlassen.Auto einAauto = new HalloKlassen.Auto();

            Auto einAuto = new Auto
            {
                Leistung = 346,
                Farbe = "Rot",
                AnzahlTüren = 12,
                Kraftstoffsorte = "E99"
            };

            Auto deinAuto = new Auto
            {
                Leistung = 46
            };

            var nochEinAuto = new Auto
            {
                Leistung = 5445
            };

            List<Auto> autoListe = new List<Auto>();
            autoListe.Add(einAuto);
            autoListe.Add(deinAuto);
            autoListe.Insert(0, nochEinAuto);

            myGrid.ItemsSource = autoListe;

        }

        void ZeigeAuto(Auto einAuto)
        {
            //MessageBox.Show($"Farbe: {einAuto.Farbe}\nLeistung: {einAuto.Leistung}");
            MessageBox.Show(string.Join("\n", einAuto.GetType().GetProperties().ToList().Select(x => $"{x.Name} {x.GetValue(einAuto, null)}")));
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //VB: 'dim selectedAuto = TryCast(myGrid.SelectedItem, Auto)
            //VB: If not selectedAuto is Nothing then
            if (myGrid.SelectedItem is Auto selectedAuto) //vb: trycast
            {
                ZeigeAuto(selectedAuto);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Title = "Wo sollten die Autos gespeichert werden?";
            dlg.Filter = "Autodatei|*.txt|Alles und mit Scharf!|*.*";
            if (dlg.ShowDialog().Value)
            {
                var sw = new StreamWriter(dlg.FileName, true);

                var listeAutos = myGrid.ItemsSource as List<Auto>;
                var trenn = ";";
                foreach (var auto in listeAutos)
                {
                    sw.Write(auto.AnzahlTüren);
                    sw.Write(trenn);
                    sw.Write(auto.BauJahr);
                    sw.Write(trenn);
                    sw.Write(auto.Farbe);
                    sw.Write(trenn);
                    sw.Write(auto.Innenausstattug);
                    sw.Write(trenn);
                    sw.Write(auto.Kraftstoffsorte);
                    sw.Write(trenn);
                    sw.Write(auto.Leistung);
                    sw.Write(trenn);
                    sw.Write(auto.Umweltklasse);
                    sw.WriteLine(trenn);
                }
                sw.Close();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            var dlg = new OpenFileDialog();
            dlg.Filter = "Autodatei|*.txt|Alles und mit Scharf!|*.*";
            if (dlg.ShowDialog().Value)
            {
                var sr = new StreamReader(dlg.FileName);

                var listeAutos = new List<Auto>();
                var trenn = ';';
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var chunks = line.Split(trenn);
                    listeAutos.Add(new Auto()
                    {
                        AnzahlTüren = int.Parse(chunks[0]),
                        BauJahr = DateTime.Parse(chunks[1]),
                        Farbe = chunks[2],
                        Innenausstattug = bool.Parse(chunks[3]),
                        Kraftstoffsorte = chunks[4],
                        Leistung = int.Parse(chunks[5]),
                        Umweltklasse = int.Parse(chunks[6])
                    });
                }
                sr.Close();
                myGrid.ItemsSource = listeAutos;

            }
        }
    }
}
