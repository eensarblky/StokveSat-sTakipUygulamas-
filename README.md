# 📦 Stok ve Satış Takip Otomasyonu

Bu proje, küçük ve orta ölçekli işletmelerin stok durumlarını, müşteri ilişkilerini ve satış işlemlerini yönetmeleri için geliştirilmiş, **C#** ve **Windows Forms (WinForms)** tabanlı bir masaüstü uygulamasıdır. Veri tabanı olarak **MySQL** kullanılmıştır ve proje **Katmanlı Mimari (N-Tier Architecture)** prensiplerine uygun olarak tasarlanmıştır.

## 🚀 Özellikler

Uygulama aşağıdaki temel modülleri içerir:


* **🔐 Kullanıcı Yönetimi:**
* <img width="998" height="597" alt="Ana Menü" src="https://github.com/user-attachments/assets/f1f77faa-b4f1-4dde-b135-4cb8b756a7b6" />
    * Yönetici ve personel girişi.
    * Yeni kullanıcı (personel) ekleme modülü.
* **📦 Ürün Yönetimi:**
* <img width="1137" height="682" alt="Ürün sayfası" src="https://github.com/user-attachments/assets/896606ea-644e-4601-8948-af3cf90adbe8" />
    * Ürün ekleme, silme ve güncelleme.
    * Kritik stok seviyesi takibi.
    * Kategori bazlı ürün listeleme.
* **👥 Müşteri Yönetimi:**
* <img width="789" height="437" alt="Müşteri Bilgisi" src="https://github.com/user-attachments/assets/dc8f4aca-1e94-4e0c-b367-30b1598a755e" />
    * Müşteri kayıt, düzenleme ve silme işlemleri.
    * Müşteri iletişim bilgileri takibi.
* **🛒 Satış İşlemleri:**
    * Müşteriye ürün satışı yapma.
    * Satış anında stoktan otomatik düşüş.
* **📊 Raporlama:**
    * Satış raporları ve geçmiş işlem dökümleri.

## 🏗️ Mimari Yapı

Proje, kodun okunabilirliğini ve sürdürülebilirliğini artırmak amacıyla katmanlı mimari ile geliştirilmiştir:

* **Domain (Entity) Katmanı:** Veritabanı tablolarına karşılık gelen varlık sınıfları (`Urun.cs`, `Musteri.cs` vb.).
* **DAL (Data Access Layer):** Veritabanı CRUD işlemlerinin yapıldığı katman (`Repository` ve `DAO` sınıfları).
* **Service (Business) Katmanı:** İş mantığının ve doğrulamaların yürütüldüğü katman.
* **Presentation (UI) Katmanı:** Kullanıcı arayüzü formları (`Form1`, `AnaMenu` vb.).

## 🛠️ Teknolojiler

* **Dil:** C#
* **Framework:** .NET (Windows Forms App)
* **Veritabanı:** MySQL
* **IDE:** Visual Studio

## ⚙️ Kurulum ve Çalıştırma

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

### 1. Gereksinimler
* Visual Studio 2022 veya daha yenisi.
* MySQL Server ve MySQL Workbench.
* .NET Runtime.

### 2. Kurulum Adımları

1.  Bu repoyu klonlayın:
    ```bash
    git clone [https://github.com/kullaniciadiniz/StokTakipUygulamasi.git](https://github.com/kullaniciadiniz/StokTakipUygulamasi.git)
    ```
2.  **Veritabanı Kurulumu:**
    * MySQL'de `stok_takip_db` (veya kodda belirtilen isimde) bir veritabanı oluşturun.
    * Proje içerisindeki `Domain` sınıflarına uygun tabloları oluşturun (Kullanıcılar, Urunler, Musteriler, Satislar).
    * *Not: Veritabanı bağlantı ayarlarını (Connection String) `DAL` katmanındaki ilgili sınıfın içerisinden kendi yerel ayarlarınıza göre güncellemeyi unutmayın.*

3.  Projeyi Visual Studio ile açın (`.sln` veya `.slnx` dosyası).
4.  Çözümü Derleyin (Build Solution).
5.  `Start` tuşuna basarak uygulamayı çalıştırın.

## 📷 Ekran Görüntüleri

*(Buraya uygulamanızın çalışır haldeki ekran görüntülerini ekleyebilirsiniz. Örn: Giriş ekranı, Ana menü vb.)*

## 🤝 Katkıda Bulunma

1.  Bu projeyi Fork'layın.
2.  Yeni bir özellik dalı (branch) oluşturun (`git checkout -b ozellik/YeniOzellik`).
3.  Değişikliklerinizi commit edin (`git commit -m 'Yeni özellik eklendi'`).
4.  Dalınızı Push edin (`git push origin ozellik/YeniOzellik`).
5.  Bir Pull Request oluşturun.

## 📝 Lisans

Bu proje [MIT](LICENSE) lisansı ile lisanslanmıştır.
