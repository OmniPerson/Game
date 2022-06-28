using Game;
using Game.Interfaces;
namespace Game.Characters
{


abstract class Enemy : Character, CanCombat, HasLoot {
    public int Damage { get; protected set; }
    
    
    
    

}
}