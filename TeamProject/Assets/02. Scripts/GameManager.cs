using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public GameObject store;
    public GameObject inventoryPanel;
    public GameObject inventory;   
    public GameObject createRoom;
    public GameObject rankPanel;
    public GameObject rankbuttonPanel;
    public GameObject playButtonPanel;
    public GameObject menuPanel;
    public GameObject idPanel;
    public GameObject settingMenuPanel;
    public GameObject CustomPanel;
    public GameObject profilePanel;
     
    
    

    private void Start()
    {
        store.SetActive(false);
        inventoryPanel.SetActive(false);
        createRoom.SetActive(false);
        rankPanel.SetActive(false);
        CustomPanel.SetActive(false);
        profilePanel.SetActive(false);
        settingMenuPanel.SetActive(false);
    }
    void ActiveMenu(bool active)
    {
        rankbuttonPanel.SetActive(active);
        playButtonPanel.SetActive(active);
        menuPanel.SetActive(active);
        idPanel.SetActive(active);
    }
    public void InventoryOnOff(bool check)
    {
        inventoryPanel.SetActive(check);
        if(!store.activeSelf)
        {
            ActiveMenu(!check);
        }
        
    }
   
   
    public void StoreOnOff(bool check)
    {
        store.SetActive(check);
        ActiveMenu(!check);
        if (check) {
            Camera.main.transform.position +=new Vector3(2,0,0) ;
        }
        else
        Camera.main.transform.position -= new Vector3(2, 0, 0);

    }
    public void SettingOnOff(bool check)
    {
        settingMenuPanel.SetActive(check);
        ActiveMenu(!check);
    }
   
    public void CreateRoomOnOff(bool check)
    {
        createRoom.SetActive(check);
        ActiveMenu(!check);
    }      
    public void RankPanelOnOff(bool check)
    {
        rankPanel.SetActive(check);
        ActiveMenu(!check);
    }
    public void CustomPanelOnOff(bool check)
    {
        CustomPanel.SetActive(check);
        ActiveMenu(!check);
    }
    public void ProfilePanelOnOff(bool check)
    {
        profilePanel.SetActive(check);
        ActiveMenu(!check);
    }  
    
    public void CreateRoom()
    {
        
    }
    public void CreateRandomRoom()
    {

    }

}
