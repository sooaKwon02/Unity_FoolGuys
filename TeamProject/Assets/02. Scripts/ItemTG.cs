using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTG : MonoBehaviour
{
   
    public Item item;
    Image image;

    [HideInInspector]
    public GameObject itemSwap;

    public GameObject player;
    
   
    private void Awake()
    {
        image = GetComponent<Image>();
    }
    private void Update()
    {
        if(item != null)
        {
            LookFashion(player.transform.position);           
        }       
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
            float objPos = Pos(obj.transform.position,pos);   
            if (objPos<60)
            {
                itemSwap.GetComponent<ItemData>().ItemGET(obj.GetComponentInChildren<ItemData>().item);
                obj.GetComponentInChildren<ItemData>().ItemGET(item);
                ItemInfo(null);
                gameObject.SetActive(false);
            }            
        }
    }
    void LookFashion(Vector2 player)
    {
        float camPosX = transform.position.x / 1920;
        float camPosY = transform.position.y / 1080;
       
        Vector2 camPos = new Vector2(camPosX-0.5f, camPosY-0.5f);
        
        float customPos = Pos(camPos, player);
        Debug.Log(customPos);
        if (customPos < 0.2f)
        {
            Debug.Log("123");
        }
    }
    float Pos(Vector2 obj,Vector2 pos)
    {      

        Vector2 vec = obj - pos;
        return vec.magnitude;        
    }

}
