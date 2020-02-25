namespace Animals
{
    public class Animal
    {
       protected int health {get;set;}
       protected int hunger {get; set;}
       protected int speed {get; set;}
       protected int damage {get; set;}
       protected int reproductionRate {get; set;}
       protected int x {get; set;}
       protected int y {get; set;}
       public bool alive {get; set;} = true;
       public bool hungry {get; set;} = false;

       public Animal(){}

    }
}