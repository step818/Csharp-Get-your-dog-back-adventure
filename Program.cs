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
        }
        else
        {
          Console.WriteLine("Oh no! You stalled the motorcycle and now the robber has gained too much distance for you to catch up to him.");
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