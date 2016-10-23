namespace ClassLibraryTask1StrongName
{
    public class City
    {
        public string Name
        {
            set;
            get;
        }
        public float Area
        {
            set;
            get;
        }

        public City(string name, float area)
        {
            this.Name = name;
            this.Area = area;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", area: " + Area + " square kilometres";
        }
    }
}
