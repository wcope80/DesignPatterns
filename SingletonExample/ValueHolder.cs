using System;
public sealed class ValueHolder
{
    private static  ValueHolder _instance = null;
    private static readonly object padlock = new object();
    private int Value;      
    
    public static ValueHolder Instance
    {
        get
        {
            lock(padlock)
            {
                if(_instance == null)
                {
                    _instance = new ValueHolder();
                }

            }
            return _instance;
        }
        
       
    }
    
    public void SetValue(int value)
    {
      Value = value;
    }

    public int GetValue()
    {
        return Value;        
    }
}