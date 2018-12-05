using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TrocaCena2 : MonoBehaviour
{

    private float contador = 3.0f;

    void Update()
    {
        contador -= Time.deltaTime;
        if (contador < 0.0f)
            SceneManager.LoadScene("MenuInicial");
    }
}
