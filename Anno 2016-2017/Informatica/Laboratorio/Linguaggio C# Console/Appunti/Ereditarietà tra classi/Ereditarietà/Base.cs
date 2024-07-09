namespace Ereditarietà
{
    class Base
    {
        //attributi
        protected int a;
        protected double b;
        //costruttore
        public Base()
        {
            a = 0;
            b = 0.0;
        }
        //overloaded
        public Base(int a1, double b1)
        {
            a = a1;
            b = b1;
        }
        //proprietà
        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

    }
}
