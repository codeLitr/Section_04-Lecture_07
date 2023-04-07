// Обход разных структур на примере двоичного дерева (дискретная математика). 


string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" }; // Массив, представляющий дерево. Emp ничего не дает, вставлен, чтобы придать выводу удобный по длине вид.
//                 0    1    2     3    4    5    6    7    8    9    10   11 

void InOrderTraversal(int pos = 1) // В данном методе можно переместить строку 15 ( System.Console.WriteLine(tree[pos]);) на строку 14 и метод станет PreOrderTraversal или на строку 17 и тогда снова поменяется результат.
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos +1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        System.Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}

InOrderTraversal();