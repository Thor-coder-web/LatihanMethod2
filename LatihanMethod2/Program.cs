//Latihan Method 2

int jumlahItem, hargaItem;

decimal diskon, totalBayar;

decimal hitungDiskon (int jml_item)
{
    if (jml_item == 5)
    {
        return 50000;
    }
    else if (jml_item == 10)
    {
        return 75000;
    }
    else
    {
        return 0;
    }
}

decimal hitungTotalBayar (int jml_item, int harga_item, decimal diskon)
{
    return jml_item * harga_item - diskon;
}

Console.WriteLine("Masukkan Jumlah Item: ");
jumlahItem = int.Parse(Console.ReadLine());

Console.WriteLine("Masukkan Harga Item: Rp ");
hargaItem = int.Parse(Console.ReadLine());

diskon = hitungDiskon(jumlahItem);
totalBayar =hitungTotalBayar(jumlahItem, hargaItem, diskon);

Console.WriteLine($"Total Bayar: Rp {totalBayar}");