# Nazlı Gül Çira Fizyoterapi Web Sitesi

Bir fizyoterapist için geliştirilmiş tanıtım ve online randevu web sitesi.


## Özellikler

- Hizmet listesi ve detay sayfaları
- Terapist profili (biyografi, eğitim, uzmanlık alanları)
- Online randevu formu
- Mobil uyumlu (responsive) tasarım
- SEO optimizasyonu (Open Graph, sitemap.xml, robots.txt)
- Sıkça sorulan sorular bölümü
- Telefon input masking (TR formatı)

## Teknoloji

| Katman | Teknoloji |
|--------|-----------|
| Backend API | ASP.NET Core 10, C# |
| Frontend | Razor Pages, Bootstrap 5 |
| Veritabanı | PostgreSQL (Neon - Frankfurt), EF Core |
| Deploy | Render.com (Docker), Turhost (Domain) |
| Tipografi | Playfair Display + Inter |

## Mimari

İki katmanlı yapı: API + Web ayrı servisler. Web tarafı HttpClient ile API'ye bağlanır. Bu sayede ileride mobil app veya farklı frontend'ler eklemek kolaylaşır.

## Proje Yapısı

```
FizyoterapiProjesi/
├── FizyoterapiAPI/        REST API (port 5114)
│   ├── Controllers/       Services, TherapistProfiles, Appointments
│   ├── Models/            EF Core entity'leri
│   ├── Services/          Business logic katmanı
│   ├── Data/              ApplicationDbContext
│   ├── Migrations/        EF Core migrations
│   └── Dockerfile
└── FizyoterapiWeb/        Razor Pages frontend (port 5077)
    ├── Pages/             Index, Hizmetler, Hakkimda, Randevu, Iletisim
    ├── Services/          ApiService (HttpClient wrapper)
    ├── wwwroot/           CSS, JS, logo, favicon, sitemap, robots
    └── Dockerfile
```

## API Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | /api/Services | Tüm hizmetleri listele |
| GET | /api/Services/{id} | Hizmet detayı |
| POST | /api/Services | Yeni hizmet ekle |
| PUT | /api/Services/{id} | Hizmet güncelle |
| DELETE | /api/Services/{id} | Hizmet sil |
| GET | /api/TherapistProfiles | Terapist profili |
| PUT | /api/TherapistProfiles/{id} | Profil güncelle |
| POST | /api/Appointments | Randevu talebi oluştur |
| GET | /api/Appointments | Randevu listesi |

Swagger UI: /swagger

## Lokal Kurulum

Gereksinimler:
- .NET 10 SDK
- PostgreSQL

Adımlar:

```bash
git clone https://github.com/berk3bicer/FizyoterapiProjesi.git
cd FizyoterapiProjesi

cd FizyoterapiAPI
dotnet ef database update
dotnet run
```

Yeni terminal:

```bash
cd FizyoterapiWeb
dotnet run
```

- API: http://localhost:5114
- Swagger: http://localhost:5114/swagger
- Web: http://localhost:5077

## Deploy

Her iki proje Docker ile containerize edilmiştir. `Dockerfile` her alt projede mevcuttur.

Environment variables:
- `DATABASE_URL`: PostgreSQL connection string (API)
- `API_BASE_URL`: API servisinin adresi (Web)
- `ASPNETCORE_ENVIRONMENT`: `Production`

## Geliştirici

Berke Biçer — https://github.com/berk3bicer
