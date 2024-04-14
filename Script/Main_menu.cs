using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Main_menu : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Image Credit;

   [SerializeField] TextMeshProUGUI Creditname;

    [SerializeField] private Button CreditButton;

    [SerializeField] private TextMeshProUGUI creditext;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public  void QuitGame()
    {
        Application.Quit();
    }
   public  void Startgame()
    {
        SceneManager.LoadScene("Game");
    }

    public void CreditsON()
    {
        Credit.enabled = true;
        Creditname.enabled=true;
        CreditButton.image.enabled=true;
        creditext.enabled=true;
        CreditButton.enabled=true;
    }
    public void CreditsOFF()
    {
        Credit.enabled = false;
        Creditname.enabled=false;
        CreditButton.image.enabled=false;
        creditext.enabled=false;
        CreditButton.enabled=false;
    }
}
