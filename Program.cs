using System;

String[] getStringsShortenThan(String[] strings, int lenght){
    Console.WriteLine("");
    Console.WriteLine("Фильтруем массив ...");
    int count = 0;
    for (int i = 0; i < strings.Length; i++){
        String temp;
        if (strings[i].Length <= lenght){
            Console.WriteLine("Найден подходящий элемент: {0}. \"{1}\"", i+1 , strings[i]);
            count++;
            if (strings[count-1] != strings[i]){
                Console.WriteLine("меняем >> \"{0}\" <-> \"{1}\":", strings[count-1], strings[i]);
                temp = strings[count-1]; 
                strings[count-1]=strings[i];
                strings[i] = temp;
                Console.WriteLine("[\"{0}\"]", string.Join("\", \"", strings));
                Console.WriteLine("");
            }
        }
    }

    var result = new String[count];
    // Array.Copy(strings, result, count);
    for (int i = 0; i < count; i++){
        result[i]=strings[i];
    }
    return result;
}

String[] initTheStrings(int length){
    String[] strings;
    if (length == 0){
        strings = new []{"1", "12", "free", "four", "one", "two", "zero", "five", "six", "seven", "eight", "nine", "ten", ""};
    }
    else{
        strings = new String[length];
        Console.WriteLine("Введите строки - элементы массива.");
        for (int i = 0; i < length; i++)
        {
            Console.Write("{0}. ",i+1);
            strings[i] = Convert.ToString(Console.ReadLine());
        }
    }
    return strings;
}

Console.WriteLine("Введите кол-во строк в массиве. Для использования примера нажмите <Enter>.");
String l = Console.ReadLine().Trim();
var length = l.Length>0 ? Convert.ToInt16(l) : 0;
var strings = initTheStrings(length);

Console.WriteLine("Введите длинну для фильтра строк (по усолчанию <= 3).");
var n = Console.ReadLine().Trim();
var filter = Convert.ToInt16(n.Length>0 ? n : 3 );

Console.WriteLine("Получен массив: [\"{0}\"]", string.Join("\", \"", strings));
var results = getStringsShortenThan(strings, filter);
Console.WriteLine("Массив элементов не более {0} символов: [\"{1}\"]", filter, string.Join("\", \"", results));