using Game;
using Game.Interfaces;
namespace Game.Characters
{
class PLayer : Character, HasPlayer 
    {
    public int Damage{get; protected set;} 
    public int Heal {get; protected set;}
    }


}