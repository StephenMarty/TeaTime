using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public Button StartGame;
    public Button Exit;

    public Manager GManager;
    public Workspace WSpace;

    private bool CSActive = false;

    void Start()
    {
        GManager = GameObject.Find("GameManager").GetComponent<Manager>();
        WSpace = GameObject.Find("Workspace").GetComponent<Workspace>();

        StartGame.onClick.AddListener(NewGameTask);
        Exit.onClick.AddListener(ExitTask);
    }

    public void NewGameTask()
    {
        GManager.ControlsEnabled = true;
        WSpace.Toggle();
        transform.gameObject.SetActive(false);
    }

    public void ExitTask()
    {
        Application.Quit();
    }
}