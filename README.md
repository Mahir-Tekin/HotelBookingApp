## Otel Rezervasyon Uygulaması

Clean architecture ve SOLID prensipleri dikkate alınarak geliştirilmiş bir otel rezervasyon uygulaması. 
mahirtekinhotel.com adresinde yayınlandı.

# Anasayfa
Anasayfa'da mevcut oteller listelenir. Kullanıcı belli bir tarih aralığı girdiğinde otellerin o tarihteki uygun olan en düşük fiyatlı odasının fiyatı getirilir.
![image](https://github.com/user-attachments/assets/cc31bd57-0895-4feb-a882-8e26c295531d)



# Otel Detay Sayfası

Otel detay sayfasında otele ait oda tipleri listelenir. Oda tipleri belli bir tarih aralığı ile filtrelendiklerinde odaların o tarihte müsait odaya sahip olması durumunda fiyat bilgisi döndürür.
Oda tipinin o tarihte uygun odası yok ise başka bir tarih seçiniz mesajı gösterilir.

![image](https://github.com/user-attachments/assets/e4738d2f-e671-42ca-8c38-0f782d25e1a4)

# Rezervasyon Detayları

Rezervasyon yap butonuna tıklandığında rezervasyonun detaylarını içeren bir modal kullanıcıya gösterilir. 

![image](https://github.com/user-attachments/assets/c9e3d497-b073-440b-a00f-205246bcba02)

Rezervasyon işleminin sonucu ise başka bir modal ile gösterilir. Projeye ödeme yöntemi eklenmemiştir.

![image](https://github.com/user-attachments/assets/20d916b4-7276-4ef8-b4dd-b05c984a2b4e)

Rezervasyon yapıldıktan sonra rezervasyonlarım sayfasında rezervasyonun mevcut durumu kontrol edilebilir.

![image](https://github.com/user-attachments/assets/1a5cb405-67d7-415c-99ba-78cdc800a9db)

# Rezervasyon Yönetimi
Otellere atanmış olan yöneticiler, yönettikleri otele gelen rezervasyon taleplerini yönetebilir.

![image](https://github.com/user-attachments/assets/97f16280-5856-4598-96d6-4c27f01e51d4)

# Otel Yönetimi

Otel ymneticileri otel detay sayfasında ek yetkilere sahiptir. Oteli düzenleyebilme, oda tipi ekleyebilme ve oda tiplerine oda numarası tanımlama gibi ek özellikle erişebilirler.

![image](https://github.com/user-attachments/assets/79f92316-4de9-493f-b1a8-996a37506021)

Otel yöneticileri ise admin tarafından atanır. Admin, otel detay sayfasında yönetici ekle özelliğini kullanabilir.

![image](https://github.com/user-attachments/assets/557b18d6-c652-4b89-b44f-aaa561cd8b73)

Adminleri yönet sayfası tüm adminlerin listelenip yetkilendirme işleminin yapıldığı sayfadır.

![image](https://github.com/user-attachments/assets/c7190041-60ac-4ea6-8316-19d25fc3f15c)

# Admin Sayfaları

Admin, otel ekleme, olanak ekleme, yönetici atama gibi birçok ek özelliğe sahiptir. 

![image](https://github.com/user-attachments/assets/588f5f85-6368-4732-9baf-24c0e7d2a67e)

# Otel Ekleme Sayfası

Admin, otel eklemek istediğinde otelin bilgilerini girebilir ve olanaklarını seçebilir.

![image](https://github.com/user-attachments/assets/fb508cef-2050-4c08-b339-606059dcae52)














