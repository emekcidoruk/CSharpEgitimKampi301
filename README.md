# CSharpEgitimKampi301

![CSharpEgitimKampi301](https://github.com/user-attachments/assets/2fc339bc-b69e-451e-86d0-2e4a8c0dfb61)

Bu Windows Forms uygulaması, bir turizm acentesinin verilerini görselleştirmek için tasarlanmıştır. Uygulamanın temel amacı, veritabanında depolanan tur, rehber ve lokasyon bilgilerini özetleyerek kullanıcıya sunmaktır. Form, C# programlama dili ve Microsoft SQL Server veritabanı kullanılarak geliştirilmiştir. Veritabanı bağlantısı için ADO.NET veya Entity Framework gibi teknolojiler kullanılmıştır.

Formun kullanıcı arayüzü, çeşitli istatistikleri ve bilgileri gösteren bir dizi etiketten oluşmaktadır. Bu etiketler, farklı renklerdeki paneller içinde düzenlenerek görsel bir hiyerarşi oluşturulmuştur. Etiketlerde gösterilen bilgiler, veritabanından çekilen verilerin işlenmesiyle elde edilmiştir. Örneğin, "Lokasyon Sayısı" etiketi, veritabanındaki lokasyon tablosundaki kayıtların sayısını gösterirken, "Ortalama Tur Fiyatı" etiketi, tur tablosundaki fiyatların ortalamasını göstermektedir.

Uygulama, veritabanından veri çekmek için SQL sorguları kullanır. Bu sorgular, C# kodunda çalıştırılarak sonuçlar elde edilir ve etiketlerde gösterilir. Örneğin, "En Pahalı Tur" etiketinde gösterilen tur, veritabanındaki tur tablosundan en yüksek fiyata sahip olan turu bulmak için bir SQL sorgusu kullanılarak elde edilmiştir.

Formun kodunda, veritabanı bağlantısı, veri çekme ve işleme gibi işlemler için çeşitli C# sınıfları ve metotları kullanılmıştır. Ayrıca, formun kullanıcı arayüzünü oluşturmak ve olayları yönetmek için Windows Forms kontrolleri ve olay işleyicileri kullanılmıştır.
