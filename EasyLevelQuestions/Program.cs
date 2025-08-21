using System.Text.RegularExpressions;

#region 1’den N’ye kadar sayıları yazdırın ve ardından ters sırada yazdırın. 

//Console.Write("Tavan sayıyı giriniz: ");
//int inputVal = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"1'den {inputVal}'ye kadar olan sayılar\n");

//for (int i = 1; i <= inputVal; i++)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine($"\n{inputVal}'den 1'e kadar olan sayılar\n");

//for (int i = inputVal; i > 0; i--)
//{
//    Console.WriteLine(i);
//}

#endregion

#region Verilen bir tamsayı N’in asal olup olmadığını kontrol edin.

//Console.Write("Asal olup olmadığını kontrol etmek istediğiniz sayıyı giriniz: ");
//int number = Convert.ToInt32(Console.ReadLine());

//bool isPrime = true;

//if (number < 2)
//    isPrime = false;
//else
//{
//    for (int i = 2; i <= Math.Sqrt(number); i++)
//    {
//        if (number % i == 0)
//            isPrime = false; ;
//        break;
//    }
//}
//if (isPrime == true)
//    Console.WriteLine($"{number} bir asal sayıdır.");
//else
//    Console.WriteLine($"{number} bir asal sayı değildir.");

#endregion

#region Verilen bir tamsayının basamakları toplamını hesaplayın.  

//Console.Write("Bir tamsayı girin: ");
//int number = Convert.ToInt32(Console.ReadLine());

//int result = 0;
//int temporary = Math.Abs(number);

//while (temporary > 0)
//{
//    result += temporary % 10;
//    temporary /= 10;
//}

//Console.WriteLine($"\nBasamakların toplamı: {result}");

#endregion

#region Verilen bir dizgenin palindrome olup olmadığını belirleyin (büyük/küçük harf ve alfanümerik olmayan karakterleri göz ardı edin).  

//Console.Write("Bir metin giriniz: ");
//string text = Console.ReadLine() ?? "";

//bool isPalindrome = Regex.Replace(text, @"[^a-zA-Z0-9]", "")
//                         .ToLower()
//                         .SequenceEqual(
//                             Regex.Replace(text, @"[^a-zA-Z0-9]", "")
//                                  .ToLower()
//                                  .Reverse()
//                         );

//Console.WriteLine(isPalindrome ? "Palindrome" : "Palindrome değil");

#endregion

#region Bir tamsayı dizisindeki en büyük ve en küçük değeri bulun.  

//int[] numbers = { 481, 9519, 7449, 0, 980453, 846, 534, 87, 1350, 867, 43, 8, };

//int maxVal = numbers.Max();
//int minVal = numbers.Min();

//Console.WriteLine($"Dizideki en büyük değer: {maxVal}");
//Console.WriteLine($"Dizideki en küçük değer: {minVal}");

#endregion

Console.ReadLine();