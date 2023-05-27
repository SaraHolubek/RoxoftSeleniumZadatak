using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxoftSeleniumZadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unesite naziv automobila! ");
            string naziv = Console.ReadLine();

            Console.WriteLine("Unesite godinu proizvodnje! ");
            int godinaProizvodnje = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite osnovnu cijenu! ");
            double osnovnaCijena = double.Parse(Console.ReadLine());





            Automobil auto = new Automobil(naziv, godinaProizvodnje, osnovnaCijena);

            auto.NaPromjenuGodineProizvodnje += new Automobil.NaPromjenuGodineProizvodnjeDelegat(PromjenaGodineProizvodnje);

            auto.Naziv = naziv;
            auto.GodinaProizvodnje = godinaProizvodnje;
            auto.OsnovnaCijena = osnovnaCijena;

            auto.VratiDetalje();
            Console.ReadKey();
        }

        private static void PromjenaGodineProizvodnje(object sender, EventArgs e)
        {
            Automobil automobil = (Automobil)sender;
            Console.WriteLine("Starost automobila: {0} godina ", automobil.Starost);

        }


        public class Automobil
        {
            private string naziv;
            private int godinaProizvodnje;
            private double osnovnaCijena;

            public string Naziv
            {
                get
                {
                    return naziv;
                }
                set
                {
                    naziv = value;
                }
            }

            public Automobil(string Naziv, int GodinaProizvodnje, double OsnovnaCijena)
            {
                this.Naziv = Naziv;
                this.GodinaProizvodnje = GodinaProizvodnje;
                this.OsnovnaCijena = OsnovnaCijena;
            }

            public int tekucaGodina;
            public int Starost
            {
                get
                {
                    int tekucaGodina = 2023;
                    return tekucaGodina - GodinaProizvodnje;

                }

            }

            public double OsnovnaCijena
            {
                get
                {
                    return osnovnaCijena;
                }
                set
                {
                    if (value > 0)
                    {
                        osnovnaCijena = value;
                    }
                    else
                    {
                        Exception ex = new Exception("Možete unijeti samo pozitivan broj!");
                        throw ex;
                    }
                }
            }


            public double IzracunajPostotak
            {
                get
                {

                    if (osnovnaCijena <= 70000)
                    {
                        return osnovnaCijena * 1.3;
                    }
                    else if (70000 < osnovnaCijena || osnovnaCijena < 100000)
                    {
                        return osnovnaCijena * 1.4;
                    }
                    else if (osnovnaCijena > 70000 || osnovnaCijena >= 100000)
                    {
                        return osnovnaCijena * 1.5;
                    }
                    else
                    {
                        return IzracunajPostotak;
                    }

                }

            }
            public double UkupnaCijena()
            {
                return this.osnovnaCijena * this.IzracunajPostotak;
            }



            public delegate void NaPromjenuGodineProizvodnjeDelegat(object sender, EventArgs e);
            public event NaPromjenuGodineProizvodnjeDelegat NaPromjenuGodineProizvodnje;


            public int GodinaProizvodnje
            {
                get
                {
                    return godinaProizvodnje;
                }
                set
                {
                    godinaProizvodnje = value;
                    if (NaPromjenuGodineProizvodnje != null)
                    {
                        NaPromjenuGodineProizvodnje(this, new EventArgs());

                    }
                }
            }

            public void VratiDetalje()
            {

                Console.WriteLine("Naziv automobila: {0}", this.naziv);
                Console.WriteLine("Godina proizvodnje automobila: {0}. godina", this.godinaProizvodnje);
                Console.WriteLine("Osnovna cijena automobila: {0} kn", this.osnovnaCijena);
                Console.WriteLine("Ukupna cijena automobila: {0} kn", this.UkupnaCijena());

            }
        }
    }
}
