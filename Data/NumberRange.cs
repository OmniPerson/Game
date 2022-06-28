namespace Game.Data
{
    class NumberRange{
    

    public int Max { get; private set; }
    public int Min { get; private set; }
    NumberRange(int min, int max){
    Min = min;
    Max = max;
    }
    }
}