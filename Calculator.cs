using System.Diagnostics;
using System.Globalization;

namespace CSharp_Calculator
{
    public partial class MainWindow : Form
    {

        private double rezultat = 0;
        private List<double> liczby = new List<double>();
        public string calaCyfra;
        private double calaCyfraDouble;
        private string aktywnaCyfra;









        public MainWindow()
        {
            InitializeComponent();
            Kalkulator();
        }


        private void Kalkulator()
        {
            KalkulatorNowy();
        }
        private void KalkulatorNowy()
        {
            wynik.Text = "00000000";
        }







        private void MainWindow_Load(object sender, EventArgs e)
        {

        }



        private void guz1_Click(object sender, EventArgs e)
        {
            aktywnaCyfra = "1";

            calaCyfra += aktywnaCyfra;
            wynik.Text = calaCyfra;
        }

        private void guz2_Click(object sender, EventArgs e)
        {
            aktywnaCyfra = "2";

            calaCyfra += aktywnaCyfra;
            wynik.Text = calaCyfra;
        }

        private void guz3_Click(object sender, EventArgs e)
        {
            aktywnaCyfra = "3";

            calaCyfra += aktywnaCyfra;
            wynik.Text = calaCyfra;
        }

        private void guz4_Click(object sender, EventArgs e)
        {
            aktywnaCyfra = "4";

            calaCyfra += aktywnaCyfra;
            wynik.Text = calaCyfra;
        }

        private void guz5_Click(object sender, EventArgs e)
        {
            aktywnaCyfra = "5";

            calaCyfra += aktywnaCyfra;
            wynik.Text = calaCyfra;
        }

        private void guz6_Click(object sender, EventArgs e)
        {
            aktywnaCyfra = "6";

            calaCyfra += aktywnaCyfra;
            wynik.Text = calaCyfra;
        }

        private void guz7_Click(object sender, EventArgs e)
        {
            aktywnaCyfra = "7";

            calaCyfra += aktywnaCyfra;
            wynik.Text = calaCyfra;
        }

        private void guz8_Click(object sender, EventArgs e)
        {
            aktywnaCyfra = "8";

            calaCyfra += aktywnaCyfra;
            wynik.Text = calaCyfra;
        }

        private void guz9_Click(object sender, EventArgs e)
        {
            aktywnaCyfra = "9";

            calaCyfra += aktywnaCyfra;
            wynik.Text = calaCyfra;
        }

        private void guz0_Click(object sender, EventArgs e)
        {
            aktywnaCyfra = "0";

            calaCyfra += aktywnaCyfra;
            wynik.Text = calaCyfra;
        }


        private void guzPrzec_Click(object sender, EventArgs e)
        {
            aktywnaCyfra = ".";

            calaCyfra += aktywnaCyfra;
            wynik.Text = calaCyfra;
        }






        private void guzPlus_Click(object sender, EventArgs e)
        {

            if (calaCyfra != null && calaCyfra != "")
            {
                calaCyfraDouble = double.Parse(calaCyfra, CultureInfo.InvariantCulture);
                liczby.Add(calaCyfraDouble);


                if (liczby.Count > 1)
                {
                    rezultat = 0;
                    foreach (double x in liczby)
                    {
                        rezultat += x;
                    }



                    wynik.Text = rezultat.ToString();
                }
                else
                {
                    wynik.Text = calaCyfraDouble.ToString();
                }

                aktywnaCyfra = "";
                calaCyfra = "";
                Debug.WriteLine($"{calaCyfraDouble} caladouble");
                Debug.WriteLine($"{rezultat} rez");
            }
        }



        private void guzWynik_Click(object sender, EventArgs e)
        {
            wynik.Text = calaCyfra;
        }
















        private void guzC_Click(object sender, EventArgs e)
        {
            KalkulatorReset();
        }

        private void guzMinus_Click(object sender, EventArgs e)
        {
            if (calaCyfra != null && calaCyfra != "")
            {
                calaCyfraDouble = double.Parse(calaCyfra, CultureInfo.InvariantCulture);
                liczby.Add(calaCyfraDouble);


                if (liczby.Count > 1)
                {
                    rezultat = liczby[0];
                    for (int i = 1; i < liczby.Count; i++)
                    {
                        rezultat -= liczby[i];
                    }



                    wynik.Text = rezultat.ToString();
                }
                else
                {
                    wynik.Text = calaCyfraDouble.ToString();
                }

                aktywnaCyfra = "";
                calaCyfra = "";
                Debug.WriteLine($"{calaCyfraDouble} caladouble");
                Debug.WriteLine($"{rezultat} rez");
            }
        }

        private void KalkulatorReset()
        {
            aktywnaCyfra = "";
            calaCyfra = "";
            rezultat = 0;
            liczby.Clear();
            wynik.Text = "00000000";
        }



    }
}
