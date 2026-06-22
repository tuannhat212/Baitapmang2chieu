// Nhóm 1 - Cơ bản (Bài 1 → 5)
// Bài 1. Nhập và xuất mảng 2 chiều
// Viết chương trình:
// Khai báo mảng số nguyên m x n.
// Nhập dữ liệu từ bàn phím.
// Xuất mảng theo dạng bảng.
// Ví dụ
// 1 2 3
// 4 5 6
Console.WriteLine("Nhap vao so dong n cua mang:");
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
}
// Bài 2. Tính tổng tất cả phần tử
// Nhập ma trận và tính:
// Tổng = a[0][0] + a[0][1] + ...
// Ví dụ
// 1 2
// 3 4
// Tổng = 10
Console.WriteLine("Nhap vao so dong n cua mang:");
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
Console.WriteLine("Tong cua mang la: " + sumArr2);
// Bài 3. Đếm số phần tử chẵn
// Nhập ma trận.
// Đếm xem có bao nhiêu số chẵn.
// Ví dụ
// 1 2
// 4 5
// Kết quả: 2
Console.WriteLine("Nhap vao so dong cua mang:");
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
Console.WriteLine("So so chan cua mang la: " + countEven);

// Bài 4. Tìm phần tử lớn nhất
// Tìm giá trị lớn nhất trong ma trận.
// Ví dụ
// 1 9 3
// 4 5 6
// Max = 9
Console.WriteLine("Nhap vao so dong cua mang:");
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
Console.WriteLine("Min = " + minArr4);

// Nhóm 2 - Vòng lặp và điều kiện (Bài 6 → 10)
// Bài 6. Tính tổng các số dương
// Chỉ cộng những phần tử > 0.
// Ví dụ
// 1 -2
// 3 -4
// Tổng = 4
Console.WriteLine("Nhap vao so dong cho mang:");
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
Console.WriteLine("So cac so am = " + countAmArr5);
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
int sumHangMax = 0;
int sumHangMaxIndex = 1;
for (int i = 0; i < arr8.GetLength(0); i++)
{
    int sumHang = 0;
    for (int j =  0; j < arr8.GetLength(1); j++)
    {
        sumHang += arr8[i, j];
    }
    if (i == 0) sumHangMax = sumHang;
    if (sumHang > sumHangMax) 
    {
        sumHangMax = sumHang;
        sumHangMaxIndex = i + 1;
    }
}
Console.WriteLine($"Hang {sumHangMaxIndex} co tong lon nhat = " + sumHangMax);
// Bài 14. Tìm cột có tổng nhỏ nhất
// Hiển thị:
// Cột 1 có tổng nhỏ nhất = 12
int sumCotMin = 0;
int sumCotMinIndex = 1;
for (int i = 0; i < arr8.GetLength(1); i++)
{
    int sumCot = 0;
    for (int j =  0; j < arr8.GetLength(0); j++)
    {
        sumCot += arr8[j, i];
    }
    if (i == 0) sumCotMin = sumCot;
    if (sumCot < sumCotMin) 
    {
        sumCotMin = sumCot;
        sumCotMinIndex = i + 1;
    }
}
Console.WriteLine($"Cot {sumCotMinIndex} co tong nho nhat = " + sumCotMin);
// Bài 15. Tìm số lớn nhất trên mỗi hàng
// Ví dụ:
// 1 8 3
// 4 5 9
// Hàng 1: 8
// Hàng 2: 9
int maxHang = 0;
for (int i = 0; i < arr8.GetLength(0); i++)
{
    maxHang = arr8[i, 0];
    for (int j =  0; j < arr8.GetLength(1); j++)
    {
        if (arr8[i, j] > maxHang) maxHang = arr8[i, j];
    }
    Console.WriteLine($"Hang {i+1} co max = " + maxHang);
}

