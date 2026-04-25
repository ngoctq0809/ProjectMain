using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> items = new List<InventoryItem>();

    public void AddItem(Sprite itemSprite)
    {
        // Kiểm tra xem vật phẩm này đã có trong túi đồ chưa
        foreach (InventoryItem item in items)
        {
            if (item.icon == itemSprite)
            {
                item.quantity++; // Nếu có rồi thì tăng số lượng
                return; // Thoát hàm, không thêm dòng mới
            }
        }

        // Nếu chưa có, tạo mới một InventoryItem với số lượng là 1
        items.Add(new InventoryItem(itemSprite, 0));
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
