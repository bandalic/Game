using Game;
using System.Diagnostics;
using System.Threading.Channels;

// DiscountRate üzerinden kampanya fiyatı belirlenir. DiscountRate 0 yapıldığında oyunun normal değeri gözükür. Eğer kampanya oranı eklenirse hem kampanyalı hem de 
// kampanyasız fiyatı gözükür.

double price = 100;
double discountRate = 20;
double discount = price - (price * discountRate / 100);

if (discount < 100)
{
    Console.WriteLine("Kampanyasız Fiyatı:" + price + "$");
    Console.WriteLine("%" + discountRate + " Kampanyalı Fiyatı:" + discount + "$");
}
if (discount == 100) {
    Console.WriteLine("Oyun Fiyatı: " + price + "$");
        }

//Oyuncu bilgileri


Player player1 = new Player();
player1.PlayerUsername = "Strickrsss";
player1.PlayerName = "Arda";
player1.PlayerSurname = "Karaman";
player1.PlayerTc = "30045741238";
player1.PlayerId = 32143;
player1.PlayerBirthdate = 2000;

Player player2 = new Player();
player2.PlayerUsername = "Dodopizza";
player2.PlayerName = "Doğukan";
player2.PlayerSurname = "Çelik";
player2.PlayerTc = "85412547411";
player2.PlayerId = 55621;
player2.PlayerBirthdate = 2002;

Player player3 = new Player();
player3.PlayerUsername = "GymFruko";
player3.PlayerName = "Furkan";
player3.PlayerSurname = "Özer";
player3.PlayerTc = "21741547411";
player3.PlayerId = 51021;
player3.PlayerBirthdate = 1982;

//Manager çıktısı

Manager manager = new Manager();

manager.Register(player1);
manager.Edit(player2);
manager.Delete(player3);


//E-devlet doğrulama.

bool verifyEdevlet = false;
Player player = new Player();
if (verifyEdevlet == true)
{
    Console.WriteLine(player.PlayerUsername + " adlı kullanıcının kimlik bilgileri uyuştu.");
}
else
{
    Console.WriteLine("Kimlik bilgileriniz uyuşmamaktadır.");
}

//Kredi kartı bilgileri doğruysa satın alma işlemi gerçekti, yanlışsa gerçekleşmedi. Discount oranı 0 ise 100 dolar çekiyor. Discount oranı var ise orana göre işlem gerçekleşir.

bool verifyCreditInfo = true;
Buy buy = new Buy();
if (verifyCreditInfo == true)
{
    Console.WriteLine(player1.PlayerUsername + " adlı kullanıcı tarafından oyun başarıyla satın alındı.");
    Console.WriteLine("Çekilen tutar: " + discount + "$");
}
else
{
    Console.WriteLine(player.PlayerUsername +  " adlı kullanıcının kart bilgileri uyuşmamaktadır.");
}
