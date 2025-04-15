using System.Diagnostics;
using System.Globalization;

namespace CSharp_Calculator
{
    public partial class MainWindow : Form
    {

        private double rezultat = 0;
        private List<double> liczby = new List<double>();
        public string calaCyfra = "";
        private double calaCyfraDouble = 0;
        private string aktywnaCyfra = "";
        private string dzialaniePoprzednie = "";
        private bool pierwszeDzialanie = true;
        private bool zmianaUzyty = false;
        double zmienna = 0;





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
                if (dzialaniePoprzednie != "dodawanie" && dzialaniePoprzednie != "")
                {
                    calaCyfraDouble = double.Parse(calaCyfra, CultureInfo.InvariantCulture);
                    KalkulatorDzialanie(dzialaniePoprzednie, calaCyfraDouble);
                }
                else
                {
                    calaCyfraDouble = double.Parse(calaCyfra, CultureInfo.InvariantCulture);
                    KalkulatorDzialanie("dodawanie", calaCyfraDouble);
                }

            }
            else
            {
                //pass
            }
            calaCyfra = "";
            aktywnaCyfra = "";
            dzialaniePoprzednie = "dodawanie";
        }


        private void guzMinus_Click(object sender, EventArgs e)
        {

            if (calaCyfra != null && calaCyfra != "")
            {
                if (dzialaniePoprzednie != "odejmowanie" && dzialaniePoprzednie != "")
                {
                    calaCyfraDouble = double.Parse(calaCyfra, CultureInfo.InvariantCulture);
                    KalkulatorDzialanie(dzialaniePoprzednie, calaCyfraDouble);
                }
                else
                {
                    calaCyfraDouble = double.Parse(calaCyfra, CultureInfo.InvariantCulture);
                    KalkulatorDzialanie("odejmowanie", calaCyfraDouble);
                }

            }
            calaCyfra = "";
            aktywnaCyfra = "";
            calaCyfraDouble = 0;
            dzialaniePoprzednie = "odejmowanie";
        }
        private void guzRazy_Click(object sender, EventArgs e)
        {
            if (calaCyfra != null && calaCyfra != "")
            {
                if (dzialaniePoprzednie != "mnozenie" && dzialaniePoprzednie != "")
                {
                    calaCyfraDouble = double.Parse(calaCyfra, CultureInfo.InvariantCulture);
                    KalkulatorDzialanie(dzialaniePoprzednie, calaCyfraDouble);
                }
                else
                {
                    calaCyfraDouble = double.Parse(calaCyfra, CultureInfo.InvariantCulture);
                    KalkulatorDzialanie("mnozenie", calaCyfraDouble);
                }

            }
            calaCyfra = "";
            aktywnaCyfra = "";
            calaCyfraDouble = 0;
            dzialaniePoprzednie = "mnozenie";
        }

        private void guzDziel_Click(object sender, EventArgs e)
        {
            if (calaCyfra != null && calaCyfra != "")
            {
                if (dzialaniePoprzednie != "dzielenie" && dzialaniePoprzednie != "")
                {
                    calaCyfraDouble = double.Parse(calaCyfra, CultureInfo.InvariantCulture);
                    KalkulatorDzialanie(dzialaniePoprzednie, calaCyfraDouble);
                }
                else
                {
                    calaCyfraDouble = double.Parse(calaCyfra, CultureInfo.InvariantCulture);
                    KalkulatorDzialanie("dzielenie", calaCyfraDouble);
                }

            }
            calaCyfra = "";
            aktywnaCyfra = "";
            calaCyfraDouble = 0;
            dzialaniePoprzednie = "dzielenie";
        }

        private void guzWynik_Click(object sender, EventArgs e)
        {
            if (calaCyfra != null && calaCyfra != "")
            {
                calaCyfraDouble = double.Parse(calaCyfra, CultureInfo.InvariantCulture);
                KalkulatorDzialanie(dzialaniePoprzednie, calaCyfraDouble);
            }
            wynik.Text = Convert.ToString(rezultat);
            calaCyfra = "";
            aktywnaCyfra = "";
            calaCyfraDouble = 0;

        }



        private void guzC_Click(object sender, EventArgs e)
        {
            KalkulatorReset();
        }

        private void KalkulatorDzialanie(string dzialanie, double liczba)
        {
            if (dzialanie == "dodawanie")
            {
                KalkulatorDodawanie(liczba);
            }
            else if (dzialanie == "odejmowanie")
            {
                KalkulatorOdejmowanie(liczba);
            }
            else if (dzialanie == "mnozenie")
            {
                KalkulatorMozenie(liczba);
            }
            else if (dzialanie == "dzielenie")
            {
                KalkulatorDzielenie(liczba);
            }
            else
            {

            }
        }

        private void KalkulatorDodawanie(double liczba)
        {
            if (pierwszeDzialanie)
            {
                rezultat = liczba; pierwszeDzialanie = false;
            }
            else
            {
                rezultat += liczba;
            }
            calaCyfraDouble = 0;
            wynik.Text = Convert.ToString(rezultat);
            dzialaniePoprzednie = "dodawanie";
        }

        private void KalkulatorOdejmowanie(double liczba)
        {
            if (pierwszeDzialanie)
            {
                rezultat = liczba; pierwszeDzialanie = false;
            }
            else
            {
                rezultat -= liczba;
            }
            calaCyfraDouble = 0;
            wynik.Text = Convert.ToString(rezultat);
            dzialaniePoprzednie = "odejmowanie";
        }

        private void KalkulatorMozenie(double liczba)
        {
            if (pierwszeDzialanie)
            {
                rezultat = liczba; pierwszeDzialanie = false;
            }
            else
            {
                rezultat *= liczba;
            }
            calaCyfraDouble = 0;
            wynik.Text = Convert.ToString(rezultat);
            dzialaniePoprzednie = "mnozenie";
        }

        private void KalkulatorDzielenie(double liczba)
        {
            if (pierwszeDzialanie)
            {
                rezultat = liczba; pierwszeDzialanie = false;
                wynik.Text = Convert.ToString(rezultat);
            }
            else
            {
                if (calaCyfraDouble != 0 || liczba != 0)
                {
                    rezultat /= liczba;
                    wynik.Text = Convert.ToString(rezultat);
                }
                else if (calaCyfraDouble == 0 || liczba == 0)
                {
                    wynik.Text = "error";
                }
            }
            calaCyfraDouble = 0;
            dzialaniePoprzednie = "dzielenie";
        }



        private void KalkulatorReset()
        {
            aktywnaCyfra = "";
            calaCyfra = "";
            rezultat = 0;
            liczby.Clear();
            wynik.Text = "00000000";
            pierwszeDzialanie = true;
            zmianaUzyty = false;
            guzZmiana.BackColor = Color.SlateBlue;
            guzZmiana.Enabled = true;
        }

        private void guzZmiana_Click(object sender, EventArgs e)
        {
            if (!zmianaUzyty && calaCyfra != "")
            {
                zmienna = double.Parse(calaCyfra, CultureInfo.InvariantCulture);
                zmienna = zmienna * (-1);
                calaCyfra = zmienna.ToString();
                wynik.Text = calaCyfra;
                zmianaUzyty = true;
                guzZmiana.BackColor = Color.DarkSlateBlue;
                guzZmiana.Enabled = false;
            }
        }


    }
}
