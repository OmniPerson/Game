namespace Game.Interfaces;

interface HasHealth {
    int Health { get;set; }

    int maxHealth { get; }

    bool isDead { get; } 

    bool isAlive { get; } 

}