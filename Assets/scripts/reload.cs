using UnityEngine.SceneManagement;
using UnityEngine;

public class reload : MonoBehaviour
{
    public void refresh()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnOpenButtonClick()
    {
        refresh();
    }
}
