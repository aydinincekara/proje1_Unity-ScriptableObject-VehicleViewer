using UnityEngine;

// Bu satýr, Unity menüsünden kolayca yeni eþyalar oluþturmamýzý saðlar.
[CreateAssetMenu(fileName = "New Item", menuName = "Portfolio/Inventory Item")]
public class ItemData : ScriptableObject
{
    [Header("Item Details")]
    public string itemName;
    [TextArea(3, 5)]
    public string description;
    public Sprite itemIcon;

    [Header("Item Stats")]
    public int value;
    public float weight;
}