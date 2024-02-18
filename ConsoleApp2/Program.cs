using System;

string[,] arr = new string[10, 4];

#pragma region questions

arr[0, 0] = "What is a namespace ?\n";
arr[0, 1] = "Logical grouping";
arr[0, 2] = "Related codes";
arr[0, 3] = "Encryption feature";

arr[1, 0] = "What is \"==\" operator ?\n";
arr[1, 1] = "Equality comparison";
arr[1, 2] = "Assignment operator";
arr[1, 3] = "Conditional statement";

arr[2, 0] = "What is a method ?\n";
arr[2, 1] = "Function or procedure";
arr[2, 2] = "Variable declaration";
arr[2, 3] = "Data manipulation";

arr[3, 0] = "What is exception handling ?\n";
arr[3, 1] = "Error management";
arr[3, 2] = "Syntax highlighting";
arr[3, 3] = "Resource cleanup";

arr[4, 0] = "What is purpose of \"public\" ?\n";
arr[4, 1] = "Accessibility specifier";
arr[4, 2] = "Data encapsulation";
arr[4, 3] = "Private access";

arr[5, 0] = "What is \"try-catch\" ?\n";
arr[5, 1] = "Error handling mechanism";
arr[5, 2] = "Loop construct";
arr[5, 3] = "Data structure";

arr[6, 0] = "What does 'new' do ?\n";
arr[6, 1] = "Object instantiation";
arr[6, 2] = "Memory deallocation";
arr[6, 3] = "Variable declaration";

arr[7, 0] = "What is \"ref\" keyword ?\n";
arr[7, 1] = "Pass by reference";
arr[7, 2] = "Function declaration";
arr[7, 3] = "Access modifier";

arr[8, 0] = "What is \"implicit conversion\" ?\n";
arr[8, 1] = "Automatic type casting";
arr[8, 2] = "User-defined operator";
arr[8, 3] = "Method overloading";

arr[9, 0] = "What is \"delegate\" in C# ?\n";
arr[9, 1] = "Function pointer";
arr[9, 2] = "Class constructor";
arr[9, 3] = "Memory allocator";

#pragma  endregion

int point = 0;
int correct = 0;
int incorrect = 0;

for (int i = 0; i < 10; i++)
{
    int select = 0;
    string[] arr2 = new string[3];
    for (int l = 0; l < 3; l++)
        arr2[l] = arr[i, l + 1];
    shuffle(ref arr2);
    while (true)
    {
        Console.Clear();
        Console.WriteLine(arr[i, 0]);

        for (int j = 0; j < 3; j++)
        {
            if (j == select)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write((char)(65 + j) + ") ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else
                Console.Write((char)(65 + j) + ") ");


            if (j == select)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(arr2[j]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
                Console.WriteLine(arr2[j]);
        }
        ConsoleKeyInfo key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.DownArrow)
            if (select == 2)
                select = 0;
            else
                select++;

        else if (key.Key == ConsoleKey.UpArrow)
            if (select == 0)
                select = 2;
            else
                select--;
        else if (key.Key == ConsoleKey.Escape)
        {
            Console.WriteLine("Correct: " + correct);
            Console.WriteLine("Incorrect: " + incorrect);
            Console.WriteLine("Point: " + (point < 0 ? 0 : point));
            return;
        }

        else if (key.Key == ConsoleKey.Enter)
        {
            if (arr2[select] == arr[i, 1])
            {
                correct++;
                point += 10;
            }

            else
            {
                incorrect++;
                point -= 10;
            }
            break;
        }
    }
}
Console.WriteLine("Correct: " + correct);
Console.WriteLine("Incorrect: " + incorrect);
Console.WriteLine("Point: " + (point < 0 ? 0 : point));

void shuffle(ref string[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < 3; i++)
    {
        int n = i + rand.Next(3 - i);
        string temp = arr[n];
        arr[n] = arr[i];
        arr[i] = temp;
    }
}