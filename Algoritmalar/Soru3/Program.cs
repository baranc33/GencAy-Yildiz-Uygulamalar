// 1 den 10 kadar olan sayılarının küplerinin toplamını bulan program;
/*Çözüm 1*
double ToplamSonuc = 0;
for (int i = 1; i <= 10; i++)
{
    ToplamSonuc+=Math.Pow(i, 3);
}

Console.WriteLine(ToplamSonuc);
*/

/*Çözüm 2
int sayac = 1;
double ToplamSonuc = 0;
while (true)
{
    sayac++;

    ToplamSonuc+=Math.Pow(sayac, 3);

    if (sayac == 10) break;
}

Console.WriteLine(ToplamSonuc);
*/
/*Çözüm 3
int sayac = 1;
double ToplamSonuc = 0;
while (sayac < 10)// sayaç içerde arttığı için 1 eksik hesaplamalıyız
{
    sayac++;

    ToplamSonuc+=Math.Pow(sayac, 3);

}
Console.WriteLine(ToplamSonuc);

*/
/*Çözüm 4
int sayac = 1;
double ToplamSonuc = 0;
do
{
    sayac++;

    ToplamSonuc+=Math.Pow(sayac, 3);
} while (sayac < 10);// sayaç içerde arttığı için 1 eksik hesaplamalıyız

Console.WriteLine(ToplamSonuc);

*/
/*Çözüm 5*/

int sayac = 1;
double ToplamSonuc = 0;
do
{
    sayac++;

    ToplamSonuc+=Math.Pow(sayac, 3);
    if (sayac == 10) break;

} while (true);// sayaç içerde arttığı için 1 eksik hesaplamalıyız

Console.WriteLine(ToplamSonuc);
