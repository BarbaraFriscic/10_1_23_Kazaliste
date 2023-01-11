using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_23_Kazaliste
{
    internal class Rezervacija
    {
		public string Ime { get; set; }

		private int brKarata;

		public int BrKarata
		{
			get { return brKarata; }
			set 
			{
				if (value <= 5 && value >= 1)
					brKarata = value;
				else
					throw new ArgumentException("Moguće je rezervirati najviše 5 karata.");
			}
		}
		private string tipSjedala;

		public string TipSjedala
		{
			get { return tipSjedala; }
			set 
			{
				tipSjedala = value; 
			}
		}
		public string BrRezervacije()
		{
			int x = new Random().Next(10000,99999);
			return $"{Ime}-{x}";
		}
		public double CijenaRezervacije()
		{
			if (TipSjedala == "Parter")
				return BrKarata * 30;
			else
				return BrKarata * 45;
		}

	}
}
