using game_jpg.src.entities;
class Program {
  static void Main(string[] args) 
  {
    Knight arus = new Knight("Arus", 23, "Knight");
    Ninja ninja = new Ninja("Wedge", 20, "Ninja");
    WhiteWizard whiteWizard = new WhiteWizard("Jerônica", 23, "White Wizard"); 
    BlackWizard blackWizard = new BlackWizard("Topapa", 30, "Black Wizard"); 

    Console.WriteLine(arus.Attack());
    Console.WriteLine(ninja.Attack());
    Console.WriteLine(whiteWizard.Attack());
    Console.WriteLine(whiteWizard.Attack(7));
    Console.WriteLine(whiteWizard.Attack(1));
    Console.WriteLine(blackWizard.Attack());
    Console.WriteLine(blackWizard.Attack(7));
    Console.WriteLine(blackWizard.Attack(1));
  }
}

