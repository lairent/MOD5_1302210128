namespace modul5_1302210128
{
    public class penjumlahan
    {
        public static T JumlahTigaAngka<T>(T a, T b, T c)
        {
            dynamic Temp;
            dynamic Temp2;
            dynamic Temp3;

            Temp =  a;
            Temp2 = b;
            Temp3 = c;

            return (Temp + Temp2 + Temp3);
        }   
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(penjumlahan.JumlahTigaAngka<int>(13, 02, 21));
        }
    }
}