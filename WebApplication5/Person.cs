namespace WebApplication5
{
    public class Person

    {
        public string Name { get; set; } = "";
        public int Age { get; set; } = 0;
        public String Specialization { get; set; } = "";


        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nSpecialization: {Specialization}";
        }

    }

}
