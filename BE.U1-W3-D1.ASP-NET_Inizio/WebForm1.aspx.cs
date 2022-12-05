using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE.U1_W3_D1.ASP_NET_Inizio
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ListItem item1 = new ListItem("Sala Nord", "1");
                ListItem item2 = new ListItem("Sala Est", "2");
                ListItem item3 = new ListItem("Sala Sud", "3");
                DropDownList.Items.Add(item1);
                DropDownList.Items.Add(item2);
                DropDownList.Items.Add(item3);
            }
        }



        public class Prenotazione
        {
            private string _nome;

            public string Nome { get { return _nome; } set { _nome = value; } }

            private string _cognome;

            public string Cognome { get { return _cognome; } set { _cognome = value; } }

            private bool _bigliettoRidotto;

            public bool BigliettoRidotto { get { return _bigliettoRidotto; } set { _bigliettoRidotto = value; } }

            private string _salaCinema;

            public string SalaCinema { get { return _salaCinema; } set { _salaCinema = value; } }

            private static List<Prenotazione> _listaPrenotazioni = new List<Prenotazione>();

            public static List<Prenotazione> ListaPrenotazioni { get { return _listaPrenotazioni; } set { _listaPrenotazioni = value; } }
        }

        


        protected void Buttone_Click(object sender, EventArgs e)
        {
            var ridotto = bigliettoRidoto.Checked;
            int sala = Convert.ToInt16(DropDownList.SelectedValue);
            if (sala == 1)
            {
                TotPrenotazione("Sala Nord", ridotto);
            }
            else if (sala == 2)
            {
                TotPrenotazione("Sala Est", ridotto);
            }
            else if (sala == 3)
            {
                TotPrenotazione("Sala Sud", ridotto);
            }
        }

        private void TotPrenotazione(string SalaCinema, bool check)
        {
            Prenotazione p = new Prenotazione();
            p.Nome = NomeSpettatore.Text;
            p.Cognome = CognomeSpettatore.Text;
            p.BigliettoRidotto = check;
            p.SalaCinema = SalaCinema;
            Prenotazione.ListaPrenotazioni.Add(p);

            BigliettiVenduti();
        }

        private void BigliettiVenduti()
        {
            int BvendutiN = 0;
            int BridottiN = 0;
            int BvendutiE = 0;
            int BridottiE = 0;
            int BvendutiS = 0;
            int BridottiS = 0;

            foreach (Prenotazione i in Prenotazione.ListaPrenotazioni) 
            {
                if (i.SalaCinema == "Sala Nord")
                {
                    BvendutiN += 1;
                    if (i.BigliettoRidotto)
                    {
                        BridottiN += 1;
                    }
                }
                else if (i.SalaCinema == "Sala Est" )
                {
                    BvendutiE += 1;
                    if (i.BigliettoRidotto)
                    {
                        BridottiE += 1;
                    }
                }
                else if (i.SalaCinema == "Sala Sud")
                {
                    BvendutiS += 1;
                    if (i.BigliettoRidotto)
                    {
                        BridottiS += 1;
                    }
                }
            }

            SN_venduto.Text = $"{BvendutiN}";
            SN_ridotto.Text = $"{BridottiN}";
            SE_venduto.Text = $"{BvendutiE}";
            SE_ridotto.Text = $"{BridottiE}";
            SS_venduto.Text = $"{BvendutiS}";
            SS_ridotto.Text = $"{BridottiS}";

        }
    }
}