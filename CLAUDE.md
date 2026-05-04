# FizyoterapiProjesi

Bu, bir fizyoterapist için yapılmış tanıtım sitesidir. Berke (yeni mezun yazılım mühendisi) tarafından öğrenme amacıyla geliştiriliyor.

## Proje Yapısı
- **FizyoterapiAPI**: ASP.NET Core 10 REST API, PostgreSQL + EF Core. Port 5114.
  - Modeller: Service, TherapistProfile, Appointment
  - 3 controller (Services, TherapistProfiles, Appointments) — tam CRUD
  - Servis katmanı: IServiceService/ServiceService gibi interface+impl çiftleri
- **FizyoterapiWeb**: Razor Pages frontend. Port 5077.
  - Sayfalar: Index, Hizmetler, Hakkimda, Randevu, Iletisim
  - API'ye HttpClient (ApiService) üzerinden bağlanıyor

## Tasarım Sistemi
**Stil**: "Sıcak ve samimi" — premium butik klinik havası. Lüks spa hissi.

**Renk paleti** (CSS variables, site.css içinde tanımlı):
- `--color-cream: #FAF7F2` (ana arka plan)
- `--color-cream-dark: #F0E9DC` (ikincil arka plan)
- `--color-green-darker: #2D5246` (en koyu yeşil, footer)
- `--color-green-dark: #3D6B5D` (ana yeşil, butonlar)
- `--color-green-medium: #5A8A7A`
- `--color-green-light: #A8C9B7` (blob'lar, dekoratif)
- `--color-green-soft: #E8F0EB` (rozet arka plan)
- `--color-text-dark: #2C3E2D`
- `--color-text-body: #4A5550`

**Tipografi**:
- Başlıklar: Playfair Display (serif, italic vurgular için em tag'i)
- Metin: Inter (sans-serif)

**Border radius**: 8px (sm), 12px (md), 16px (lg), 24px (xl), 9999px (full/pill)

**Tasarım kuralları**:
- Hero ve önemli bölümlerde organik blob şekiller (border-radius düzensiz, position absolute)
- Status badge'ler: yanıp sönen yeşil nokta + beyaz arka plan
- Hover efektleri: transform translateY(-8px) + soft shadow
- Italic yeşil vurgu: başlıklarda em tag'i ile (örn: "Hareketin <em>özgürlüğü</em>")
- Asla emoji kullanma, SVG ikonları tercih et (lucide-react stili)

## Geliştirme Notları
- Hot reload aktif — manuel restart gerekmez genellikle, ama büyük yapı değişikliklerinde Ctrl+C → dotnet run yapılır
- DateTime UTC sorunu için Program.cs'de `Npgsql.EnableLegacyTimestampBehavior` true ayarlı
- Navigation property validation için Appointment modelinde `[ValidateNever]` kullanıldı
- Telefon numarası: TR sabit (+90 prefix), regex `^[0-9\s]{10,13}$`

## Çalışma Tarzı (Berke'nin tercihi)
- Berke yeni mezun, öğrenerek ilerliyor
- Kopyala-yapıştır değil, anlayarak kod istiyor
- Açıklamalar Türkçe olsun
- Büyük değişikliklerden önce onay sor

Bu dosyayı oluşturmadan önce bana onay sor.