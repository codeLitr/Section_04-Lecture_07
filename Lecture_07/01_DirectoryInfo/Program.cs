//Просмотр папок. Используется класс DirectiryInfo

string path = "D:/Programming/Education/04_Lectures/Lecture_1/Example002_HelloUser";

DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime); // Покажет время создания папки.

FileInfo[] fi = di.GetFiles(); // Покажет список файлов в папке.
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine((fi[i].Name));
}