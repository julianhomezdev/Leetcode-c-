
public class RecentCounter
{


    // Valid time range [t-3000, t]
    // t -> time in miliseconds in the actually call
    // t - 3000 -> low limit of the range
    public RecentCounter()
    {

        int requests = 0;

    }

    public int Ping(int t)
    {
        // Initialize the counter
        RecentCounter();
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */