using System;

namespace DecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneNumber pn = new Number("555-1234");
            Console.WriteLine(pn.GetPhoneNumber());

            PhoneNumberDecorator areaCode = new AreaCode(pn, "210");
            Console.WriteLine(areaCode.GetPhoneNumber());

            PhoneNumberDecorator ext = new ExtensionNumber(areaCode, "1234");
            Console.WriteLine(ext.GetPhoneNumber());
            
            Console.ReadLine();
        }
    }
}

public abstract class PhoneNumber
{
    protected string Digits;
    public abstract string GetPhoneNumber();
}

public class Number : PhoneNumber
{
    public Number(string digits)
    {
        Digits = digits;
    }
    public override string GetPhoneNumber()
    {
        return Digits;
    }
}

public abstract class PhoneNumberDecorator : PhoneNumber
{
    protected PhoneNumber Phone;       
    public PhoneNumberDecorator(PhoneNumber phoneNumber, string digits)
    {
        this.Phone = phoneNumber;
        Digits = digits;
    }
    public override string GetPhoneNumber()
    {
        return Digits;        
    }
}

public class AreaCode : PhoneNumberDecorator
{
    public AreaCode(PhoneNumber phoneNumber, string digits) : base(phoneNumber, digits)
    {
        Phone = phoneNumber;
        Digits = digits;
    }
    public override string GetPhoneNumber()
    {
        return $"{ Digits } - { Phone.GetPhoneNumber() }";
    }
}

public class ExtensionNumber : PhoneNumberDecorator
{
    public ExtensionNumber(PhoneNumber phoneNumber, string digits) : base(phoneNumber, digits)
    {
        Phone = phoneNumber;
        Digits = digits;
    }
    public override string GetPhoneNumber()
    {
        return $"{ Phone.GetPhoneNumber() } ext. { Digits }";
    }
}

