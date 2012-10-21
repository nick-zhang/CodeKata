namespace BullsAndCows
{
    public class BullsNCows
    {
        private readonly int mBulls;
        private readonly int mCows;

        public BullsNCows(int bulls, int cows)
        {
            mBulls = bulls;
            mCows = cows;
        }

        public int Bulls
        {
            get { return mBulls; }
        }

        public int Cows
        {
            get { return mCows; }
        }
    }
}