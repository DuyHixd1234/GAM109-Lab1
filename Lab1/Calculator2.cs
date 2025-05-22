namespace Lab1
{
    public partial class Calculator
    {
        public float Cong()
        {
            return A + B;
        }

        public float Tru()
        {
            return A - B;
        }

        public float Nhan()
        {
            return A * B;
        }

        public float Chia()
        {
            if (B == 0) return 0;
            return A / B;
        }
    }
}
