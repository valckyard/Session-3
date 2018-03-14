using System;

namespace Cours2Objet
{
	public class DevisesMonaitaires
	{
		public DevName Name {
			get;
			set;
		}
		public double Taux {
			get;
			set;
		}

		public DevisesMonaitaires (DevName name, double taux)
		{
			Name = name;
			Taux = taux;
		}
	}



	public enum DevName
	{
		CAD,
		USD,
		EUR,
		GBP
	}
}