// Nhóm 4 - Đường chéo và ma trận vuông (Bài 16 → 18)
// Bài 16. Tính tổng đường chéo chính
// Ma trận vuông.
// 1 2 3
// 4 5 6
// 7 8 9
// Tổng = 1 + 5 + 9 = 15
int sumCheoChinh = 0;
for (int i = 0; i < arr8.GetLength(0); i++)
{
    sumCheoChinh +=  arr8[i, i];
}
Console.WriteLine("Cheo chinh = " + sumCheoChinh);
// Bài 17. Tính tổng đường chéo phụ
// 1 2 3
// 4 5 6
// 7 8 9
// Tổng = 3 + 5 + 7 = 15
int sumCheoPhu = 0;
for (int i = 0; i < arr8.GetLength(0); i++)
{
    sumCheoPhu += arr8[i, arr8.GetLength(1) - 1 - i];
}
Console.WriteLine("Cheo phu = " + sumCheoPhu);
// Bài 18. Đếm số chẵn trên đường chéo chính
// Ví dụ:
// 2 1 1
// 1 4 1
// 1 1 6
// Kết quả = 3
int countChanCheoChinh = 0;
for (int i = 0; i < arr8.GetLength(0); i++)
{
    if (arr8[i, i] % 2 == 0)
    {
        countChanCheoChinh++;
    }
}
Console.WriteLine("So so chan tren cheo chinh = " + countChanCheoChinh);
// Nhóm 5 - Vận dụng (Bài 19 → 20)
// Bài 19. Tìm phần tử lớn thứ hai
// Tìm giá trị lớn thứ hai trong ma trận.
// Ví dụ
// 1 5 9
// 7 3 8
// Kết quả = 8
int max1 = int.MinValue;
int max2 = int.MinValue;
for (int i = 0; i < arr8.GetLength(0); i++)
{
    for (int j = 0; j < arr8.GetLength(1); j++)
    {
        if (arr8[i, j] > max1)
        {
            max2 = max1;
            max1 = arr8[i, j];
        }

        if (arr8[i, j] > max2 && max1 > arr8[i, j])
        {
            max2 = arr8[i, j];
        }
    }
}
Console.WriteLine("So lon thu hai trong mang la " + max2);
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
Console.WriteLine("Nhap vao so dong n cho mang co vua:");
int son20 = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap vao so cot m cho mang co vua:");
int som20  = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap gia tri 0 hoac 1 cho mang");
int[,] mangCoVua = new int[son20, som20];
for (int i = 0; i < son20; i++)
{
    for (int j = 0; j < som20; j++)
    {
        if ((i+j) % 2 == 0) mangCoVua[i, j] = 1;
        else mangCoVua[i, j] = 0;
    }
}
for (int i = 0; i < mangCoVua.GetLength(0); i++)
{
    for (int j = 0; j < mangCoVua.GetLength(1); j++)
    {
        Console.Write(mangCoVua[i,j] + " ");
    }
    Console.WriteLine();
}
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
Console.WriteLine("Nhap so hoc sinh");
int soHocSinh = int.Parse(Console.ReadLine());
double[,] diemMotHs = new double[soHocSinh, 3];
for (int i = 0; i < diemMotHs.GetLength(0); i++)
{
    Console.WriteLine($"Nhap diem cho hoc sinh thu {i+1}");
    for (int j = 0; j < diemMotHs.GetLength(1); j++)
    {
        do
        {
            string diemNhap = Console.ReadLine();
            if (double.TryParse(diemNhap, out double diem)  && diem <= 10 && diem >= 0)
            {
                diemMotHs[i, j] = diem;
                break;
            }
            else
            {
                Console.WriteLine("Vui long nhap diem hop le");
            }
            
        } while (true);
    }
}
// In bảng điểm.
for (int i = 0; i < diemMotHs.GetLength(0); i++)
{
    for (int j = 0; j < diemMotHs.GetLength(1); j++)
    {
        Console.Write(diemMotHs[i, j] + " ");
    }
    Console.WriteLine();
}
// Tính điểm trung bình của từng học sinh.
for (int i = 0; i < diemMotHs.GetLength(0); i++)
{
    double diemTrungBinh = 0;
    for (int j = 0; j < diemMotHs.GetLength(1); j++)
    {
        diemTrungBinh += diemMotHs[i, j];
    }
    diemTrungBinh /= 3;
    Console.WriteLine($"Diem trung binh cua hoc sinh thu {i+1} = {diemTrungBinh}");
}
// Tìm học sinh có điểm trung bình cao nhất.
double diemTBMax = 0;
double diemTBMaxIndex = 1;
for (int i = 0; i < diemMotHs.GetLength(0); i++)
{
    double diemTrungBinh = 0;
    for (int j = 0; j < diemMotHs.GetLength(1); j++)
    {
        diemTrungBinh += diemMotHs[i, j];
    }
    diemTrungBinh /= 3;
    if (i == 0) diemTBMax = diemTrungBinh;
    if (diemTrungBinh > diemTBMax)
    {
        diemTBMax = diemTrungBinh;
        diemTBMaxIndex = i + 1;
    }
}
Console.WriteLine($"Diem trung binh lon nhat la cua hoc sinh thu {diemTBMaxIndex} = {diemTBMax}");
// Đếm số điểm đạt từ 8 trở lên.
int countDiemLH8 = 0;
foreach (double i in diemMotHs)
{
    if (i >= 8) countDiemLH8++;
}
Console.WriteLine("So diem lon hon 8 la: "+countDiemLH8);
// Tìm điểm cao nhất toàn lớp.
for (int i = 0; i < diemMotHs.GetLength(1); i++)
{
    double diemCaoNhatMon = diemMotHs[0,i];
    int index = 1;
    for (int j = 0; j < diemMotHs.GetLength(0); j++)
    {
        if (diemMotHs[j, i] > diemCaoNhatMon)
        {
            diemCaoNhatMon = diemMotHs[j, i];
            index = j+1;
        }
    }
    switch (i)
    {
        case 0: Console.WriteLine($"Diem cao nhat mon Toan la {diemCaoNhatMon} cua ban thu {index}");break;
        case 1: Console.WriteLine($"Diem cao nhat mon Ly la {diemCaoNhatMon} cua ban thu {index}");break;
        case 2: Console.WriteLine($"Diem cao nhat mon Hoa la {diemCaoNhatMon} cua ban thu {index}");break;
    }
}
