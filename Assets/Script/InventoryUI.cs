using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public Transform itemsParent;
    public GameObject slotPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateUI()
    {
        foreach (Transform child in itemsParent)
        {
            Destroy(child.gameObject);
        }

        foreach (InventoryItem item in inventory.items)
        {
            GameObject slot = Instantiate(slotPrefab, itemsParent);

            // Gán hình ảnh
            slot.GetComponent<Image>().sprite = item.icon;

            // Gán số lượng (Tìm Script Text ở các object con của Slot)
            // Lưu ý: Nếu dùng Text thường thì dùng <Text>, dùng TMP thì dùng <TextMeshProUGUI>
            TextMeshProUGUI txt = slot.GetComponentInChildren<TextMeshProUGUI>();
            if (txt != null)
            {
                txt.text = item.quantity.ToString();
            }
        }
    }
}
