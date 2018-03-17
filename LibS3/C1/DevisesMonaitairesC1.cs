namespace LibS3.C1
{
	public class DevisesMonaitairesC1
	{
		public DevName Name {
			get;
			set;
		}
		public double Taux {
			get;
			set;
		}

		public DevisesMonaitairesC1 (DevName name, double taux)
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

