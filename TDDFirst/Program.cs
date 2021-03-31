using System;

namespace TDDFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Userdata userdata = new Userdata();
            userdata.IsPasswordOk("Rauf%12");
        }
    }
}
