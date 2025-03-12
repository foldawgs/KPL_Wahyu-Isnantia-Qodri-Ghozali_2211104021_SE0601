
<div align="center">
JURNAL <br>
KONSTRUKSI PERANGKAT LUNAK <br>
<br>
MODUL V <br>
<!-- JUDUL -->
 <br>

<img src="https://lac.telkomuniversity.ac.id/wp-content/uploads/2021/01/cropped-1200px-Telkom_University_Logo.svg-270x270.png" width="250px">

<br>

Disusun Oleh: <br>
Wahyu Isnantia Qodri Ghozali/2211104021 <br>
SE-06-01 <br>

<br>

Asisten Praktikum : <br>
Naufal El Kamil Aditya Pratama Rahman <br>
Imelda Alfina Palupi Dewi <br>

<br>

Dosen Pengampu : <br>
Yudha Islami Sulistya, S.Kom., M.Cs <br>

<br>

PROGRAM STUDI S1 REKAYASSA PERANGKAT LUNAK <br>
FAKULTAS INFORMATIKA <br> 
TELKOM UNIVERSITY PURWOKERTO <br>

</div>

## 1. Implementasi Generic Method
<img src="img/JURNAL/JURNAL1.png" width="500px">
<img src="img/JURNAL/JURNAL2.png" width="500px">
<img src="img/JURNAL/JURNAL3.png" width="500px">


### Source Code
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Penjumlahan
{
    public dynamic JumlahTigaAngka(dynamic a, dynamic b, dynamic c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Penjumlahan penjumlahan = new Penjumlahan();

        // NIM berakhiran 1, maka tipe data input adalah float
        float angka1 = 12.0f;
        float angka2 = 34.0f;
        float angka3 = 56.0f;

        var hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
        Console.WriteLine("Hasil Penjumlahan: " + hasil);
    }
}
```
### Output
<img src="img/JURNAL/JURNAL4.png" width="500px">
<img src="img/JURNAL/JURNAL5.png" width="500px">

### Penjelasan
Di class `Penjumlahan` akan dibuat method `JumlahTigaAngka` yang menggunakan parameter `dynamic` untuk memungkinkan operasi penjumlahan pada berbagai tipe data numerik. Di method `Main` dalam class `Program` akan dibuat objek `Penjumlahan` dan memanggil `JumlahTigaAngka` dengan tiga angka bertipe `float`, sesuai aturan berdasarkan akhiran NIM, lalu hasilnya akan ditampilkan ke konsol.

## 2. Implementasi Generic Class
### Source Code
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_2211104021_bag2
{
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.UtcNow);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<int> database = new SimpleDataBase<int>();

            // NIM berakhiran 1, maka tipe data input adalah float, tetapi kita gunakan int untuk contoh ini
            database.AddNewData(12);
            database.AddNewData(34);
            database.AddNewData(56);

            database.PrintAllData();
        }
    }
}
```

### Output
<img src="img/JURNAL/JURNAL6.png" width="500px">
<img src="img/JURNAL/JURNAL7.png" width="500px">

### Penjelasan
Di class `SimpleDataBase<T>` akan dibuat dua properti, yaitu `storedData` sebagai list untuk menyimpan data bertipe generik `T` dan `inputDates` sebagai list bertipe `DateTime` untuk menyimpan waktu penyimpanan data. Di konstruktor `SimpleDataBase()` akan diinisialisasi kedua properti sebagai list kosong. Di method `AddNewData(T)` akan menambahkan data baru ke `storedData` dan mencatat waktu input ke `inputDates`. Di method `PrintAllData()` akan mencetak seluruh data beserta waktu penyimpanannya dalam format UTC. Di method `Main()` akan dibuat objek `SimpleDataBase<int>` untuk menyimpan tiga angka sesuai aturan NIM sebelum mencetak hasilnya ke konsol.