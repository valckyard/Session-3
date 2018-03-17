namespace LibS3.C3
{
    public class TaxesC3
    {
        public double Tvq { get; private set; }
        public double Tps { get; private set; }

        public TaxesC3(double tvq, double tps)
        {
            Tvq = tvq;
            Tps = tps;
        }
    }
}
