//Two dimensional class design
public class Point{

    public int X {get; init;}
    public int Y {get; init;}

    public override string ToString()
    {
        //Expression-bodied Members
        return $"({X}, {Y})";
    }
}