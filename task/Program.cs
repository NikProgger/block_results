string[] strings = { "hello", "2", "world", ":-)",};
    var result = strings.Where(s => s.Length <= 3).ToArray();
        Console.WriteLine(string.Join(", ", result)); 
        Console.ReadLine();
            return(0);