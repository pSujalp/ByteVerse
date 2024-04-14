using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class pausemenu : MonoBehaviour
{
    // Start is called before the first frame update

    private bool isPaused = false;

    [SerializeField] private Image PauseMenu;

    [SerializeField] private Button resumebutton;
    [SerializeField] private Image resumeimage;

    [SerializeField] private TextMeshProUGUI resumeTextmeshpro;

    [SerializeField] private Button pausebutton;
    [SerializeField] private Image pauseimage;

    [SerializeField] private TextMeshProUGUI pauseTextmeshpro;


    void Start()
    {
        isPaused = false;
        PauseMenu.enabled=false; 
        resumeTextmeshpro.enabled=false;
        resumeimage.enabled=false;
        resumebutton.enabled=false;   


         pauseTextmeshpro.enabled=false;
        pauseimage.enabled=false;
        pausebutton.enabled=false;
        Cursor.lockState = CursorLockMode.Locked;
         Cursor.visible = false;

    }

    void Update()
    {
        // Check for pause input, like pressing the "P" key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
                 
                 Cursor.lockState = CursorLockMode.Locked;
         Cursor.visible = false;
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                PauseGame();

       
            }
        }
    }

    public void PauseGame()
    {
        // Pause the game by setting the time scale to 0
        Time.timeScale = 0;
        isPaused = true;
        PauseMenu.enabled=true;
        resumeTextmeshpro.enabled=true;
        resumeimage.enabled=true;
        resumebutton.enabled=true;

        pauseTextmeshpro.enabled=true;
        pauseimage.enabled=true;
        pausebutton.enabled=true;
        // You might want to do additional things when pausing, like showing a pause menu
    }

    public void ResumeGame()
    {
        // Resume the game by setting the time scale back to 1
       
        Time.timeScale = 1;
        isPaused = false;
        PauseMenu.enabled=false; 
        resumeTextmeshpro.enabled=false;
        resumeimage.enabled=false;
        resumebutton.enabled=false;   


         pauseTextmeshpro.enabled=false;
        pauseimage.enabled=false;
        pausebutton.enabled=false;
        // You might want to do additional things when resuming, like hiding the pause menu
    }

    public void Main_menu()
    {
        SceneManager.LoadScene("Main_menu");
    }
    
}
