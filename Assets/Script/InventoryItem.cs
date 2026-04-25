using UnityEngine;
[System.Serializable]
public class InventoryItem : MonoBehaviour
{
    public Sprite icon;
    public int quantity;

    public InventoryItem(Sprite _icon, int _quantity)
    {
        icon = _icon;
        quantity = _quantity;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
