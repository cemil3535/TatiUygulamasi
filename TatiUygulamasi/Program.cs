// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
// degiskenlerin tanimlanmasi
loopStart: // kullanici baska bir tatil planlamak yapmak istediginde dongunun basina gitmesini saglayan              goto ETIKETI
string userInput, selectTransport , anotherPlan;
int countPeople = 0;
double bodrumPrice = 4000, marmarisPrice = 3000, cesmePrice = 5000,  airTransport = 4000, highway = 1500 , sumPrice;


//kullaniciya lokasyon seciminin yaptirilmasi
do
{
    Console.WriteLine("Lutfen gitmek istediginiz lokasyonu seciniz.\n1- Bodrum (Paket baslangis fiyati 4.000 TL)\n2- Marmaris (Paket başlangıç fiyatı 3.000 TL)\n3- Çeşme (Paket başlangıç fiyatı 5.000 TL)");
    userInput = Console.ReadLine().ToUpper();
    if (userInput.Equals("BODRUM") || userInput.Equals("MARMARİS") || userInput.Equals("ÇEŞME"))
    {
        break;
    }
    Console.WriteLine("Girdiginiz lokasyon bulunamadi.Lutfen asagida verilen lokasyonlardan birisini seciniz.");

Console.WriteLine("----------------------------------------------------------");

//Kullaniciya kac kisi olarak tatail yapacaginin sorulmasi
} while (true);

Console.WriteLine("Kac kisi tatil yapmak istiyorsunuz?");
countPeople = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("----------------------------------------------------------");

//kullanicinin sectigi lokasyonda yapacagi aktiviteleri belirtilmesi
switch (userInput)
{
    case "BODRUM":
        Console.WriteLine("Bodrum'a tatil icin gitmek istiyorsunuz.Bol bol denize girip,guneslene bilirsiniz.Bodrum gece hayatinin tadini cikarabilirsiniz.Iyi eglenceler.");
        break;

    case "MARMARİS":
        Console.WriteLine("Marmaris'e tatil icin gitmek istiyorsunuz. Ormanlarda yurus yapabilirsiniz. Gunes' deniz, sahili ve gece hayati. Have fun");
        break;

    case "ÇEŞME":
        Console.WriteLine("Cesme'yi tatil icin sectiniz.Isiniz zor.Fiyatlar cok pahali.Allah kolaylik versin.");
        break;
}
Console.WriteLine("----------------------------------------------------------");

// kullanicinin ne sekilde tatile gideceginin sectirilmesi. secimine gore odemesi gereken tutarin hesaplanmasi
do
{
    Console.WriteLine("Tatile ne sekilde gitmek istiyorsunuz?\n1- Kara yolu (Kisi basi ulasim miktari gidis-donus 1500 TL\n2- Hava yolu (Kisi basi ulasim miktari gidis-donus 4000 TL\nLutfen yukaridaki seceneklerden bir tanesini secmek icin 1 veya 2 sayisini giriniz.");
    selectTransport = Console.ReadLine();

    if (selectTransport.Equals("1") || selectTransport.Equals("2"))
    {
        switch (selectTransport)
        {
            case "1":

                if (userInput.Equals("BODRUM"))
                {
                    sumPrice = (bodrumPrice + highway) * countPeople;
                    Console.WriteLine("Girdiginiz bilgilere gore toplam odemeniz gereken tutar: " + sumPrice);
                }
                else if (userInput.Equals("MARMARİS"))
                {
                    sumPrice = (marmarisPrice + highway) * countPeople;
                    Console.WriteLine("Girdiginiz bilgilere gore toplam odemeniz gereken tutar: " + sumPrice);
                }
                else if(userInput.Equals("ÇEŞME"))
                { 
                sumPrice = (cesmePrice + highway) * countPeople;
                Console.WriteLine("Girdiginiz bilgilere gore toplam odemeniz gereken tutar: " + sumPrice); 
                }
                break;

            case "2":

                if (userInput.Equals("BODRUM"))
                {
                    sumPrice = (bodrumPrice + airTransport) * countPeople;
                    Console.WriteLine("Girdiginiz bilgilere gore toplam odemeniz gereken tutar: " + sumPrice);
                }
                else if (userInput.Equals("MARMARİS"))
                {
                    sumPrice = (marmarisPrice + airTransport) * countPeople;
                    Console.WriteLine("Girdiginiz bilgilere gore toplam odemeniz gereken tutar: " + sumPrice);
                }
                else
                {
                    sumPrice = (cesmePrice + airTransport) * countPeople;
                    Console.WriteLine("Girdiginiz bilgilere gore toplam odemeniz gereken tutar: " + sumPrice);
                }
                break;
        }
        break;
    }
    else

        Console.WriteLine("Yanlis deger girdiniz. Lutfen tekrar deneyiniz.");

} while (true);

Console.WriteLine("----------------------------------------------------------");
//Kullaniciya baska bir tatil plani yapmak isteyip istemediginin sorulmasi ve goto ile loopStart etiketine giderek dongunun yeniden balkatilmasi
Console.WriteLine("Baska bir tatil planlamak istiyor musunuz? Evet veya Hayir Yaziniz");
anotherPlan = Console.ReadLine().ToUpper();
if (anotherPlan == "EVET")
{
    goto loopStart;
}
else
    Console.WriteLine("Bizi sectiginiz icin tesekkur ederiz. Have Fun!!!");







