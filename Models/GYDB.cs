namespace GetYourDogBack.Models
{
  class GYDB
  {

    public string Ans1 { get; set; }
    public string Ans2 { get; set; }
    public string Ans3 { get; set; }

    public GYDB(string one, string two, string three)
    {
      Ans1 = one;
      Ans2 = two;
      Ans3 = three;
    }

    // public void DetermineNextSteps()
    // {
    //   HotWire();
    //   DodgeTraffic();
    //   StopRobber();
    //   IsGameOver();
    // }

    public bool Hotwire(string userWire1, string userWire2)
    {
      return ((userWire1 == Ans1 || userWire1 == Ans2) && (userWire2 == Ans1 || userWire2 == Ans2));
    }
    public bool Hyperspeed(string user1, string user2, string user3)
    {
      return ((user1 == Ans1) && (user2 == Ans2) && (user3 == Ans3));
    }
    public bool Stoprobber(string signal1)
    {
      return (signal1 == Ans1);
    }
  }
}