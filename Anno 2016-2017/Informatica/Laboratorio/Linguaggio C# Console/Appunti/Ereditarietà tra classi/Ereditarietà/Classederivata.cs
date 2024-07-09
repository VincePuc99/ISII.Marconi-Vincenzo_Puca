namespace Ereditarietà
{
    class Classederivata : Base
    {
        //costruttori e proprietà
        private string s;
        //classic
        public Classederivata() : base() //con :base() chiama il costruttore di default della calsse richiesta
        {
            s= "";
        }

        //overloaded
        public Classederivata(int a1,double b1,string s1) : base( a1,b1)
        {
            s = s1;
        }

        public string S
        {
            get { return s; }
            set { s = value; }
        }
    }
}
