using System;

public sealed class ThreadedTimer
{
    private static readonly ThreadedTimer instance = new ThreadedTimer();

    private TimeSpan startTime;
    private TimeSpan elapsedTime;
// Explicit static constructor to tell C# compiler
// not to mark type as beforefieldinit
    static ThreadedTimer()
    {
    }


    private ThreadedTimer()
    {
    }

    public static ThreadedTimer Instance
    {
        get
        {
            return instance;
        }
    }

    public void StartTimer()
    {
        startTime = DateTime.Now.TimeOfDay;
    }

    public TimeSpan GetCurrentTime()
    {
        if(startTime != null)
        {
            return DateTime.Now.TimeOfDay - startTime;
        }
        else
        {
            return new TimeSpan(0,0,0);
        }                    
    }

    public TimeSpan StopTimer()
    {
        if(startTime != null)
        {
            elapsedTime = DateTime.Now.TimeOfDay - startTime;
            return elapsedTime;
        }
        return new TimeSpan();
    }

    public TimeSpan GetFinalTime()
    {
        if(startTime != null)
        {
            return elapsedTime;
        }
        else
        {
            return new TimeSpan(0,0,0);
        }                    
    }

}