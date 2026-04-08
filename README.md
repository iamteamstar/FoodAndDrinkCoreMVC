# Food & Drink Management System (ERP & Frontend)

Bu proje, bir işletmenin gıda ve içecek stoklarını yönetebileceği kapsamlı bir **ERP (Admin Paneli)** ve son kullanıcıların ürünleri inceleyebileceği dinamik bir **Frontend (Vitrin)** uygulamasından oluşmaktadır. Projede veri yönetimi için **Generic Repository Pattern** ve görselleştirme için **Google Charts** kullanılmıştır.

## 🚀 Özellikler

### Admin Paneli (Backend)
* **Kategori Yönetimi:** Kategorilerin eklenmesi, listelenmesi ve aktif/pasif (True/False) durum yönetimi.
* **Ürün (Food) Yönetimi:** Stok miktarı, fiyat ve kategori eşleştirmesi ile tam CRUD desteği.
* **İstatistik Paneli:** Dashboard üzerinde toplam ürün, kategori sayısı ve stok verilerinin anlık özeti.
* **Dinamik Grafikler:** **Google Charts** entegrasyonu ile stok verilerinin pasta ve sütun grafiklerine dökülmesi.
* **Pagination (Sayfalama):** Ürün listesinde verimli veri gösterimi.
* **Authentication:** Yetkili girişi için güvenli Login ekranı.

### Kullanıcı Arayüzü (Frontend)
* **Dinamik Kategori Menüsü:** Sol menüde yer alan kategoriler doğrudan veritabanından çekilmekte ve anlık filtreleme yapmaktadır.
* **Kategori Bazlı Listeleme:** Kullanıcı bir kategoriye (Meyveler, Sebzeler vb.) tıkladığında, yalnızca o kategoriye ait ürünler listelenir.
* **Ürün Kartları:** Her ürün için görsel, güncel fiyat, indirimli fiyat ve stok adedi bilgilerini içeren modern kart tasarımı.
* **Hızlı Erişim:** Üst barda yer alan arama ve sepet ikonları ile kullanıcı etkileşimi artırılmıştır.

## 🛠️ Kullanılan Teknolojiler
* **.NET 8.0 / ASP.NET Core MVC**
* **Entity Framework Core** (Code First)
* **MS SQL Server**
* **Generic Repository Pattern**
* **Google Charts API**
* **Bootstrap & CSS3** (UI/UX)

## 📸 Ekran Görüntüleri

### 1. Kullanıcı Arayüzü (Frontend)
Son kullanıcıların ürünleri incelediği ana sayfa ve dinamik kategori yapısı.
<img width="1901" height="864" alt="Ekran görüntüsü 2026-01-29 234725" src="https://github.com/user-attachments/assets/3432bd9b-adf8-4f73-81c9-6ac9cde36311" />
<img width="1030" height="787" alt="Ekran görüntüsü 2026-01-29 234818" src="https://github.com/user-attachments/assets/9c7fea4a-09b1-4adf-af78-167bc11fec34" />



### 2. Kategori Bazlı Listeleme
Seçilen kategoriye göre filtrelenmiş ürün görünümleri.
<img width="831" height="522" alt="Ekran görüntüsü 2026-01-29 234831" src="https://github.com/user-attachments/assets/e50e3862-6046-41e8-9ce2-e5b300de4c4a" />
<img width="1092" height="461" alt="Ekran görüntüsü 2026-01-29 234915" src="https://github.com/user-attachments/assets/e922b84e-3f2d-41a0-bb19-54231bbd80a4" />



### 3. Giriş Ekranı (Login)
Sisteme erişim sağlayan yetkili giriş sayfası.
<img width="636" height="744" alt="Ekran görüntüsü 2026-01-29 183945" src="https://github.com/user-attachments/assets/eeaaf43d-a9ac-414c-9158-07496d31f656" />


### 4. Dashboard ve İstatistikler
Sistemdeki genel verilerin (Toplam Gıda, Max/Min Stok vb.) özetlendiği alan.
<img width="1356" height="683" alt="Ekran görüntüsü 2026-01-29 184326" src="https://github.com/user-attachments/assets/6ffeac5f-dde9-4878-9fc6-17203fc2f7fc" />


### 5. Dinamik Grafikler
Google Charts kullanılarak hazırlanan stok dağılım grafikleri.
<img width="654" height="542" alt="Ekran görüntüsü 2026-01-29 184259" src="https://github.com/user-attachments/assets/0dbfa4e3-9285-42de-a307-fbda92628440" />
<img width="924" height="691" alt="Ekran görüntüsü 2026-01-29 184311" src="https://github.com/user-attachments/assets/636f7f43-bbe0-40c9-b2dd-9ba5fa5b2050" />


### 6. Gıda ve Kategori Yönetimi
Admin tarafında CRUD işlemlerinin yapıldığı tablolar ve ürün ekleme formu.
<img width="1383" height="777" alt="Ekran görüntüsü 2026-01-29 184015" src="https://github.com/user-attachments/assets/4c56d840-7ae7-441c-bb00-f63b5d6f75ed" />
<img width="1482" height="518" alt="Ekran görüntüsü 2026-01-29 184026" src="https://github.com/user-attachments/assets/287908fe-c384-49ff-b0f8-cefaf576f38a" />
<img width="1348" height="430" alt="Ekran görüntüsü 2026-01-29 184047" src="https://github.com/user-attachments/assets/c0c97cce-af41-4686-a1de-9e0142c271d9" />
<img width="1363" height="635" alt="Ekran görüntüsü 2026-01-29 184121" src="https://github.com/user-attachments/assets/5de5f6cc-5c7f-46fb-b561-f7bea61b498b" />

## 📂 Kurulum
1. Repoyu klonlayın:
   ```bash
   git clone [https://github.com/iamteamstar/FoodAndDrinkCoreMVC/.git](https://github.com/iamteamstar/FoodAndDrinkCoreMVC/.git)
