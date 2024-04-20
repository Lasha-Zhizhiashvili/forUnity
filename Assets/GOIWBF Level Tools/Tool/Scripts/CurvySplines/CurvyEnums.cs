namespace FluffyUnderware.Curvy
{
    public enum CurvyInterpolation
    {
        Linear = 0,
        CatmullRom = 1,
        TCB = 2,
        Bezier = 3,
    }
    public enum CurvyOrientation
    {
        None = 0,
        Dynamic = 1,
        Static = 2,
    }
    public enum CurvyUpdateMethod
    {
        Update = 0,
        LateUpdate = 1,
        FixedUpdate = 2,
    }
    public enum CurvyOrientationSwirl
    {
        None = 0,
        Segment = 1,
        AnchorGroup = 2,
        AnchorGroupAbs = 3,
    }
    public enum ConnectionHeadingEnum
    {
        Minus = -1,
        Sharp = 0,
        Plus = 1,
        Auto = 2,
    }
}
