using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikal
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("DOBRODOSLI");

			Artikal A1 = new Artikal("jogurt", "23412", 200, 25);
			A1.Izracunajmarzu();
			Console.WriteLine($"Artikal {A1.imeartikla} sa sifrom {A1.sifra} i ulaznom cenom od {A1.cena}din. " +
				$"marzom  od {A1.marza}%, marza iznosi {A1.Izracunajmarzu()}" );

			Console.ReadKey();			
		}
	}
	class Artikal
	{
		public string imeartikla;
		public string sifra;
		public decimal cena;
		public decimal marza;
		public Artikal(string imeartikla, string sifra, decimal cena, decimal marza)
		{
			this.imeartikla = imeartikla;
			this.sifra = sifra;
			this.cena = cena;
			this.marza = marza;

		}

		public decimal Izracunajmarzu()
		{
			return  cena  * (1 + (decimal)marza / 100);
			
		}

	}


}