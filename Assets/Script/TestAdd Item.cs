using UnityEngine;

public class TestAddItem : MonoBehaviour
{
    public Inventory inventory; 
    public InventoryUI inventoryUI;
    public Sprite itemToAdd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (inventory != null && itemToAdd != null)
            {
                inventory.AddItem(itemToAdd);
                inventoryUI.UpdateUI();
                Debug.Log("Đã thêm vật phẩm và cập nhật UI!");
            }
        }
    }
}
