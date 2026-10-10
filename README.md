OnionCQRSMediatrAPI

Onion Architecture, CQRS ve MediatR kullanılarak geliştirilmiş e-ticaret odaklı bir ASP.NET Core Web API projesi.
Katmanların birbirinden bağımsız olduğu, komut ve sorgu işlemlerinin ayrıldığı modern bir yapıyı göstermek amacıyla hazırlanmıştır.

Kullanılan Teknolojiler
.NET / ASP.NET Core Web API
Onion Architecture
CQRS (Command Query Responsibility Segregation)
MediatR
Entity Framework Core

Mimari

Çözüm, bağımlılıkların dıştan içe doğru aktığı Onion Architecture ile katmanlara ayrılmıştır.

Katman	Sorumluluk
Domain	Entity sınıfları ve çekirdek iş kuralları. Başka hiçbir katmana bağımlı değildir.
Application	Command/Query sınıfları, MediatR handler'ları, arayüzler (interface). İş mantığı burada yaşar.
Persistence	DbContext, Entity Framework Core yapılandırması ve veri erişimi implementasyonları.
WebUI	API controller'ları ve uygulamanın giriş noktası. İstekleri MediatR'a iletir.

Çözüm içinde projeler Solution Folder'larla gruplanmıştır:

OnionCQRSMediatrEticaret.sln
├── Core
│   ├── Domain
│   └── Application
├── Infrastructure
│   └── Persistence
├── Presentation
│   └── WebUI
└── Frontends        (ileride istemci uygulamaları için ayrılmış)

Bağımlılık yönü: WebUI → Application → Domain ve Persistence → Application → Domain. Domain katmanı hiçbir katmana referans vermez.

CQRS ve MediatR
Command: Veriyi değiştiren işlemler (ekleme, güncelleme, silme).
Query: Veriyi okuyan işlemler.
MediatR: Controller, istek nesnesini IMediator üzerinden gönderir; ilgili handler isteği işler. Böylece controller iş mantığından ayrılır.

TODO: Projeden bir örnek akış ekle. Örneğin: POST /api/products → CreateProductCommand → CreateProductCommandHandler → DbContext → yanıt.

Kurulum ve Çalıştırma

TODO: Aşağıdaki adımları kendi ortamına göre doğrula ve tamamla (veritabanı türü, connection string, migration komutları).

Repoyu klonla:
bash
   git clone https://github.com/gelenyusuf/OnionCQRSMediatrAPI.git
   cd OnionCQRSMediatrAPI
WebUI projesindeki appsettings.json dosyasında connection string'i kendi veritabanına göre düzenle.
Veritabanını oluştur:
bash
   dotnet ef database update --project Persistence --startup-project WebUI
Uygulamayı çalıştır:
bash
   dotnet run --project WebUI
API Uç Noktaları

TODO: Swagger ekran görüntüsü ekle veya uç noktaları tablo halinde listele.

Metot	Yol	Açıklama
GET	/api/...	TODO
POST	/api/...	TODO
