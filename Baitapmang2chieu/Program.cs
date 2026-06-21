// Nhóm 1 - Cơ bản (Bài 1 → 5)
// Bài 1. Nhập và xuất mảng 2 chiều
// Viết chương trình:
// Khai báo mảng số nguyên m x n.
// Nhập dữ liệu từ bàn phím.
// Xuất mảng theo dạng bảng.
// Ví dụ
// 1 2 3
// 4 5 6
/*Console.WriteLine("Nhap vao so dong n cua mang:");
int son = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap vao so cot m cua mang:");
int som = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap vao gia tri cho cac phan tu cua mang:");
int[,] arr1 = new int[son, som];
for (int i = 0; i < son; i++)
{
    for (int j = 0; j < som; j++)
    {
        arr1[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < son; i++)
{
    for (int j = 0; j < som; j++)
    {
        Console.Write(arr1[i, j] + " ");
    }
    Console.WriteLine();
}*/
// Bài 2. Tính tổng tất cả phần tử
// Nhập ma trận và tính:
// Tổng = a[0][0] + a[0][1] + ...
// Ví dụ
// 1 2
// 3 4
// Tổng = 10
/*Console.WriteLine("Nhap vao so dong n cua mang:");
int soHang = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap vao so cot m cua mang:");
int soCot = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap vao gia tri cho cac phan tu cua mang:");
int[,] arr2 = new int[soHang, soCot];
for (int i = 0; i < soHang; i++)
{
    for (int j = 0; j < soCot; j++)
    {
        arr2[i, j] = int.Parse(Console.ReadLine());
    }
}

int sumArr2 = 0;
for (int i = 0; i < soHang; i++)
{
    for (int j = 0; j < soCot; j++)
    {
        Console.Write(arr2[i, j] + " ");
        sumArr2 += arr2[i, j];
    }
    Console.WriteLine();
}
Console.WriteLine("Tong cua mang la: " + sumArr2);*/
// Bài 3. Đếm số phần tử chẵn
// Nhập ma trận.
// Đếm xem có bao nhiêu số chẵn.
// Ví dụ
// 1 2
// 4 5
// Kết quả: 2
/*Console.WriteLine("Nhap vao so dong cua mang:");
int soHang3 = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap vao so cot cua mang:");
int soCot3 = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap vao gia tri cho cac phan tu cua mang:");
int[,] arr3 = new int[soHang3, soCot3];
for (int i = 0; i < soHang3; i++)
{
    for (int j = 0; j < soCot3; j++)
    {
        arr3[i, j] = int.Parse(Console.ReadLine());
    }
}

int countEven = 0;
for (int i = 0; i < soHang3; i++)
{
    for (int j = 0; j < soCot3; j++)
    {
        Console.Write(arr3[i, j] + " ");
        if (arr3[i, j] % 2 == 0) countEven++;
    }
    Console.WriteLine();
}
Console.WriteLine("So so chan cua mang la: " + countEven);*/

// Bài 4. Tìm phần tử lớn nhất
// Tìm giá trị lớn nhất trong ma trận.
// Ví dụ
// 1 9 3
// 4 5 6
// Max = 9
/*Console.WriteLine("Nhap vao so dong cua mang:");
int soHang4 = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap vao so cot cua mang:");
int soCot4 = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap vao gia tri cho cac phan tu cua mang:");
int[,] arr4 = new int[soHang4, soCot4];
for (int i = 0; i < soHang4; i++)
{
    for (int j = 0; j < soCot4; j++)
    {
        arr4[i, j] = int.Parse(Console.ReadLine());
    }
}

int maxArr4 = arr4[0, 0];
for (int i = 0; i < soHang4; i++)
{
    for (int j = 0; j < soCot4; j++)
    {
        Console.Write(arr4[i, j] + " ");
        if (arr4[i, j] > maxArr4) maxArr4 = arr4[i, j];
    }
    Console.WriteLine();
}
Console.WriteLine("Max = " + maxArr4);
// Bài 5. Tìm phần tử nhỏ nhất
// Tìm giá trị nhỏ nhất trong ma trận.
int minArr4 = arr4[0, 0];
for (int i = 0; i < soHang4; i++)
{
    for (int j = 0; j < soCot4; j++)
    {
        if (arr4[i, j] < minArr4) minArr4 = arr4[i, j];
    }
}
Console.WriteLine("Min = " + minArr4);*/

// Nhóm 2 - Vòng lặp và điều kiện (Bài 6 → 10)
// Bài 6. Tính tổng các số dương
// Chỉ cộng những phần tử > 0.
// Ví dụ
// 1 -2
// 3 -4
// Tổng = 4
/*Console.WriteLine("Nhap vao so dong cho mang:");
int soDong5 = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap vao so cot cho mang:");
int soCot5 = int.Parse(Console.ReadLine());
int[,] arr5 = new int[soDong5,soCot5];
Console.WriteLine("Nhap vao gia tri cho cac phan tu trong mang:");
for (int i = 0; i < soDong5; i++)
{
    for (int j = 0; j < soCot5; j++)
    {
        arr5[i,j] = int.Parse(Console.ReadLine());
    }
}

int sumArr5 = 0;
for (int i = 0; i < arr5.GetLength(0); i++)
{
    for (int j = 0; j < arr5.GetLength(1); j++)
    {
        Console.Write(arr5[i,j] + " ");
        if (arr5[i,j] > 0) sumArr5 += arr5[i,j];
    }
    Console.WriteLine();
}
Console.WriteLine("Tong = " + sumArr5);
// Bài 7. Đếm số âm
// Đếm số phần tử nhỏ hơn 0.
int countAmArr5 = 0;
for (int i = 0; i < arr5.GetLength(0); i++)
{
    for (int j = 0; j < arr5.GetLength(1); j++)
    {
        if (arr5[i,j] < 0) countAmArr5++;
    }
}
Console.WriteLine("So cac so am = " + countAmArr5);*/
// Bài 8. Tìm vị trí phần tử lớn nhất
// Hiển thị:
// Max = 20
// Dòng = 1
// Cột = 2
Console.WriteLine("Nhap vao so dong cua mang:");
int soHang8 = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap vao so cot cua mang:");
int soCot8 = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap vao gia tri cho cac phan tu cua mang:");
int[,] arr8 = new int[soHang8, soCot8];
for (int i = 0; i < soHang8; i++)
{
    for (int j = 0; j < soCot8; j++)
    {
        arr8[i, j] = int.Parse(Console.ReadLine());
    }
}

