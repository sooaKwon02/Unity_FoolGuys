using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTG : MonoBehaviour
{
    public Item item;
    Image image;

    public GameObject itemSwap;
    private void Awake()
    {
        image = GetComponent<Image>();
    }
    private void Update()
    {
        transform.position = Input.mousePosition;       
        if (Input.GetMouseButtonDown(0) && gameObject.activeSelf)
        {
            Vector2 clickPos = transform.position;
            ItemGive(clickPos);
        }
    }

    public void ItemInfo(Item _item)
    {
        item = _item;
        ItemSet();
    }
    void ItemSet()
    {
        if (item != null)
        {            
            image.sprite = item.sprite;
            image.color = new Color(1, 1, 1, 1);
        }
        else
        {            
            image.sprite = null;
            image.color = new Color(1, 1, 1, 0);
        }
    }
    void ItemGive(Vector2 pos)
    {
        GameObject[] inventory = GameObject.FindGameObjectsWithTag(item.itemType.ToString());
        foreach(GameObject obj in inventory)
        {            
            if((obj.transform.position.x-pos.x)<60&& (pos.x-obj.transform.position.x  ) < 60 && (obj.transform.position.y - pos.y) < 60 && (pos.y-obj.transform.position.y)< 60)
            {
                itemSwap.GetComponent<ItemData>().ItemGET(obj.GetComponentInChildren<ItemData>().item);
                obj.GetComponentInChildren<ItemData>().ItemGET(item);
                ItemInfo(null);
                gameObject.SetActive(false);
            }
            
        }
    }

}
