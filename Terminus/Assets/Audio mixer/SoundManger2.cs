using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManger2 : MonoBehaviour
{
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool muted = true;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }

        else
        {
            Load();
        }
       
        AudioListener.pause = true;


    }
    private void Update()
    {
        UpdateButtonIcon();
        
    }

    public void OnButtonPress()
    {
        if (muted == true)
        {
            muted = false;
            AudioListener.pause = false;
        }
        else
        {
            muted = true;
            AudioListener.pause = true;
            
        }
        
        Save();
        
    }
    
    public void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    public void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }

    private void UpdateButtonIcon()
    {
        if (muted == false)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;
        }
        else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }
    }
    


}







 
