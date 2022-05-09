class Dice
{
    private int sides;

    public Dice(int sides) // constructor
    {
        this.sides = sides;
    }

    public int RollDie() // roll the die
    {
        Random random = new Random();
        return random.Next(1, sides + 1); // return a random number between 1 and the number of sides
    }

    public int GetSides() // getter for sides
    {
        return sides;
    }

    public override string ToString() // override the ToString method
    {
        return $"{sides}-sided dice"; 
    }

    public static void Main(string[] args)
    {
        // prompts user to enter a number between 4 and 20
        Console.Write("Enter a number between 4 and 20: ");

        // try/catch block to catch invalid input 
        try
        {
            // gets the number from the user
            int sides = int.Parse(Console.ReadLine());

            // checks if the number is between 4 and 20
            if (sides < 4 || sides > 20)
            {
                throw new ArgumentException("The number must be between 4 and 20");
            }

            // creates dice
            Dice dice1 = new Dice(sides);
            Dice dice2 = new Dice(sides);

            // print the number of sides
            int numRolls = 0;
            int roll1 = 0;
            int roll2 = 0;

            // print the result of rolling the dice until snake eyes
            while (roll1 != 1 || roll2 != 1)
            {
                numRolls++;

                // roll the dice again
                roll1 = dice1.RollDie();
                roll2 = dice2.RollDie();

                // print the results of the roll
                Console.WriteLine($"Roll {numRolls}:");
                Console.WriteLine($"Die 1 rolled {roll1}");
                Console.WriteLine($"Die 2 rolled {roll2}" + "\n");
            }

            // print the number of rolls it took to get snake eyes
            Console.WriteLine($"It took {numRolls} rolls to get Snake Eyes");
        }

        // exception handling
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

