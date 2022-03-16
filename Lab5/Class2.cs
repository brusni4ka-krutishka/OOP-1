using System;
namespace Lab5
{
    public class ForObject : Object // переопределение методов Object
    {
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;
            return true;
        }

        public string Name { get; set; }
        readonly int sNumber = 0;

        public override int GetHashCode()
        {
            int hash = string.IsNullOrEmpty(Name) ? 0 : Name.GetHashCode();
            hash = (hash * 47) + sNumber.GetHashCode();
            return hash;
        }

    }

    public static class Printer2
    {
        public static void IAmPrinting(Mechanism mech)=> Console.WriteLine(mech.ToString());
    }

}
