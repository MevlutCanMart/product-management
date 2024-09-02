# Ürün Yönetim Sistemi

Bu proje, ürün yönetimini basit ve etkili bir şekilde gerçekleştirebileceğiniz bir Windows Forms uygulamasıdır. Uygulama, ürünlerinizi yönetmenize, vergi gruplarını ve ölçü birimlerini düzenlemenize yardımcı olur. Ayrıca, ürünlere barkod ekleyebilir ve bu verileri veritabanında saklayabilirsiniz.

## İçindekiler

- [Başlangıç](#başlangıç)
- [Özellikler](#özellikler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Teknik Detaylar](#teknik-detaylar)
- [Geliştirici](#gelistirici)

## Başlangıç

Bu bölüm, uygulamanın nasıl başlatılacağını ve kullanıcının projeyi nasıl çalıştırabileceğini açıklar.

### Gereksinimler

- .NET Framework 4.8 veya üzeri
- SQL Server 2019 veya üzeri
- Visual Studio 2019 veya üzeri

### Kurulum

1. **Projenin Kopyalanması**
   - Bu projeyi GitHub'dan klonlayarak yerel makinenize kopyalayın:
     ```bash
     git clone <repo-url>
     ```

2. **Bağlantı Dizesi Ayarlamaları**
   - `app.config` dosyasındaki SQL Server bağlantı dizesini kendi veritabanı bilgilerinizle güncelleyin:
     ```xml
     <connectionStrings>
       <add name="ProductConnectionString" connectionString="Server=localhost\SQLEXPRESS;Initial Catalog=Product;Integrated Security=True" providerName="System.Data.SqlClient"/>
     </connectionStrings>
     ```

3. **Veritabanı Yapılandırması**
   - Veritabanı yapınızı oluşturmak için gerekli SQL komutlarını çalıştırın. `DatabaseSchema.sql` dosyası veritabanı şeması için örnek SQL komutlarını içerir.

### Kullanım

1. **Uygulamanın Başlatılması**
   - Visual Studio'da çözümü açın ve `Solution Explorer` penceresinden proje dosyasını sağ tıklayıp "Başlat" seçeneğini seçin.

2. **Uygulama Özellikleri**
   - **Ürün Yönetimi:** Ürünleri ekleyin, düzenleyin ve silin.
   - **Barkod Yönetimi:** Ürünlere barkod ekleyin ve mevcut barkodları düzenleyin.
   - **Vergi Grubu Yönetimi:** Farklı vergi grupları tanımlayın ve vergi oranlarını ayarlayın.
   - **Ölçü Birimi Yönetimi:** Ölçü birimlerini ekleyin, düzenleyin ve silin.

## Teknik Detaylar

- **Veritabanı Tabloları:**
  - `Item`: Ürün bilgilerini içerir.
  - `prItemBarcode`: Ürün barkodlarını yönetir.
  - `TaxGroup`: Vergi gruplarını tanımlar.
  - `UnitOfMeasure`: Ölçü birimlerini içerir.

- **Bağlantı Dizesi:**
  - Bağlantı dizesi `localhost\SQLEXPRESS` olarak yapılandırılmıştır ve veritabanı `Product` ismi ile kullanılmıştır.

## Katkıda Bulunanlar

- **Geliştirici:** Mevlüt Can Mart, Linkedin Hesabım: www.linkedin.com/in/mevlüt-can-mart
