using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankaentegrasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[args.Length];

            for (int i = 0; i < arr.Length; i++)

            {

                arr[i] = Convert.ToInt32(args[i]);

                Console.WriteLine("The index number of Array = " + i.ToString()
                    + " value = " + arr[i].ToString() + "\n");
            }

            Console.WriteLine("BANKAX İnternet Bankacılık Sistemleri..");
            string isim = "11122233344"; // Veritabanı olmadığı için bir değer belirliyoruz... 
            string sifre = "454545"; // Kullanıcı bu isim ve şifreyi girerse kabul edilecek... 

            Console.Write("T.C Kimlik No:");
            string mail = Console.ReadLine();
            Console.Write("Şifreniz...:");
            string giris = Console.ReadLine();

            Console.WriteLine("Giriş bilgileriniz kontrol ediliyor...");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
            }
            Console.ReadKey();

            if (mail == isim && sifre == giris) // Giriş ve mail adresinin doğru olup olmadığını kontrol ediyoruz...
                Console.WriteLine("BANKAX Bankacılık Sistemlerine Hoşgeldiniz...:");
            else
                Console.WriteLine("Giriş işlemi yapılamadı...");
            int hesap = 1000;
            int secim;
            do
            {
                Console.WriteLine(" 1-Hesap Göster \n 2-Para Yatırma \n 3-Para Çekme \n 4-Para Transferleri \n 5-Ödeme Yöntemleri \n 6-Kredi İşlemleri \n 7-Kartlar \n 8-Ayarlar \n 9-Çıkış");
                secim = Convert.ToInt16(Console.ReadLine());

                if (secim == 1)
                {
                    Console.WriteLine("Hesabınızda " + hesap + "TL bulunmaktadır.");
                    Console.ReadLine();
                }
                else if (secim == 2)
                {
                    Console.WriteLine("Kaç para yatırmak istiyorsunuz?");
                    int yatirilan = Convert.ToInt16(Console.ReadLine());
                    hesap = hesap + yatirilan;
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Kaç para çekmek istiyorsunuz?");
                    int cekim = Convert.ToInt16(Console.ReadLine());

                    if (cekim > hesap)
                    {
                        Console.WriteLine("Yeterli bakiyeniz yoktur.");
                    }
                    else hesap = hesap - cekim;
                }
                if (secim == 4)
                {
                    Console.WriteLine("Transfer Yapmak İstediğiniz Hesap Bilgilerini Giriniz.");
                    string Iban = "";
                    string Ucret = "";

                    Console.Write("IBAN:");
                    string IBAN = Console.ReadLine();
                    Console.Write("Yatırılacak Tutar:");
                    string UCRET = Console.ReadLine();
                    Console.WriteLine("Para Transfer İşleminiz Gerçekleşmiştir.");
                }
                if (secim == 5)
                {
                    Console.WriteLine("Ödeme Yapabileceğiniz İşlemler");
                    Console.WriteLine(" 10-Fatura Ödeme \n 20-GSM Ödemeleri \n 30-Kart Ödemeleri \n 40-Vergi Ödemeleri");
                    secim = Convert.ToInt16(Console.ReadLine());

                    if (secim == 10)
                    {
                        Console.WriteLine("Ödeme Yapacağınız Fatura Numarasını Giriniz");
                        string fatura = "";
                        string ucreti = "";

                        Console.Write("Fatura No:");
                        string FATURA = Console.ReadLine();
                        Console.Write("Fatura Ücreti:");
                        string UCRETİ = Console.ReadLine();

                        Console.WriteLine("Fatura Ödeme İşleminiz Başarıyla Gerçekleşmiştir...");
                    }
                    if (secim == 20)
                    {
                        Console.WriteLine("Ödeme yapmak istediğiniz operatörü seçiniz.");
                        Console.WriteLine(" 11-Turkcell \n 12-Vodafone \n 13-Turk Telekom");
                        secim = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Telefon Numarasını Giriniz.");
                        string numara = "";
                        string ucret = "";

                        Console.Write("Telefon No:");
                        string NUMARA = Console.ReadLine();
                        Console.Write("Yatıracağınız Tutarı Giriniz:");
                        string UCRET = Console.ReadLine();

                        Console.WriteLine("TL Yükleme İşleminiz Başarıyla Gerçekleşti...");
                    }
                    if (secim == 30)
                    {
                        Console.WriteLine("Ödeme Yapmak İstediğiniz Kart Bilgilerini Seçiniz!");
                        Console.WriteLine(" 1-(Banka) Kartı Ödemeleri \n 2-(Kredi) Kartı Ödemeleri \n 3-Diğer Kredi Kartları");
                        secim = Convert.ToInt16(Console.ReadLine());


                        Console.WriteLine("Seçtiğiniz Kart Bilgileri Doğrulanıyor...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        Console.WriteLine("Kartınıza ait ödeme dönemini seçiniz...");
                        Console.WriteLine(" 1-15 GÜNLÜK DÖNEM \n 2-30 GÜNLÜK DÖNEM \n 3-90 GÜNLÜK DÖNEM");
                        secim = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Ödenecek Tutarı Giriniz!");
                        string tutar = "";

                        Console.Write("Ödenecek Tutar:");
                        string TUTAR = Console.ReadLine();

                        Console.WriteLine("Kart ödemeleriniz başarıyla gerçekleşmiştir...");
                    }
                    if (secim == 40)
                    {
                        Console.WriteLine("Ödeme Yapmak İstediğiniz Vergi Ödemesini Seçiniz!");
                        Console.WriteLine(" 14-Motorlu Taşıt Vergisi \n 24-Belediye Vergi Ödemesi \n 34-HGS Ödemeleri \n 44-SGK Ödemeleri \n 54-Trafik Cezası Ödemeleri \n 64-Pasaport ve Harç Ödemeleri");
                        secim = Convert.ToInt16(Console.ReadLine());
                        if (secim == 14)
                        {
                            Console.WriteLine("Motorlu Taşıt Plakasını Giriniz!");
                            string plaka = "";
                            string donem = "";

                            Console.Write("Plakayı Giriniz:");
                            string PLAKA = Console.ReadLine();
                            Console.Write("Vergi Yılını Giriniz:");
                            string DONEM = Console.ReadLine();

                            Console.WriteLine("MTV Ödeminiz başarıyla gerçekleşti...");
                        }
                        if (secim == 24)
                        {
                            Console.WriteLine("Bulunduğunuz İli Giriniz!");
                            string ıl = "";
                            string ılce = "";
                            string vergitur = "";
                            string ucret = "";

                            Console.Write("İL:");
                            string IL = Console.ReadLine();
                            Console.Write("İLÇE:");
                            string ILCE = Console.ReadLine();
                            Console.Write("Vergi Türü:");
                            string VERGİTUR = Console.ReadLine();
                            Console.Write("Vergi Ücreti:");
                            string UCRET = Console.ReadLine();

                            Console.WriteLine("Vergi ödemeniz başarıyla gerçekleşti...");

                        }
                        if (secim == 34)
                        {
                            Console.WriteLine("HGS Ödemesi Yapacağınız Plakayı Giriniz.!");
                            string plaka = "";
                            string ucret = "";

                            Console.Write("Plakayı Giriniz:");
                            string PLAKA = Console.ReadLine();
                            Console.Write("HGS Borç tutarını giriniz:");
                            string UCRET = Console.ReadLine();

                            Console.WriteLine("HGS Ödeminiz başarıyla gerçekleşmiştir...");
                        }
                        if (secim == 44)
                        {
                            Console.WriteLine("Ödeme Yapacağınız Prim Grubunu Giriniz...");
                            string grup = "";
                            string ucret = "";

                            Console.Write("Prim Grubunu Giriniz:");
                            string GRUP = Console.ReadLine();
                            Console.Write("Prim Ödemesi Tutarı:");
                            string UCRET = Console.ReadLine();

                            Console.WriteLine("Prim ödemesi işleminiz başarıyla gerçekleşti...");
                        }
                        if (secim == 54)
                        {
                            Console.WriteLine("Trafik Cezası Ödemesi Yapacağınız Plaka..!");
                            string plaka = "";
                            string donem = "";
                            string ucret = "";

                            Console.Write("Plakayı Giriniz:");
                            string PLAKA = Console.ReadLine();
                            Console.Write("Ceza Dönemini Giriniz:");
                            string DONEM = Console.ReadLine();
                            Console.Write("Ceza Ücreti:");
                            string UCRET = Console.ReadLine();

                            Console.WriteLine("Trafik Cezası Ödemeniz başarıyla gerçekleşti...");
                        }
                        if (secim == 64)
                        {
                            Console.WriteLine("Pasaport Harcı için Ödeme Türünüzü Giriniz!");
                            string odemetur = "Pasaport ve Yurt dışı harcı";
                            string vergi = "";
                            string odeme = "";

                            Console.Write("Ödeme türünüzü giriniz:");
                            string ODEMETUR = Console.ReadLine();
                            Console.Write("Vergi Dairesi:");
                            string VERGİ = Console.ReadLine();
                            Console.Write("Harç Bedeli:");
                            string ODEME = Console.ReadLine();

                            Console.WriteLine("Harç ödeminiz başarıyla gerçekleşmiştir...");
                        }
                    }
                }
                if (secim == 6)
                {
                    Console.WriteLine("Kredi İşlemleri Sayfasına Yönlendiriliyorsunuz...");
                    for (int i = 1; i < 5; i++)
                    {
                        Console.WriteLine(i);
                        System.Threading.Thread.Sleep(1000);
                    }
                    Console.ReadKey();
                    Console.WriteLine(" 17-Kredilerim \n 27-Bireysel İhtiyaç Kredisi Başvurusu \n 37-Kredi Hesaplama \n 47-Konut Kredisi Başvurusu");
                    secim = Convert.ToInt16(Console.ReadLine());

                    if (secim == 17)
                    {
                        Console.WriteLine("Kredileriniz aşağıda listelenmektedir...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();
                    }
                    if (secim == 27)
                    {
                        Console.WriteLine("Kredi Başvurusunda bulunmak için lütfen bilgileri giriniz!");
                        string egitim = "";
                        string calısma = "";
                        string gelir = "";

                        Console.Write("Eğitim Durumunuz:");
                        string EGİTİM = Console.ReadLine();
                        Console.Write("Çalışma Alanınız:");
                        string CALISMA = Console.ReadLine();
                        Console.Write("Aylık Toplam Geliriniz:");
                        string GELİR = Console.ReadLine();

                        Console.WriteLine("İhtiyaç Krediniz Hesaplanıyor...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        Console.WriteLine("İhtiyaç kredisi hesaplamanız tarafınıza sunulmuştur. İyi günler dileriz..");
                    }
                    if (secim == 37)
                    {
                        Console.WriteLine("Kredi Tipinizi Seçiniz:");
                        Console.WriteLine(" 44-Bireysel İhtiyaç Kredisi \n 45-Konut Kredisi \n 46-Taşıt Kredisi");
                        secim = Convert.ToInt16(Console.ReadLine());

                        if (secim == 44)
                        {
                            Console.WriteLine("Çekmek istediğiniz kredi tutarını giriniz:");
                            string tutar = "";

                            Console.Write("Kredi Tutarı:");
                            string TUTAR = Console.ReadLine();
                            for (int i = 1; i < 5; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            Console.WriteLine("Kredi başvurunuz için talebiniz alınmıştır. İyi günler dileriz...");
                        }
                        if (secim == 45)
                        {
                            Console.WriteLine("Çekmek istediğiniz kredi tutarını giriniz:");
                            string tutar = "";

                            Console.Write("Kredi Tutarı:");
                            string TUTAR = Console.ReadLine();
                            for (int i = 1; i < 5; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            Console.WriteLine("Kredi başvurunuz için talebiniz alınmıştır. İyi günler dileriz...");
                        }
                        if (secim == 46)
                        {
                            Console.WriteLine("Çekmek istediğiniz kredi tutarını giriniz:");
                            string tutar = "";

                            Console.Write("Kredi Tutarı:");
                            string TUTAR = Console.ReadLine();
                            for (int i = 1; i < 5; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            Console.WriteLine("Kredi başvurunuz için talebiniz alınmıştır. İyi günler dileriz...");
                        }
                    }
                    if (secim == 47)
                    {
                        Console.WriteLine("Kredi işlem sayfasına yönlendiriliyorsunuz...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();
                        Console.WriteLine("Çekmek istediğiniz Konut kredisi tutarını giriniz:");
                        string tutar = "";
                        string vade = "";
                        string gelir = "";
                        string telefon = "";

                        Console.Write("Kredi tutarı:");
                        string TUTAR = Console.ReadLine();
                        Console.Write("Kredi Vadesi:");
                        string VADE = Console.ReadLine();
                        Console.Write("Aylık Net Geliriniz:");
                        string GELİR = Console.ReadLine();
                        Console.Write("Cep Telefonunuz:");
                        string TELEFON = Console.ReadLine();

                        Console.WriteLine("Konut kredisi talebiniz alınmıştır. Tarafınıza geri dönüş sağlanacaktır. İyi günler dileriz...");
                    }
                }
                if (secim == 7)
                {
                    Console.WriteLine(" 18-Kartlar \n 28-Başvuru \n 38-Kart Ayarları");
                    secim = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Kart işlem sayfasına yönlendiriliyorsunuz...");
                    for (int i = 1; i < 5; i++)
                    {
                        Console.WriteLine(i);
                        System.Threading.Thread.Sleep(1000);
                    }
                    Console.ReadKey();

                    if (secim == 18)
                    {
                        Console.WriteLine(" 22-Kredi Kartları \n 32-Banka Kartları \n 42-Diğer Kartlar");
                        secim = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Kart işlem sayfasına yönlendiriliyorsunuz...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        if (secim == 22)
                        {
                            Console.WriteLine("Kart bilgileriniz bu sayfada bulunmaktadır.");
                            string kartno = "";
                            string ad = "";
                            string hesapno = "";

                            Console.Write("Kart Numarası:");
                            string KARTNO = Console.ReadLine();
                            Console.Write("Kart sahibi AD/SOYAD:");
                            string AD = Console.ReadLine();
                            Console.Write("Hesap Numarası:");
                            string HESAPNO = Console.ReadLine();

                            Console.WriteLine("İşleminiz tamamlanmıştır. İyi günler dileriz...");
                        }
                        if (secim == 32)
                        {
                            Console.WriteLine("Kart bilgileriniz bu sayfada bulunmaktadır.");
                            string kartno = "";
                            string ad = "";
                            string hesapno = "";

                            Console.Write("Kart Numarası:");
                            string KARTNO = Console.ReadLine();
                            Console.Write("Kart sahibi AD/SOYAD:");
                            string AD = Console.ReadLine();
                            Console.Write("Hesap Numarası:");
                            string HESAPNO = Console.ReadLine();

                            Console.WriteLine("İşleminiz tamamlanmıştır. İyi günler dileriz...");
                        }
                        if (secim == 42)
                        {
                            Console.WriteLine("Bu sayfa tasarım aşamasındadır. Bilgilendirme!!!");
                        }
                    }
                    if (secim == 28)
                    {
                        Console.WriteLine("Başvuru yapmak istediğiniz kart türünü seçiniz.!");
                        Console.WriteLine(" 01-Kredi Kartı Başvurusu \n 02-Banka Kartı Başvurusu");
                        secim = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Kart başvurusu sayfasına yönlendiriliyorsunuz...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        if (secim == 01)
                        {
                            Console.WriteLine("Lütfen istenen bilgileri giriniz.!");
                            string egitim = "";
                            string alan = "";
                            string gelir = "";
                            string email = "";
                            string telefon = "";
                            string adres = "";

                            Console.Write("Eğitim Durumunuz:");
                            string EGİTİM = Console.ReadLine();
                            Console.Write("Çalışma Alanınız:");
                            string ALAN = Console.ReadLine();
                            Console.Write("Aylık Toplam Geliriniz:");
                            string GELİR = Console.ReadLine();
                            Console.Write("E-mail adresiniz:");
                            string EMAİL = Console.ReadLine();
                            Console.Write("Telefon Numaranız:");
                            string TELEFON = Console.ReadLine();
                            Console.Write("Teslimat Adresiniz:");
                            string ADRES = Console.ReadLine();
                            Console.WriteLine("Bilgileriniz Kontrol ediliyor...");
                            for (int i = 1; i < 5; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            Console.WriteLine("Kredi kartı başvuru talebiniz alınmıştır. Kartınız Tarafınıza en kısa sürede ulaşacaktır. İyi günler dileriz...");
                        }
                        if (secim == 02)
                        {
                            Console.WriteLine("Lütfen istenen bilgileri giriniz.!");
                            string egitim = "";
                            string alan = "";
                            string gelir = "";
                            string email = "";
                            string telefon = "";
                            string adres = "";

                            Console.Write("Eğitim Durumunuz:");
                            string EGİTİM = Console.ReadLine();
                            Console.Write("Çalışma Alanınız:");
                            string ALAN = Console.ReadLine();
                            Console.Write("Aylık Toplam Geliriniz:");
                            string GELİR = Console.ReadLine();
                            Console.Write("E-mail adresiniz:");
                            string EMAİL = Console.ReadLine();
                            Console.Write("Telefon Numaranız:");
                            string TELEFON = Console.ReadLine();
                            Console.Write("Teslimat Adresiniz:");
                            string ADRES = Console.ReadLine();
                            Console.WriteLine("Bilgileriniz Kontrol ediliyor...");
                            for (int i = 1; i < 5; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            Console.WriteLine("Banka kartı başvuru talebiniz alınmıştır. Kartınız tarafınıza en kısa sürede ulaştırılacaktır. İyi günler dileriz...");
                        }
                    }
                    if (secim == 38)
                    {
                        Console.WriteLine(" 54-Kart Kapama \n 64-Kart Yetkileri \n 74-Şifre İşlemleri");
                        secim = Convert.ToInt16(Console.ReadLine());

                        if (secim == 54)
                        {
                            Console.WriteLine(" Seçilen Kartı Kapatma!!!");
                            Console.WriteLine("Kart kapama işleminiz onaylanıyor...");
                            for (int i = 1; i < 5; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            Console.WriteLine("Kart Kapama işleminiz başarıyla gerçekleşmiştir. İyi günler dileriz...");
                        }
                        if (secim == 64)
                        {
                            Console.WriteLine("Kart Yetkileri İşlemleri");
                            Console.WriteLine(" 03-Temassız Kart \n 04-E-ticaret özelliği");
                            secim = Convert.ToInt16(Console.ReadLine());

                            if (secim == 03)
                            {
                                Console.WriteLine("Kartınızı temassız özelliği açık bulunmaktadır.");
                                Console.WriteLine("Kapatmak için lütfen talebinizi bildirin.!");
                                string kart = "kapat";

                                Console.Write("Temassız Kapatma:");
                                string KART = Console.ReadLine();

                                if (kart == KART) // Doğru olup olmadığını kontrol ediyoruz...
                                    Console.WriteLine("Temassız özelliği kapama işleminiz başarıyla gerçekleşmiştir. İyi günler dileriz...");

                            }
                            if (secim == 04)
                            {
                                Console.WriteLine("Kartınız internet alışverişlerinde kullanılabilmektedir. ");
                                Console.WriteLine("Kapatma için lütfen talebinizi bildirin!");
                                string ticaret = "kapat"; // Kullanıcı bu bilgiyi girerse kabul edilecek...

                                Console.Write("E-ticaret özelliği kapatma:");
                                string TİCARET = Console.ReadLine();

                                if (ticaret == TİCARET) // Doğru olup olmadığını kontrol ediyoruz...
                                    Console.WriteLine("E-ticaret özelliği kapatma işleminiz başarıyla gerçekleşmiştir. İyi günler dileriz...");
                            }
                        }
                        if (secim == 74)
                        {
                            Console.WriteLine("İşlem yapmak istediğiniz kartı seçiniz!");
                            Console.WriteLine(" 05-Banka kartı \n 06-Kredi kartı");
                            secim = Convert.ToInt16(Console.ReadLine());

                            if (secim == 05)
                            {
                                Console.WriteLine("Karta ait Güvenlik numarasını giriniz:");
                                string guvenlik = "";
                                string şifre = "";
                                string tsifre = "";

                                Console.Write("Güvenlik Numarası:");
                                string GUVENLİK = Console.ReadLine();
                                Console.Write("Yeni Şifreniz:");
                                string ŞİFRE = Console.ReadLine();
                                Console.Write("Şifre Tekrar:");
                                string TSİFRE = Console.ReadLine();
                                Console.WriteLine("Kartınızın şifresi değiştiriliyor...");
                                for (int i = 1; i < 5; i++)
                                {
                                    Console.WriteLine(i);
                                    System.Threading.Thread.Sleep(1000);
                                }
                                Console.ReadKey();

                                Console.WriteLine("Kartınızın şifresi başarıyla değiştirildi. İyi günler dileriz...");
                            }
                            if (secim == 06)
                            {

                                Console.WriteLine("Karta ait Güvenlik numarasını giriniz:");
                                string guvenlik = "";
                                string şifre = "";
                                string tsifre = "";

                                Console.Write("Güvenlik Numarası:");
                                string GUVENLİK = Console.ReadLine();
                                Console.Write("Yeni Şifreniz:");
                                string ŞİFRE = Console.ReadLine();
                                Console.Write("Şifre Tekrar:");
                                string TSİFRE = Console.ReadLine();
                                Console.WriteLine("Kartınızın şifresi değiştiriliyor...");
                                for (int i = 1; i < 5; i++)
                                {
                                    Console.WriteLine(i);
                                    System.Threading.Thread.Sleep(1000);
                                }
                                Console.ReadKey();

                                Console.WriteLine("Kartınızın şifresi başarıyla değiştirildi. İyi günler dileriz...");
                            }
                        }
                    }

                }
                if (secim == 8)
                {
                    Console.WriteLine(" 81-Akıllı Asistan \n 82-Şifre Değişikliği \n 83-QR Kod İşlemleri \n 84-Yetki İşlemleri \n 85-Hesap Kısıtlamaları \n 86-Erişim Yetkisi");
                    secim = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                    for (int i = 1; i < 5; i++)
                    {
                        Console.WriteLine(i);
                        System.Threading.Thread.Sleep(1000);
                    }
                    Console.ReadKey();

                    if (secim == 81)
                    {
                        Console.WriteLine("Akıllı Asistan özelliğini etkinleştirme...");
                        Console.WriteLine(" 87-Etkinleştirme Açık \n 88-Etkinleştirme Kapalı");
                        secim = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("İşleminiz gerçekleştiriliyor...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        if (secim == 87)
                        {
                            Console.WriteLine("İşleminiz başarıyla gerçekleşti... İyi Günler dileriz...");
                        }
                        if (secim == 88)
                        {
                            Console.WriteLine("İşleminiz başarıyla gerçekleşti. İyi günler dileriz...");
                        }
                    }
                    if (secim == 82)
                    {
                        Console.WriteLine("Şifre değiştirme işlemi.");
                        string eskisifre = "";
                        string yenisifre = "";
                        string tekrarsifre = "";

                        Console.Write("Eski Şifrenizi Giriniz:");
                        string ESKİSİFRE = Console.ReadLine();
                        Console.Write("Yeni Şifreniz:");
                        string YENİSİFRE = Console.ReadLine();
                        Console.Write("Yeni Şifre Tekrar:");
                        string TEKRARSİFRE = Console.ReadLine();

                        Console.WriteLine("Şifre değiştirme işleminiz gerçekleştiriliyor...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        Console.WriteLine("Şifre değiştirme işleminiz başarıyla gerçekleştirildi. İiyi günler dileriz...");
                    }
                    if (secim == 83)
                    {
                        Console.WriteLine("QR Kod işlemleri.");
                        Console.WriteLine(" 89-Etkinleştirme Açık \n 90-Etkinleştirme Kapalı");
                        secim = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("İşleminiz gerçekleştiriliyor...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        if (secim == 89)
                        {
                            Console.WriteLine("İşleminiz başarıyla gerçekleştirildi. İyi günler dileriz...");
                        }
                        if (secim == 90)
                        {
                            Console.WriteLine("İşleminiz başarıyla gerçekleştirildi. İyi günler dileriz...");
                        }
                    }
                    if (secim == 84)
                    {
                        Console.WriteLine("Yetki İşlemleri ");
                        Console.WriteLine(" 91-Para Transferleri \n 92-Ödemeler");
                        secim = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("İşleminiz gerçekleştiriliyor...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        if (secim == 91)
                        {
                            Console.WriteLine("Para Transferleri yetkileriniz bankamızca otomatik olarak açılmıştır.");
                        }
                        if (secim == 92)
                        {
                            Console.WriteLine("Ödeme yetkileriniz bankamızca otomatik olarak açılmıştır.");
                        }
                    }
                    if (secim == 85)
                    {
                        Console.WriteLine("Hesap Kısıtlamalarınız");
                        Console.WriteLine("Bilgilendirme! Hesap kısıtlamalarınız bankamıza iletmiş olduğunuz yetkiler doğrultusunda belirlenmiştir. ");
                        Console.WriteLine("İnternet şubesi yetkileriniz.");
                        Console.WriteLine(" 93-Etkinleştirme Açık \n 94-Etkinleştirme Kapalı");
                        secim = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("İşleminiz gerçekleştiriliyor...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        if (secim == 93)
                        {
                            Console.WriteLine("İşleminiz başarıyla gerçekleştirildi. İyi günler dileriz...");
                        }
                        if (secim == 94)
                        {
                            Console.WriteLine("İşleminiz başarıyla gerçekleştirildi. İyi günler dileriz...");
                        }
                    }
                    if (secim == 86)
                    {
                        Console.WriteLine("Sayın Müşterimiz;");
                        Console.WriteLine("Kişisel verilerinize YapıKredi Bankacılık olarak erişilmesini,");
                        Console.WriteLine("Kabul ediyor musunuz?");
                        Console.WriteLine(" 95-Evet, kabul ediyorum! \n 96-Hayır, kabul etmiyorum!");
                        secim = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("İşleminiz gerçekleştiriliyor...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        if (secim == 95)
                        {
                            Console.WriteLine("Talebiniz alınmıştır. İyi günler dileriz...");
                        }
                        if (secim == 96)
                        {
                            Console.WriteLine("Talebiniz alınmıştır. İyi günler dileriz...");
                        }
                    }
                }
            }
            while (secim != 9);
            Console.WriteLine("BANKAX Ailesi Olarak Sağlıklı Günler Dileriz...");

        }
    }
}