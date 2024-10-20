namespace EnBuyukSayiBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            int sayac = 1;
            int sayi;
            int enbuyuk = 0;
            int enkucuk = int.MaxValue;

            Console.WriteLine("ÇIKIŞ İÇİN SIFIRA BAS!!!");
            do
            {

                Console.WriteLine($"{sayac}.Sayıyı girin :");
                sayi = Convert.ToInt32(Console.ReadLine());
                list.Add(sayi);
                sayac++;
            }
            while (sayi > 0); //1 2 3 4


            foreach (var item in list)
            {
            if (enbuyuk < item)
                {
                    enbuyuk = item;

                }
            }
            Console.WriteLine(enbuyuk);



        }
    }
}
