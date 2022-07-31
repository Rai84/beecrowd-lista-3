using System;
using System.Globalization;
namespace BEE_1079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int n  = int.Parse(Console.ReadLine());
            double media1, media2, media3, media4, media5, media6, media7, media8, media9, total1, total2, total3;

             if (n == 1)
             {
                 string[] a = Console.ReadLine().Split(' ');
                 media1 = double.Parse((a[0]), CultureInfo.InvariantCulture);
                 media2 = double.Parse((a[1]), CultureInfo.InvariantCulture);
                 media3 = double.Parse((a[2]), CultureInfo.InvariantCulture);             

                 total1 = (media1 * 2 + media2 * 3 + media3 * 5) / 10;               

                 Console.WriteLine(total1.ToString("F1", CultureInfo.InvariantCulture));                
             }
             if (n == 2)
             {
                 string[] a = Console.ReadLine().Split(' ');
                 media1 = double.Parse((a[0]), CultureInfo.InvariantCulture);
                 media2 = double.Parse((a[1]), CultureInfo.InvariantCulture);
                 media3 = double.Parse((a[2]), CultureInfo.InvariantCulture);

                 string[] b = Console.ReadLine().Split(' ');
                 media4 = double.Parse((b[0]), CultureInfo.InvariantCulture);
                 media5 = double.Parse((b[1]), CultureInfo.InvariantCulture);
                 media6 = double.Parse((b[2]), CultureInfo.InvariantCulture);

                 total1 = (media1 * 2 + media2 * 3 + media3 * 5) / 10;
                 total2 = (media4 * 2 + media5 * 3 + media6 * 5) / 10;

                 Console.WriteLine(total1.ToString("F1", CultureInfo.InvariantCulture));
                 Console.WriteLine(total2.ToString("F1", CultureInfo.InvariantCulture));

             }
             if (n == 3)
             {
                 string[] a = Console.ReadLine().Split(' ');
                 media1 = double.Parse((a[0]), CultureInfo.InvariantCulture);
                 media2 = double.Parse((a[1]), CultureInfo.InvariantCulture);
                 media3 = double.Parse((a[2]), CultureInfo.InvariantCulture);

                 string[] b = Console.ReadLine().Split(' ');
                 media4 = double.Parse((b[0]), CultureInfo.InvariantCulture);
                 media5 = double.Parse((b[1]), CultureInfo.InvariantCulture);
                 media6 = double.Parse((b[2]), CultureInfo.InvariantCulture);

                 string[] c = Console.ReadLine().Split(' ');
                 media7 = double.Parse((c[0]), CultureInfo.InvariantCulture);
                 media8 = double.Parse((c[1]), CultureInfo.InvariantCulture);
                 media9 = double.Parse((c[2]), CultureInfo.InvariantCulture);

                 total1 = (media1 * 2 + media2 * 3 + media3 * 5) / 10;
                 total2 = (media4 * 2 + media5 * 3 + media6 * 5) / 10;
                 total3 = (media7 * 2 + media8 * 3 + media9 * 5) / 10;

                 Console.WriteLine(total1.ToString("F1", CultureInfo.InvariantCulture));
                 Console.WriteLine(total2.ToString("F1", CultureInfo.InvariantCulture));
                 Console.WriteLine(total3.ToString("F1", CultureInfo.InvariantCulture));

             }*/

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
