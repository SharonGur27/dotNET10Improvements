var p = CreatePoint();
Console.WriteLine(ComputeSum());


static int ComputeSum()
{
    Point p = new Point(3, 4);
    return p.Sum(); 
}

static Point CreatePoint()
{
    // Object escapes because it's returned
    return new Point(10, 20);
}


class Point
{
    private int _x, _y;

    public Point(int x, int y) { _x = x; _y = y; }

    public int Sum() => _x + _y;
}

