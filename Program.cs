using game_jpg.src.entities;
class Program {
  static void Main(string[] args) 
  {
    Arus hero = new Arus("Arus", 23, "Knight");
    Arus wizard = new Arus("Jerônica", 23, "White Wizard"); 

    Console.WriteLine(hero.Attack());
    Console.WriteLine(wizard.Attack());
  }
}

