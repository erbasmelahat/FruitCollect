using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public Button playButton;
    //public Text text;
    //public Text[] textList = new Text[20];
    public Button settingsButton;
    public GameObject settingsPanel;
    public Button quitButton;
    void Start()
    {
        playButton.GetComponent<Button>();
        settingsButton.GetComponent<Button>();
        settingsPanel.GetComponent<GameObject>();
        quitButton.GetComponent<Button>();
    }

    public void PlayLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void Update()
    {
        //Color();
    }

    public void Setting()
    {
        settingsPanel.gameObject.SetActive(true);
    }

    public void Quit()
    {
        settingsPanel.gameObject.SetActive(false);
    }

  //  public void Color()
  //  {
  //      //char[] karakterler = text.ToString().ToCharArray();
  //      //foreach (char karakter in karakterler)
  //      //{
  //      //    textList[karakter].text = karakterler[karakter].ToString(); 
  //          text.color = new Color(
  //    Random.Range(0f, 1f),
  //    Random.Range(0f, 1f),
  //    Random.Range(0f, 1f)
  //);
  //      }

    //}
}
