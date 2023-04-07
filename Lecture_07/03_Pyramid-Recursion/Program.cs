// Игра в Ханойскую пирамиду. Решение через рекурсию.

void Towers(string with = "1", string on = "3", string some = "2", int count = 3) // Перечисление шпилей и кол-ва блинов, которое имеется (count).
                                                                                  // Прохождение игр с тремя шпилями и любым кол-ом блинов (поменять в count значение).
{
    if (count > 1) Towers(with, some, on, count -1);
    System.Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count -1);
}
Towers(); // В итоге выведет список действий, чтобы переместить 3 блина с первого шпиля на третий.