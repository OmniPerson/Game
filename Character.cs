using Game.Interfaces;
namespace Game      
{

     abstract class Character : HasHealth, HasName
    {
        public int Health { get; set; }

        public int MaxHealth {get; private set;} 

        public bool IsDead { get => Health <= 0; }

        public bool IsAlive {get => Health > 0;}

        public string Name {get;}

       public Character(string name){
        Name=name;
        MaxHealth=100;
       }
       public Character(){
        Name= "PlayerName";
        MaxHealth= 100;
       }
       public Character(int maxHealth){
        MaxHealth=maxHealth;
        Name= "PlayerName";
       }
       public Character(string name, int maxHealth){
        MaxHealth=maxHealth;
        Name=name;
       }
    }
}