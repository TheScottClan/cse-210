// Josh Scott - Tic Tac Toe Game


char[] arr = {'0','1', '2', '3', '4', '5', '6', '7', '8', '9'};
int player = 1;
int choice;
int winner;

do
{
    player++;

    Console.WriteLine(arr[1] + " | " + arr[2] + " | " + arr[3]);
    Console.WriteLine("- + - + - ");
    Console.WriteLine(arr[4] + " | " + arr[5] + " | " + arr[6]);
    Console.WriteLine("- + - + - ");
    Console.WriteLine(arr[7] + " | " + arr[8] + " | " + arr[9]);

    Console.WriteLine("");

    if (player % 2 == 0)
    {
        Console.Write("Player X's turn to choose a square (1-9): ");
        choice = int.Parse(Console.ReadLine());
        arr[choice] = char.Parse("X");
    }
    else
    {
        Console.Write("Player O's turn to choose a square (1-9): ");
        choice = int.Parse(Console.ReadLine());
        arr[choice] = char.Parse("O");
    }

    // Did someone win?
    if (arr[1] == arr[2] && arr[2] == arr[3]) // 1st Row
    {
        winner = 1;
        Console.WriteLine("We have a winner!");
    }
    else if (arr[4] == arr[5] && arr[5] == arr[6]) // 2nd Row
    {
        winner = 1;
        Console.WriteLine("We have a winner!");
    }
    else if (arr[7] == arr[8] && arr[8] == arr[9]) // 3rd Row
    {
        winner = 1;
        Console.WriteLine("We have a winner!");
    }
    else if (arr[1] == arr[4] && arr[4] == arr[7]) // 1st column
    {
        winner = 1;
        Console.WriteLine("We have a winner!");
    }
    else if (arr[2] == arr[5] && arr[5] == arr[8]) // 2nd column
    {
        winner = 1;
        Console.WriteLine("We have a winner!");
    }
    else if (arr[3] == arr[6] && arr[6] == arr[9]) // 3rd column
    {
        winner = 1;
        Console.WriteLine("We have a winner!");
    }
    else if (arr[1] == arr[5] && arr[5] == arr[9]) // Diag. top-left to bottom-right
    {
        winner = 1;
        Console.WriteLine("We have a winner!");
    }
    else if (arr[7] == arr[5] && arr[5] == arr[3]) // Diag. bottom-left to top-right
    {
        winner = 1;
        Console.WriteLine("We have a winner!");
    }
    else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9') // Draw?
    {
        winner = 1;
        Console.WriteLine("Draw!");
    }
    else // No one has won or drew, keep playing!
    {
        winner = 0;
    }
    

}while(winner == 0);

