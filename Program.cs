int nilai;
string nama;

Console.WriteLine("Aplikasi NIlai Siswa");

Console.Write("Nama Siswa: ");  
nama = Console.ReadLine();

Console.Write("Nilai: ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75 )
{
    Console.WriteLine("Selamat " + nama + ", Anda Lulus!");
}
else
{
    Console.WriteLine("Maaf " + nama + ", Anda Tidak Lulus.");
}