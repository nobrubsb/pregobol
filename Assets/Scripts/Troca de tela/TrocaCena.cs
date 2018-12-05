using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TrocaCena : MonoBehaviour
{
    public float contador = 3.0f;
    
    void Update()
    {
        contador -= Time.deltaTime;
        if (contador < 0.0f)
            SceneManager.LoadScene("LogoJogo");
    }
}
