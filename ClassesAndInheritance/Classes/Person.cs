namespace Classes.PersonObject
{
    public abstract class Person
    {
        public string name;
        public uint age;

        protected Person(uint age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public override string ToString()
        {
            return age + " " + name;
        }
    }
}