Console.WriteLine(CanLaunch(3, 50, true));


static bool CanLaunch(int crewCount, int fuel, bool isHatchClosed)
{
    if (crewCount < 3) return false;

    if (fuel < 50) return false;

    if (!isHatchClosed) return false;

    return true;
}
