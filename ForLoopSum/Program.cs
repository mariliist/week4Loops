
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($" i = {i + 1}"); // mõeldud ainult kuvamiseks, i väärtus ei muutu
//}

//for (int i = 10; i > 0; i--)
//{
//    Console.WriteLine($" i = {i}"); // mõeldud ainult kuvamiseks, i väärtus ei muutu
//}

int sum = 0;
for(int i = 0; i < 4; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + 1;
}
//Console.WriteLine($"Final total {sum}");