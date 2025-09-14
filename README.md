# 📧 MyAcademy Identity Email Project

ASP.NET Core Identity tabanlı modern email/mesajlaşma uygulaması. Kullanıcıların güvenli bir şekilde mesaj gönderip alabileceği, taslak kaydedebileceği ve mesajlarını yönetebileceği tam özellikli bir platform.

## ✨ Özellikler

### 🔐 Kimlik Doğrulama
- **Kullanıcı Kaydı** - Email ve şifre ile hesap oluşturma
- **Güvenli Giriş** - ASP.NET Core Identity ile kimlik doğrulama
- **Oturum Yönetimi** - Güvenli çıkış ve oturum kontrolü

### 📨 Mesaj Yönetimi
- **Gelen Kutusu** - Son 3 mesajı öncelikli gösterim
- **Gönderilen Mesajlar** - Gönderilen tüm mesajları listeleme
- **Taslak Sistemi** - Mesajları taslak olarak kaydetme ve düzenleme
- **Çöp Kutusu** - Silinen mesajları geri getirme
- **Önemli Mesajlar** - Yıldızla işaretleme sistemi

### 🎯 Mesaj İşlemleri
- **Okundu/Okunmadı** - Mesaj durumunu değiştirme
- **Silme** - Soft delete ile güvenli silme
- **Geri Getirme** - Çöp kutusundan mesajları geri alma
- **Taslak Düzenleme** - Kaydedilen taslakları düzenleme

### 📱 Kullanıcı Arayüzü
- **Modern Tasarım** - AdminLTE 3.0.4 ile profesyonel görünüm
- **Responsive** - Mobil ve masaüstü uyumlu
- **Dinamik Header** - Son 3 mesajı dropdown'da gösterme
- **Sayfalama** - 5'er mesaj ile performanslı listeleme
- **Gerçek Zamanlı Sayılar** - Okunmamış, çöp kutusu, önemli mesaj sayıları

## 🛠️ Teknolojiler

### Backend
- **ASP.NET Core 9.0** - Modern web framework
- **Entity Framework Core** - ORM ve veritabanı yönetimi
- **ASP.NET Core Identity** - Kimlik doğrulama ve yetkilendirme
- **SQL Server** - Veritabanı

### Frontend
- **AdminLTE 3.0.4** - Modern admin panel teması
- **Bootstrap 4** - Responsive CSS framework
- **FontAwesome** - İkon kütüphanesi
- **jQuery** - JavaScript kütüphanesi

### Veritabanı
- **Code First Migration** - Veritabanı şeması yönetimi
- **Soft Delete** - Güvenli veri silme
- **Foreign Key Relations** - İlişkisel veri yapısı

## 📁 Proje Yapısı

```
IdentityEmailApp/
├── Controllers/
│   ├── HomeController.cs          # Ana sayfa kontrolcüsü
│   ├── LoginController.cs         # Giriş/çıkış kontrolcüsü
│   ├── RegisterController.cs      # Kayıt kontrolcüsü
│   ├── MessageController.cs       # Mesaj işlemleri kontrolcüsü
│   └── MainLayoutController.cs    # Layout veri kontrolcüsü
├── Entities/
│   ├── AppUser.cs                 # Kullanıcı entity'si
│   ├── AppRole.cs                 # Rol entity'si
│   └── Message.cs                 # Mesaj entity'si
├── Models/
│   ├── LoginViewModel.cs          # Giriş modeli
│   ├── RegisterViewModel.cs       # Kayıt modeli
│   └── SendMessageViewModel.cs    # Mesaj gönderme modeli
├── Views/
│   ├── MainLayout/
│   │   └── Index.cshtml           # Ana layout
│   ├── Message/
│   │   ├── Index.cshtml           # Gelen kutusu
│   │   ├── SendMessage.cshtml     # Mesaj gönderme
│   │   ├── SentMessages.cshtml    # Gönderilen mesajlar
│   │   ├── Drafts.cshtml          # Taslaklar
│   │   ├── Trash.cshtml           # Çöp kutusu
│   │   └── MessageDetail.cshtml   # Mesaj detayı
│   ├── Login/
│   │   └── Index.cshtml           # Giriş sayfası
│   └── Register/
│       └── SignUp.cshtml          # Kayıt sayfası
├── Context/
│   └── AppDbContext.cs            # Veritabanı context'i
├── Validations/
│   └── CustomErrorDescriber.cs    # Özel hata mesajları
└── Migrations/                     # Veritabanı migration'ları
```

