using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{

    public Rigidbody2D rbBola;
    SpriteRenderer renderBola;
    public Text textoPontos;
    public Text Gol;
    public Transform posBola;

    public int pontos;

    public bool bolaDestruida = false;

    // Use this for initialization
    void Start()
    {
        rbBola = GetComponent<Rigidbody2D>() as Rigidbody2D;
        renderBola = GetComponent<SpriteRenderer>() as SpriteRenderer;


        Gol.text = "";
        textoPontos.text = textoPontos.text + pontos.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.tag == "TraveEsquerda")
        {
            pontuacao();
            Gol.text = "GOOOOOOL";
            posBola.transform.position = new Vector3(0, 0, 1);
            rbBola.velocity = new Vector2(0, 0);
            
        }
    }

    private void OnDestroy()
    {
        
    }

    void pontuacao()
    {
        pontos++;
        textoPontos.text = "Placar       " + pontos.ToString();
    }

}
