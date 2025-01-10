namespace tim_yppgift_sokningar
{
    public class Person
    {
        private int personnr;
        private string namn;
        public Person(int p, string n)
        {
            personnr = p;
            namn = n;
        }

        public string Namn
        {
            set{ Namn = value; }
            get{ return Namn; }
        }

         public int Personnr
        {
            set{ personnr = value; }
            get{ return personnr; }
        }
    }
}