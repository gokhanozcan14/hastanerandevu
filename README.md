
Hastane Randevu Yönetim Sistemi

Genel Bakış

Bu proje, hastaneler için randevu yönetim sistemidir. Microsoft SQL Server kullanılarak geliştirilmiş olup, çeşitli kontrolcüler (Controllers), modeller (Models), görünümler (Views) ve bileşenler (Components) içermektedir.

Proje Üyeleri

Gökberk Furkan Çakır - G191210450

Gökhan Özcan - G201210052

Proje Detayları

Controllers: UserController, DoctorController, CategoryController

Models: 5 model sınıfı

Views: 5 Category view, 5 Doctor view, 2 User view, 3 Components view

Areas Dosyası: Controller ve Viewların düzenlenmesi için kullanıldı

Diğer Dosyası: Kullanıcı rollerini yönetmek için kullanıldı


Veritabanı Yönetimi

Veritabanı Yönetim Sistemi: Microsoft SQL Server

Bağlantı: Data dosyasındaki ApplicationDbContext öğeleri ve Models içindeki interfaceler ile Linq Repository sınıfları kullanılarak sağlandı
Migration: Add-migration ve update-database komutları ile tablolar oluşturuldu

Kurulum

Depoyu Klonlayın:

sh
Kodu kopyala
git clone https://github.com/gokhanozcan14/hastanerandevu.git
cd hastanerandevu

Veritabanını Kurun:

Microsoft SQL Server'ın yüklü ve çalışır durumda olduğundan emin olun.
Proje kök dizininde bulunan appsettings.json dosyasındaki veritabanı bağlantı ayarlarını güncelleyin.


NuGet Konsolu'nda aşağıdaki komutları çalıştırın:

sh
Kodu kopyala
Update-Database


Kullanım:

Kayıt Ekleme: Doktor ekleme işlemleri için DoctorController ve Create View kullanılır.

Yetkilendirme: Admin yetkilendirmeleri ve kullanıcı rolleri yönetimi için Authorize işlemleri kullanılır.

Görseller: Web sitesinin kullanıcı giriş ekranı, doktor ekleme sayfası ve admin paneli görselleri.

Özellikler:

Üye girişi yapılmadan ana sayfa erişimi

Admin paneli ile CRUD işlemleri

Kullanıcı yetkilendirme ve rollerin yönetimi

Poliklinik ekleme, silme ve düzenleme işlemleri
