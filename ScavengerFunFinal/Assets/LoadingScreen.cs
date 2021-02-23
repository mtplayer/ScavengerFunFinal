using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    private IEnumerator start()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(2);  
    }
}
