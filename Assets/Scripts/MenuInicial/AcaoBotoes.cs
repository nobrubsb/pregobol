using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AcaoBotoes : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void chamaPartidaInicial()
    {
        SceneManager.LoadScene("TelaJogo");
    }
    public void chamaTelaEquipes()
    {
        SceneManager.LoadScene("TelaEquipes");
    }
    public void chamaTelaMenu()
    {
        SceneManager.LoadScene("MenuInicial");
    }
    public void chamaTelaConfiguracao()
    {
        SceneManager.LoadScene("TelaConfiguracao");
    }
    public void chamaTelaPinos()
    {
        SceneManager.LoadScene("TelaPinos");
    }
    public void chamaTelaFormacao()
    {
        SceneManager.LoadScene("TelaFormacao");
    }
    public void chamaTelaTorneio()
    {
        SceneManager.LoadScene("TelaTorneio");
    }


}
