# Food & Drink Management System (ERP)

Bu proje, bir işletmenin gıda ve içecek stoklarını, kategorilerini ve istatistiklerini yönetmek amacıyla **ASP.NET Core MVC** kullanılarak geliştirilmiş bir yönetim (Admin) panelidir. Projede veri yönetimi için **Generic Repository Pattern** ve görselleştirme için **Google Charts** kullanılmıştır.

##  Özellikler
* **Kategori Yönetimi:** Kategorilerin eklenmesi, listelenmesi ve durumlarının (True/False) yönetilmesi.
* **Ürün (Food) Yönetimi:** Stok miktarı, fiyat ve kategori eşleştirmesi ile tam CRUD desteği.
* **İstatistik Paneli:** Dashboard üzerinde toplam ürün, kategori sayısı ve max/min stok verileri.
* **Google Charts Entegrasyonu:** Stok verilerinin dinamik olarak Pasta (Pie) ve Sütun (Column) grafiklerine dökülmesi.
* **Pagination (Sayfalama):** Ürün listesinde verimli veri gösterimi.
* **Authentication:** Yetkili girişi için güvenli Login ekranı.

##  Kullanılan Teknolojiler
* **.NET 8.0 / ASP.NET Core MVC**
* **Entity Framework Core** (Code First)
* **MS SQL Server**
* **Generic Repository Pattern**
* **Google Charts API**
* **Bootstrap** (UI/UX)

##  Ekran Görüntüleri

### 1. Giriş Ekranı (Login)
Sisteme erişim sağlayan yetkili giriş sayfası.
> ![Login Sayfası]<img width="636" height="744" alt="Ekran görüntüsü 2026-01-29 183945" src="https://github.com/user-attachments/assets/2e488e8f-3bd0-4a92-8b3c-ab0ddd73f7df" />


### 2. Dashboard ve İstatistikler
Sistemdeki genel verilerin (Toplam Gıda, Max/Min Stok, Ortalamalar) özetlendiği alan.
> ![Dashboard]<img width="1356" height="683" alt="Ekran görüntüsü 2026-01-29 184326" src="https://github.com/user-attachments/assets/7484c3de-21ed-4da4-b8a1-babaa3602c22" />


### 3. Dinamik Grafikler
Google Charts kullanılarak hazırlanan stok dağılım grafikleri.
> ![Google Charts Pie]<img width="654" height="542" alt="Ekran görüntüsü 2026-01-29 184259" src="https://github.com/user-attachments/assets/ce902f59-1f85-410d-9f0c-1b58bc93ba69" />

> ![Google Charts Column]<img width="924" height="691" alt="Ekran görüntüsü 2026-01-29 184311" src="https://github.com/user-attachments/assets/afe90d0e-2923-401c-a548-d1688141f6ad" />


### 4. Gıda ve Kategori Yönetimi
Ürünlerin listelendiği, sayfalamanın ve CRUD işlemlerinin yapıldığı tablolar.
> ![Gıda Listesi]<img width="1482" height="518" alt="Ekran görüntüsü 2026-01-29 184026" src="https://github.com/user-attachments/assets/f8644262-9491-4e4b-879f-c1b2388d9d5c" />
<img width="1348" height="430" alt="Ekran görüntüsü 2026-01-29 184047" src="https://github.com/user-attachments/assets/1d64eb9d-2435-4c56-8610-1439aff5d4ab" />


> ![Kategori Listesi]<img width="1383" height="777" alt="Ekran görüntüsü 2026-01-29 184015" src="https://github.com/user-attachments/assets/a0a66320-aab8-4b50-aa1a-12ab809f3e11" />


### 5. Yeni Ürün Ekleme
Kategori seçimi ile birlikte yeni ürün giriş formu.
> ![Ürün Ekleme]<img width="1363" height="635" alt="Ekran görüntüsü 2026-01-29 184121" src="https://github.com/user-attachments/assets/d945338f-d19e-4f77-91da-7a95c496b512" />


## 📂 Kurulum
1. Repoyu klonlayın: `git clone https://github.com/iamteamstar/FoodAndDrinkCoreMVC/.git`
2. `appsettings.json` dosyasındaki Connection String'i kendi SQL Server veritabanınıza göre düzenleyin.
3. Package Manager Console üzerinden `Update-Database` komutunu çalıştırın.
4. Projeyi çalıştırın.

---
*Not: Bu proje şu an için Admin Paneli odaklıdır, kullanıcı tarafı (Frontend) geliştirme aşamasındadır.*
