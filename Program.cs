using game_jpg.src.entities;
class Program {
  static void Main(string[] args) 
  {
    Hero arus = new Hero("Arus", 23, "Knight");
    Hero wizard = new Hero("Jerônica", 23, "White Wizard"); 

    Console.WriteLine(arus.Attack());
    Console.WriteLine(wizard.Attack());
  }
}

