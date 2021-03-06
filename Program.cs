using System;
using System.Collections.Generic;
using GetYourDogBack.Models;
using System.Linq;

namespace GetYourDogBack
{
  public class Program
  {
    public static void Main()
    {
      GYDB ignite = new GYDB("red", "white", null);
      GYDB shift = new GYDB("clutch", "shift", "throttle");
      GYDB biteFace = new GYDB("operation dance party", null, null);
      string dog = "reachable";
      // Introduction
      Console.WriteLine("You drove to the store to pick up a few things. Your dog is in the backseat of your car. Unfortunately, that car became a robber's getaway car. You should hotwire a motorcycle to get your dog back. Hit enter to pull the wires out of the ignition.");
      string start = Console.ReadLine();
      Console.WriteLine("-----------------------");
      //Chapter 1 / Hotwire a motorcycle
      Console.WriteLine("There are 3 wires (Red, White, & Blue). Two of them should be touching to start the motorcycle. Which two should it be?");
      Console.WriteLine("-----------------------");
      Console.WriteLine("Type the color of the first wire you think is right:");
      string userWire1 = Console.ReadLine();
      Console.WriteLine("-----------------------");
      Console.WriteLine("Type the color of the second wire you think is right:");
      string userWire2 = Console.ReadLine();
      while (dog == "reachable") 
      {
        if (ignite.Hotwire(userWire1, userWire2))
        {
          Console.WriteLine("The engine started!! Good Job! Now go get your dog back!!!!");
          Console.WriteLine("Hit enter to continue...");
          string contin = Console.ReadLine();
        }
        else
        {
          Console.WriteLine("You blew up the motorcycle");
          dog = "lost";
          break;
        }
        Console.WriteLine("-----------------------");
        //Chapter 2 / Shift to hyperspeed
        Console.WriteLine("You're now booking it down the road on a motorcycle, heading toward your car. The only way to catch up is to shift in to hyperspeed. The process is sequential, and order matters. The three switches need to shift are (throttle, clutch, shift). Type in the correct order to shift in to hyperspeed to catch up to get your dog back.");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Type the first corresponding switch action you think is right (throttle, clutch, shift): ");
        string userSwitch1 = Console.ReadLine();
        Console.WriteLine("-----------------------");
        Console.WriteLine("Type the second corresponding switch action you think is right (throttle, clutch, shift): ");
        string userSwitch2 = Console.ReadLine();
        Console.WriteLine("-----------------------");
        Console.WriteLine("Type the final corresponding switch action you think is right (throttle, clutch, shift): ");
        string userSwitch3 = Console.ReadLine();
        Console.WriteLine("-----------------------");
        if (shift.Hyperspeed(userSwitch1, userSwitch2, userSwitch3))
        {
          Console.WriteLine("Vrooooom!! You did it!! You're now zooming up to the tail of your car.");
          Console.WriteLine("Hit enter to continue...");
          string contin = Console.ReadLine();
        }
        else
        {
          Console.WriteLine("Oh no! You stalled the motorcycle and now the robber has gained too much distance for you to catch up to him.");
          dog = "lost";
          Console.WriteLine("Hit enter to continue...");
          string contin = Console.ReadLine();
        }
        //Chapter 3 / Stop robber
        Console.WriteLine("---------------------------");
        Console.WriteLine("All you need to do now is give the signal to your dog, and it will stop the robber by brutally biting his face off. But you have many signals for the dog that tell it to do different things and you can't remember which of the three ones you're thinking of it could be. The three possible signals are \"Attack!\", \"Roll over!\", or \"Operation Dance Party!\". Choose wisely to get your dog back.");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Type the correct signal to yell to your dog (attack, roll over, operation dance party): ");
        string userSignal = Console.ReadLine();
        Console.WriteLine("-----------------------");
        if (biteFace.Stoprobber(userSignal))
        {
          Console.WriteLine("Look at that dog bite the robber's face to pieces! You did it! The car stopped and you get your dog and car back. Good job.");
          dog = "found";
        }
        else
        {
          Console.WriteLine("Oh no! That wasn't it. The motorcycle ran out of gas. The robber got away with your dog.");
          dog = "lost";
        }
      }
      if (dog == "lost")
      {
        Console.WriteLine("You lost your dog. Time to put up Lost Dog flylers.");
      }
    }
  }
}