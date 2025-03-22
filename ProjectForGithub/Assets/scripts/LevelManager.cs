using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Button button;
    public Button masterButton;
    public int sceneIndex;
    public string levelName;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = levelName;
        button.onClick.AddListener(OnButtonClick); 
        masterButton.onClick.AddListener(OnMasterButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnButtonClick()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    private void OnMasterButtonClick()
    {
        SceneManager.LoadScene(0);
    }
    
}
