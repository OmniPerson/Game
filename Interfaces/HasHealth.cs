namespace Game.Interfaces
{
    interface HasHealth {
        int Health { get;set; }

        int MaxHealth { get; }

        bool IsDead { get; } 

        bool IsAlive { get; } 

    }
}