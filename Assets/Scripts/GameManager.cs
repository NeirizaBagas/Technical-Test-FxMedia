using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CanvasGroup mainGameCanvasGroup;
    [SerializeField] private CanvasGroup pauseMenuCanvasGroup;
    [SerializeField] private CanvasGroup gameOverCanvasGroup;

    private void Awake()
    {
        Time.timeScale = 1.0f;
    }

    private void OnEnable()
    {
        TimeManager.OnTimeFinished += ShowGameOverMenu;
    }

    private void OnDisable()
    {
        TimeManager.OnTimeFinished -= ShowGameOverMenu;
    }

    private void Start()
    {
        ShowMainGameMenuCanvas();
        HidePauseMenuCanvas();
        HideGameOverMenu();
    }

    public void PauseGame()
    {
        HideMainGameMenuCanvas();
        ShowPauseMenuCanvas();
    }

    public void ResumeGame()
    {
        HidePauseMenuCanvas();
        ShowMainGameMenuCanvas();
    }

    public void RestartGame()
    {
        HideGameOverMenu();
        HidePauseMenuCanvas();
        ShowMainGameMenuCanvas();
        Time.timeScale = 1.0f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        HideGameOverMenu();
        HidePauseMenuCanvas();
        HideMainGameMenuCanvas();
        Application.Quit();
    }

    private void ShowMainGameMenuCanvas()
    {
        mainGameCanvasGroup.alpha = 1;
        mainGameCanvasGroup.interactable = true;
        mainGameCanvasGroup.blocksRaycasts = true;
    }

    private void HideMainGameMenuCanvas()
    {
        mainGameCanvasGroup.alpha = 0;
        mainGameCanvasGroup.interactable = false;
        mainGameCanvasGroup.blocksRaycasts = false;
    }

    private void ShowPauseMenuCanvas()
    {
        pauseMenuCanvasGroup.alpha = 1;
        pauseMenuCanvasGroup.interactable = true;
        pauseMenuCanvasGroup.blocksRaycasts = true;
        Time.timeScale = 0.0f;
    }

    private void HidePauseMenuCanvas()
    {
        pauseMenuCanvasGroup.alpha = 0;
        pauseMenuCanvasGroup.interactable = false;
        pauseMenuCanvasGroup.blocksRaycasts = false;
        Time.timeScale = 1.0f;
    }

    private void ShowGameOverMenu()
    {
        gameOverCanvasGroup.alpha = 1;
        gameOverCanvasGroup.interactable = true;
        gameOverCanvasGroup.blocksRaycasts = true;
        Time.timeScale = 0.0f;
    }

    private void HideGameOverMenu()
    {
        gameOverCanvasGroup.alpha = 0;
        gameOverCanvasGroup.interactable = false;
        gameOverCanvasGroup.blocksRaycasts = false;
        Time.timeScale = 1.0f;
    }

    
}
