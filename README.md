# Unity - Scriptable Object Tabanlı Dinamik Araç Galerisi (Vehicle Viewer)

Bu proje, Unity oyun motorunda verilerin koda gömülmeden (hard-coded) esnek, modüler ve bellek dostu bir şekilde nasıl yönetileceğini gösteren profesyonel bir **mimari prototiptir**. Projede tasarım deseni olarak veri odaklı yaklaşım (Data-driven design) benimsenmiştir.

## 🛠️ Kullanılan Teknolojiler & Sürümler
* **Oyun Motoru:** Unity 2022.3 LTS
* **Programlama Dili:** C#
* **Arayüz Sistemi:** TextMeshPro (TMP) & Unity UI Canvas

## 📐 Mimari Yaklaşım & Teknik Kazanımlar
* **ScriptableObject Veri Yönetimi:** Araçlara ait temel veriler (Araç İsmi, Detaylı Açıklama, Görsel Sprite) koda bağımlı olmadan bağımsız birer varlık (asset) olarak üretilmiştir. Bu sayede `Taksi`, `Polis Arabası`, `Sedan` gibi farklı araç tipleri tek bir satır kod yazılmadan tamamen editör üzerinden çoğaltılabilmektedir.
* **Dinamik UI Modülü ve Döngüsel Array Yönetimi:** Tek bir merkezi arayüz bileşeni (`ItemDisplay`), bir C# dizisi (Array) içerisindeki ScriptableObject verilerini sırayla okur. "Sonraki" ve "Önceki" butonları aracılığıyla listenin başına veya sonuna dönecek şekilde döngüsel bir akış sağlanmıştır.
* **Hata Önleyici Kodlama (Defensive Programming):** Dizinin boş kalması veya yanlış yapılandırılması durumunda oluşabilecek `IndexOutOfRangeException` ve `NullReferenceException` hataları, algoritmik güvenlik kontrolleriyle (`null ve uzunluk check`) tamamen engellenerek sistem kararlı hale getirilmiştir.

## 🚀 Nasıl Çalışır?
1. Editör üzerinden oluşturulan `ItemData` ScriptableObject dosyaları, `ItemManager` bileşenindeki listeye atanır.
2. Oyun başladığında sistem otomatik olarak ilk elemanı arayüze basar.
3. UI üzerindeki yön butonları, C# event yapılarıyla tetiklenerek arayüzdeki metin ve görselleri gerçek zamanlı olarak günceller.
