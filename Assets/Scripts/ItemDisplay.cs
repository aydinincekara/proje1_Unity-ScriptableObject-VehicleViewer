using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    [Header("Data Source")]
    [Tooltip("ScriptableObject verilerini buradaki listeye sürükleyin")]
    public ItemData[] items;
    private int currentIndex = 0; // Ekranda o an hangi sýradaki aracýn olduðunu takip eder.

    [Header("UI Elements")]
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public Image iconImage;

    void Start()
    {
        // Güvenlik: Eðer liste boþ deðilse ilk aracý ekrana yazdýr
        if (items != null && items.Length > 0)
        {
            UpdateDisplay();
        }
        else
        {
            Debug.LogWarning("Item listesi boþ! Lütfen ItemManager üzerinden listeye araç verilerini ekleyin.");
        }
    }

    // Ekrandaki arayüzü, sýradaki (currentIndex) aracýn verileriyle günceller.
    void UpdateDisplay()
    {
        nameText.text = items[currentIndex].itemName;
        descriptionText.text = items[currentIndex].description;
        iconImage.sprite = items[currentIndex].itemIcon;
    }

    // "Sonraki" butonuna basýldýðýnda çalýþacak fonksiyon
    public void NextItem()
    {
        // GÜVENLÝK KONTROLÜ: Eðer liste boþsa fonksiyonu burada durdur ve hata vermesini engelle.
        if (items == null || items.Length == 0) return;

        currentIndex++;

        // Eðer dizinin sonuna geldiysek, tekrar en baþa (0. indekse) dön
        if (currentIndex >= items.Length)
        {
            currentIndex = 0;
        }
        UpdateDisplay();
    }

    // "Önceki" butonuna basýldýðýnda çalýþacak fonksiyon
    public void PreviousItem()
    {
        // GÜVENLÝK KONTROLÜ: Eðer liste boþsa fonksiyonu burada durdur ve hata vermesini engelle.
        if (items == null || items.Length == 0) return;

        currentIndex--;

        // Eðer dizinin en baþýndayken geriye basýlýrsa, dizinin en sonuna git
        if (currentIndex < 0)
        {
            currentIndex = items.Length - 1;
        }
        UpdateDisplay();
    }
}