int maxArr8 = arr8[0, 0];
int maxIndexRow = 0;
int maxIndexCol = 0;
for (int i = 0; i < soHang8; i++)
{
    for (int j = 0; j < soCot8; j++)
    {
        Console.Write(arr8[i, j] + " ");
        if (arr8[i, j] > maxArr8)
        {
            maxArr8 = arr8[i, j];
            maxIndexRow = i + 1;
            maxIndexCol = j + 1;
        }
    }
    Console.WriteLine();
}
Console.WriteLine("Max = " + maxArr8);
Console.WriteLine("Dong = " + maxIndexRow);
Console.WriteLine("Cot = " + maxIndexCol);

// Bài 9. Tính trung bình cộng
// Tính trung bình của tất cả phần tử.
double average = 0;
foreach (int i in arr8)
{
    average += i;
}
average /= arr8.Length;
Console.WriteLine("Average = " + average);
// Bài 10. Đếm số chia hết cho 3
// Đếm các phần tử:
// a[i,j] % 3 == 0
int countChiaHet3 = 0;
foreach (int i in arr8)
{
    if (i % 3 == 0) countChiaHet3++;
}
Console.WriteLine("So so chia het cho 3 = " + countChiaHet3);
// Nhóm 3 - Làm việc với hàng và cột (Bài 11 → 15)
// Bài 11. Tính tổng từng hàng
// Ví dụ:
// 1 2 3
// 4 5 6
// Hàng 1 = 6
// Hàng 2 = 15
for (int i = 0; i < arr8.GetLength(0); i++)
{
    int sumHang = 0;
    for (int j =  0; j < arr8.GetLength(1); j++)
    {
        Console.Write(arr8[i, j] + " ");
        sumHang += arr8[i, j];
    }
    Console.WriteLine($"Tong hang {i+1} = " + sumHang);
}

// Bài 12. Tính tổng từng cột
// Ví dụ:
// 1 2
// 3 4
// 5 6
// Cột 1 = 9
// Cột 2 = 12
for (int i = 0; i < arr8.GetLength(1); i++)
{
    int sumCot = 0;
    for (int j =  0; j < arr8.GetLength(0); j++)
    {
        Console.Write(arr8[j, i] + " ");
        sumCot += arr8[j, i];
    }
    Console.WriteLine($"Tong cot {i+1} = " + sumCot);
}

// Bài 13. Tìm hàng có tổng lớn nhất
// Hiển thị:
// Hàng 2 có tổng lớn nhất = 25

// Bài 14. Tìm cột có tổng nhỏ nhất
// Hiển thị:
// Cột 1 có tổng nhỏ nhất = 12

// Bài 15. Tìm số lớn nhất trên mỗi hàng
// Ví dụ:
// 1 8 3
// 4 5 9
// Hàng 1: 8
// Hàng 2: 9

// Nhóm 4 - Đường chéo và ma trận vuông (Bài 16 → 18)
// Bài 16. Tính tổng đường chéo chính
// Ma trận vuông.
// 1 2 3
// 4 5 6
// 7 8 9
// Tổng = 1 + 5 + 9 = 15

// Bài 17. Tính tổng đường chéo phụ
// 1 2 3
// 4 5 6
// 7 8 9
// Tổng = 3 + 5 + 7 = 15

// Bài 18. Đếm số chẵn trên đường chéo chính
// Ví dụ:
// 2 1 1
// 1 4 1
// 1 1 6
// Kết quả = 3

// Nhóm 5 - Vận dụng (Bài 19 → 20)
// Bài 19. Tìm phần tử lớn thứ hai
// Tìm giá trị lớn thứ hai trong ma trận.
// Ví dụ
// 1 5 9
// 7 3 8
// Kết quả = 8

// Bài 20. Ma trận cờ vua
// Tạo ma trận kích thước n x n.
// Hiển thị xen kẽ:
// 1 0 1 0
// 0 1 0 1
// 1 0 1 0
// 0 1 0 1
// Gợi ý:
// if ((i + j) % 2 == 0)
//    a[i, j] = 1;
// else
//    a[i, j] = 0;

// Quản lý điểm học sinh
// Cho ma trận:
// Mỗi dòng là 1 học sinh.
// Mỗi cột là 1 môn học.
// Ví dụ:
// Toán  Lý  Hóa
//  8     7   9
//  6     8   7
//  9     9  10
// Yêu cầu:
// Nhập ma trận điểm.
// In bảng điểm.
// Tính điểm trung bình của từng học sinh.
// Tìm học sinh có điểm trung bình cao nhất.
// Đếm số điểm đạt từ 8 trở lên.
// Tìm điểm cao nhất toàn lớp.
// Bài này tổng hợp:
// Mảng 2 chiều
// Vòng lặp lồng nhau
// Điều kiện
// Hàng và cột
// Tính toán thống kê cơ bản