string[] arr = new string[] {"hello", "2", "world", ":-"};

for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Console.WriteLine(arr[i]);   
        }
    }
