# DPI Blocker

DPI (Deep Packet Inspection) sistemini kullanan erişim engelli sitelere güvenli ve yasal erişim sağlayan Windows uygulaması.

## 🚀 Özellikler

- **Otomatik Ayar Bulma**: İnternet servis sağlayıcınızın DPI ayarlarını otomatik olarak tespit eder ve en uygun bypass yöntemini seçer
- **Güvenli DNS**: Uygulamamızda sadece güvenilir dns sağlayıcıları kullanılır. Varsayılan goodbyedpi gibi programlarda kendinizde görebilirsinizki dns sunucuları farklı şeylerdir.
- **Hız Düşürmez**: Bu tür uygulamalar internet hızınızı zaten düşürmez. Fakat varsayılan olarak indirirseniz bir çoğunun içindeki dns sunucuları garip ip ler olacağı için alan adı çözümleme sırasında yani bir internet sitesine ilk girişte yavaşlıklar yaşarsınız.
- **Tüm Servis Sağlayıcılarda Test Edildi**: Türkiye'deki tüm büyük internet servis sağlayıcılarında test edilmiş ve çalıştığı doğrulanmıştır
- **Kolay Kullanım**: Tek tıkla çalışır, karmaşık ayarlar gerektirmez
- **Güvenli**: Tüm internet trafiğiniz şifrelenir ve güvende kalır
- **Hızlı**: İnternet hızınızı düşürmeden çalışır
- **Ücretsiz**: Tamamen ücretsiz, hiçbir ücret veya gizli maliyet yok

## 📋 Gereksinimler

- Windows 10 veya üzeri
- İnternet bağlantısı
- Yönetici yetkileri (ilk çalıştırmada)

## 🔧 Kurulum

1. [Releases](https://github.com/Reloxe/DPIBlocker/releases) sayfasından en son sürümü indirin
2. `DPI.BLOCKER.exe` dosyasını çalıştırın
3. İlk çalıştırmada yönetici yetkileri istenebilir, onaylayın

## 💻 Kullanım

1. Uygulamayı açın
2. "Başlat" butonuna tıklayın
3. Uygulama otomatik olarak internet servis sağlayıcınızın ayarlarını tespit eder ve en uygun bypass yöntemini seçer
4. Artık erişim engelli sitelere erişebilirsiniz
5. Kapatmak için uygulamayı kapatmanız yeterlidir

## ⚙️ Teknik Detaylar

Yazılım erişim engelli web servislerini test ederken WebView2 üzerinden tarayıcı başlatır. Bu paket Windows 10 Ve üzerinde varsayılan yüklü olarak gelmekte. Eğer bu paketi kaldırdıysanız tekrardan indirmeniz gerekir.

Bu uygulama, arka planda [GoodByeDPI](https://github.com/ValdikSS/GoodbyeDPI) projesini kullanarak DPI bypass işlemini gerçekleştirir. Program, servis sağlayıcınızın DPI ayarlarını otomatik olarak tespit eder ve GoodByeDPI için gerekli parametreleri otomatik olarak yapılandırır. Kullanıcının manuel ayar yapmasına gerek kalmaz.

### Nasıl Çalışır?

- Uygulama, sisteminizdeki DPI engellemelerini analiz eder.
- En uygun bypass yöntemini otomatik olarak seçer.
- GoodByeDPI yazılımını otomatik olarak önceden belirlenmiş ayarlar ile başlatıp test eder. Sizin tek tek test etmenize gerek yoktur.
- İnternet trafiğinizi optimize ederek ve şifreleyerek DPI sistemlerinin engellemelerini aşar.

## ⚠️ Yasal Uyarı

DPI Blocker tamamen yasal bir uygulamadır. Uygulama, yalnızca yasal web sitelerine erişim sağlamak için tasarlanmıştır. Yasadışı faaliyetlerde kullanılması kesinlikle yasaktır. Kullanıcılar, uygulamayı kendi sorumluluklarında kullanırlar.

## 📝 Lisans

Bu proje Açık kaynaklıdır katkı yapabilirsiniz.

## 🤝 Katkıda Bulunma

Hata bildirimi veya öneriler için [Issues](https://github.com/Reloxe/DPIBlocker/issues) sayfasını kullanabilirsiniz.

## 📧 İletişim

Sorularınız için: info@nokersoft.com

## 🙏 Teşekkürler

- [GoodByeDPI](https://github.com/ValdikSS/GoodbyeDPI) - Arka planda kullanılan DPI bypass kütüphanesi

---

**Not**: Bu uygulama eğitim ve yasal amaçlar için geliştirilmiştir. Lütfen sorumlu bir şekilde kullanın.
