namespace Data
{
    public class Person
    {
        private int id;
        private string name;
        private bool isMale;

        public int Id { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public bool IsMale { get { return isMale; } }

        public Person(int id, string name, bool isMale)
        {
            this.id = id;
            this.name = name;
            this.isMale = isMale;
        }

        public Person()
        {
        }

        public override string ToString()
        {
            return $"{Id} : {Name} : {IsMale}";
        }
    }
}