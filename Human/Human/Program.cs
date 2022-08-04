namespace methods
{
    class Human
    {
        
        public Human()
        {
            Console.WriteLine("A new human created...");
        }
        public Human(int weight)
        {
            this.weight = weight;
        }
        public String name;
        private int weight; //public olduğunda setKiloya gerek yok ama private olunca dışarıdan erişebilmek için setKiloyu kullanıyoruz

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value < 0)
                    this.weight = 0;
                else
                    this.weight = value;
            }
        }
        /*
        public void setKilo(int kilo)
        {
            if (kilo < 0)
                this.kilo = 0;
            else
                this.kilo = kilo;
        }

        public int getKilo()
        {
            return kilo;
        } */
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human boy = new Human(62);
            boy.name = "nadir kaya";
            //nadir.Kilo = 62;     //nadir.kilo = 62;

            Human girl = new Human(48);
            girl.name = "zeynep naz ceyhan";
            //zeynep.Kilo = 48;    //zeynep.kilo = 48;

            Console.WriteLine("Nadirin adı: " + boy.name);
            Console.WriteLine("Nadirin kilosu: " + boy.Weight);
            Console.WriteLine("Zeynepin adı: " + girl.name);
            Console.WriteLine("Zeynepin kilosu: " + girl.Weight);

            Console.ReadLine();

        }

    }
}