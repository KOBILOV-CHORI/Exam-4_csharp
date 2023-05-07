public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point()
    {
        
    }
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
    public override string ToString()
    {
        return $"X,Y=({X}, {Y})";
    }
    int[] XY = new int[1];
    public void SetXY(int x, int y)
    {
        XY[0] = x;
        XY[1] = y;
    }
    public int[] GetXY()
    {
        return XY;
    }
    public double Distance(int x, int y)
    {
        return X-x;
    }
}