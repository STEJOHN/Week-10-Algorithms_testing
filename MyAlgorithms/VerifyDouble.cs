namespace MyAlgorithms
{
    public class VerifyDouble
    {
        public bool VerifyIfDouble(int[] vs)
        {
            {
                for (var i = 0; i < vs.Length; i++)
                {
                    for (var y = 0; y < vs.Length; y++)
                    {
                        if (2 * vs[i] == vs[y]) return true;
                    }
                }
                return false;
            }
        }
    }
}
