



class Interfejsy
{





    static void Main(string[] args)
    {

        Mag mag = new Mag();
        Knight knight = new Knight();
        Batman batman = new Batman();

        batman.Magg();
        batman.Knightt();
        knight.Knightt();
        mag.Magg();
        Console.ReadKey();
    }
    interface IMag
    {
        public void Magg();
    }
    interface IKnight
    {
        public void Knightt();
    }

    class Mag : IMag
    {
        public void Magg()
        {
            Console.WriteLine("Jestem Magiem");
        }
    }
    class Knight : IKnight
    {
        public void Knightt()
        {
            Console.WriteLine("Jestem Knightem");
        }
    }

    class Batman : IMag, IKnight
    {
        public void Magg()
        {
            Console.WriteLine("Jestem batmanem ale także Magiem");
        }
        public void Knightt()
        {
            Console.WriteLine("Batman także ma umiejetnosci knighta");
        }
    }
}
