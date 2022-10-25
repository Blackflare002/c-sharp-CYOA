namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine().ToUpper();
            // noiseChoice.ToUpper();
            // Console.WriteLine("noise: " + noiseChoice);
            if (noiseChoice == "NO")
            {
                Console.WriteLine("How can you have an adventure if you don't leave your room?!");
                Console.WriteLine("GAME OVER.");
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
                // first elseif
                Console.WriteLine("Type OPEN or KNOCK:");
                string doorChoice = Console.ReadLine().ToUpper();
                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says:");
                    Console.WriteLine("\"Answer this riddle: \"");
                    Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                    Console.Write("Type your answer: ");
                    string riddleAnswer = Console.ReadLine().ToUpper();
                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door.");
                        Console.WriteLine("THE END!");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.");
                        Console.WriteLine("THE END!");
                    }
                }
                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.WriteLine("Enter a number (1-3): ");
                    string keyChoice = Console.ReadLine().ToUpper();
                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange...");
                            Console.WriteLine("THE END!");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. Doesn't work. Time to give up!");
                            Console.WriteLine("THE END!");
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. Doesn't work. Oh well, back to bed!");
                            Console.WriteLine("THE END!");
                            break;
                    }
                }
                // first elseif
            }
        }
    }
}



