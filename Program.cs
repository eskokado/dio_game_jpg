using game_jpg.src.entities;
class Program {
  static void Main(string[] args) 
  {
    Knight arus = new Knight("Arus", 23, "Knight");
    Wizard wizard = new Wizard("Jerônica", 23, "White Wizard"); 

    Console.WriteLine(arus.Attack());
    Console.WriteLine(wizard.Attack());
    Console.WriteLine(wizard.Attack(7));
    Console.WriteLine(wizard.Attack(1));
  }
}

