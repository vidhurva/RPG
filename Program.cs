using System;

class MainClass
{
    // private health amount
    class Player
    {
        private int _health = 187;
        private int _mana = 54;

        public int health
        {
            get 
            {
                return _health;
            }
            set 
            {
                if(value <= 0) 
                {
                    _health = 0;
                }
                else if (value >= 187)
                {
                    _health = 187;
                    Console.WriteLine("Character uses a healing potion!");
                }
                else 
                {
                    _health = value;
                }
            }
        }
        public int mana
        {
            get
            {
                return _mana;
            }
            set
            {
                if(value <= 0) 
                {
                    _mana = 0;
                }
                else if (value >= 54)
                {
                    _mana = 54;
                    Console.WriteLine("Character uses an ether!");
                }
                else
                {
                    _health = value;
                }
            }
        }
    }
    public static void Main(string[] args)
    {

        Player Nike = new Player();
        Player Dhur = new Player();

        Console.WriteLine("Nike enters into the battle");
        Console.WriteLine(Nike.health);
        Nike.health -= 147;
        Console.WriteLine(Nike.health);
        Nike.health += 250;
        Console.WriteLine(Nike.health);
        //DateTime curTime = DateTime.Now;
        //Console.WriteLine(curTime);

        Console.WriteLine("Dhur enters into battle");
        Console.WriteLine(Dhur.health);
        Dhur.health -= 17;
        Dhur.health -= 44;
        Console.WriteLine(Dhur.health);
        Console.WriteLine(Dhur.mana);
        Console.WriteLine("Dhur saps some hp from opponent!");
        Dhur.mana -= 4;
        Dhur.health += 200;
        Console.WriteLine(Dhur.health);
        Console.WriteLine(Dhur.mana);

        Console.ReadKey();
    }
}