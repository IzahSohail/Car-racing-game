using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadCircuit1()
    {
        SceneManager.LoadScene("circuit1");
    }

    public void LoadCircuit2()
    {
        SceneManager.LoadScene("circuit2");
    }
}

