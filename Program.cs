using System;

class Program
{
    static void Main()
    {
        // Bước 1: Khai báo các biến, nhập và kiểm tra kích thước mảng
        int size;
        int[] array;

        // Nhập kích thước mảng và kiểm tra điều kiện
        do
        {
            Console.WriteLine("Enter a size:");
            size = Int32.Parse(Console.ReadLine());
            if (size > 20)
                Console.WriteLine("Size should not exceed 20");
        } while (size > 20);

        // Bước 2: Nhập giá trị cho các phần tử của mảng
        array = new int[size];
        int i = 0;
        while (i < array.Length)
        {
            Console.WriteLine("Enter element " + (i + 1) + ": ");
            array[i] = Int32.Parse(Console.ReadLine());
            i++;
        }

        // Bước 3: In ra danh sách phần tử đã nhập
        Console.WriteLine("Property list:");
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write(array[j] + "\t");
        }
        Console.WriteLine();

        // Bước 4: Duyệt các phần tử trong mảng để tìm GTLN và vị trí
        int max = array[0];
        int index = 0;
        for (int j = 1; j < array.Length; j++) // Bắt đầu từ 1 vì max đã là phần tử đầu tiên
        {
            if (array[j] > max)
            {
                max = array[j];
                index = j;
            }
        }

        // In ra giá trị lớn nhất và vị trí của nó
        Console.WriteLine("The largest property value in the list is " + max + " , at position " + (index + 1));
    }
}
