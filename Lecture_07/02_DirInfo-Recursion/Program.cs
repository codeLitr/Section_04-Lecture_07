// Просмотр папок с использованием рекурсии - будут перебираться по папкам и 
// просматривать, что внутри.

void CatalogInfo(string path, string indent = "")   // Метод, который будет перебирать папки. 
                                                    // string indent = "" - делается, чтобы в выводе были отступы, чтобы 
                                                    // визуально лучше была видна структура папки.
{
    DirectoryInfo catalog = new DirectoryInfo(path); // Получение информации о директории, в которую зашли.

    DirectoryInfo[] catalogs = catalog.GetDirectories(); // Получаем массив всех файлов, которые находятся в папке.
    for (int i = 0; i < catalogs.Length; i++) // Проходим по всем файлам.
    {
        System.Console.WriteLine($"{indent}{catalogs[i].Name}"); // Выводим информацию о каждом файле.
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles(); // Получаем весь список файлов текущей директории.

    for (int i = 0; i < files.Length; i++)
    {
        System.Console.WriteLine(($"{indent}{files[i].Name}")); // Вывод в консоль списка.
    }
}

string path = @"D:/Programming/Education/04_Lectures/Lecture_1";
CatalogInfo(path);