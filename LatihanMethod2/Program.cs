//Latihan Method 2  

int harga = 20000;
void hitungDiskon (int a)
{

    if (a == 5)
    {
        Console.WriteLine($"{a * harga}");
    }
    else if (a == 10)
    {
        Console.WriteLine($"{a * harga}");
    }
    else
    {
        Console.WriteLine($"Tidak mendapatkan potongan { a * harga}");
    }

}
hitungDiskon (11);