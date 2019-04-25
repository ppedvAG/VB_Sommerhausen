using System.Collections.Generic;
using System.Windows;
using HalloKlassen;

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
            MessageBox.Show($"Farbe: {einAuto.Farbe}\nLeistung: {einAuto.Leistung}");
        }

    }
}