## 🚀 Kurulum

### Gereksinimler
- .NET 9.0 SDK
- SQL Server (LocalDB desteklenir)
- Visual Studio 2022 veya VS Code

### Adımlar

1. **Projeyi klonlayın**
```bash
git clone https://github.com/yourusername/MyAcademyIdentityProject.git
cd MyAcademyIdentityProject
```

2. **Paketleri yükleyin**
```bash
dotnet restore
```

3. **Veritabanını oluşturun**
```bash
dotnet ef database update
```

4. **Uygulamayı çalıştırın**
```bash
dotnet run
```

5. **Tarayıcıda açın**
```
https://localhost:7058
```

## 📊 Veritabanı Şeması

### AppUser (Kullanıcılar)
- `Id` - Benzersiz kullanıcı ID'si
- `FirstName` - Ad
- `LastName` - Soyad
- `Email` - Email adresi
- `UserName` - Kullanıcı adı

### Message (Mesajlar)
- `MessageId` - Benzersiz mesaj ID'si
- `SenderId` - Gönderen kullanıcı ID'si
- `ReceiverId` - Alıcı kullanıcı ID'si (nullable - taslaklar için)
- `Subject` - Mesaj konusu
- `Body` - Mesaj içeriği
- `SendDate` - Gönderim tarihi
- `IsRead` - Okundu durumu
- `IsDeleted` - Silindi durumu (soft delete)
- `IsImportant` - Önemli mesaj durumu
- `IsDraft` - Taslak durumu
- `DraftDate` - Taslak kayıt tarihi

## 🔧 Özellik Detayları

### Mesaj Sistemi
- **Gelen Kutusu**: Son 3 mesajı öncelikli gösterir
- **Pagination**: 5'er mesaj ile performanslı listeleme
- **Soft Delete**: Mesajlar fiziksel olarak silinmez
- **Draft System**: Mesajları taslak olarak kaydetme

### Güvenlik
- **Identity Framework**: Güvenli kimlik doğrulama
- **Authorization**: Sayfa bazlı yetkilendirme
- **Input Validation**: Giriş doğrulama
- **SQL Injection Protection**: Entity Framework ile korunma

### Performans
- **Optimized AdminLTE**: Gereksiz dosyalar kaldırıldı
- **Async Operations**: Asenkron veritabanı işlemleri
- **Efficient Queries**: Optimize edilmiş sorgular

## 🎨 Ekran Görüntüleri

### Ana Sayfa
- Modern sidebar navigasyon
- Dinamik mesaj sayıları
- Son 3 mesaj dropdown'ı

### Mesaj Yönetimi
- Temiz liste görünümü
- Hızlı işlem butonları
- Responsive tasarım

## 🤝 Katkıda Bulunma

1. Fork yapın
2. Feature branch oluşturun (`git checkout -b feature/AmazingFeature`)
3. Commit yapın (`git commit -m 'Add some AmazingFeature'`)
4. Push yapın (`git push origin feature/AmazingFeature`)
5. Pull Request oluşturun

## 📝 Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için `LICENSE` dosyasına bakın.

## 👨‍💻 Geliştirici

**Okan Baskaya**
- GitHub: [@yourusername](https://github.com/yourusername)
- LinkedIn: [Okan Baskaya](https://linkedin.com/in/okanbaskaya)

## 📞 İletişim

Proje hakkında sorularınız için:
- Email: okan@example.com
- GitHub Issues: [Issues](https://github.com/yourusername/MyAcademyIdentityProject/issues)

---

⭐ **Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!**