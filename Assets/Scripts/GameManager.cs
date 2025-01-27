using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject PlayerControl;
    public GameObject Cover;
    private GameObject player;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        } 
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnClickStartButton()
    {
        Cover.SetActive(false);
        if (EventSystem.current.IsPointerOverGameObject())
        {
            PlayerControl.GetComponent<PlayerControl>().LeftMouseClick();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
