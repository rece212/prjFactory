namespace prjFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BurgerFactory burgerFactory = new BurgerFactory();
            Console.Write("Please enter your burger :");
            String selectedBurger  = Console.ReadLine();
            IBurger Burger = burgerFactory.getBurger(selectedBurger);
            Console.WriteLine("{0} bun and a {1} patty with {2}",
                Burger.getBun(),Burger.getPatty(),Burger.getCondiments());
        }
    }
}