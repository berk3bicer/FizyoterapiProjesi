# Fizyoterapi Tanıtım Sitesi

Fizyoterapist için tanıtım ve online randevu web sitesi. Hizmetler, terapist profili ve randevu alma özellikleri içerir.

## Özellikler

- Hizmet listesi ve detayları
- Terapist profili (eğitim, sertifikalar, makaleler)
- Online randevu formu
- Responsive (mobil uyumlu) tasarım

## Teknolojiler

- ASP.NET Core 10
- C# 14
- Entity Framework Core
- PostgreSQL
- Razor Pages

## Proje Yapısı

- `FizyoterapiAPI/` — Backend (Web API)
- `FizyoterapiWeb/` — Frontend (Razor Pages)

## Kurulum

1. .NET 10 SDK ve PostgreSQL'i yükleyin
2. `appsettings.json` içindeki connection string'i kendi ortamınıza göre güncelleyin
3. Migration'ları uygulayın:
```bash
   cd FizyoterapiAPI
   dotnet ef database update
```
4. Projeyi çalıştırın:
```bash
   dotnet run
```

## Geliştirici

Berke

Bu proje öğrenme ve portföy amacıyla geliştirilmektedir.