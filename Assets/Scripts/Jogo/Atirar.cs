using UnityEngine;
using System.Collections;

public class Atirar : MonoBehaviour
{


    ControleDirecao scriptControle;
    BarraForca scriptBarraForca;
    Pontuacao scriptPontuacao;
    Rigidbody2D rbBola;
    public GameObject bola;
    public GameObject seta;

    public float velocidadeFinal = 0.25f;
    float velocidadeFinalQuadrada;
    int contador = 0;


    Vector2 novaPosicao = new Vector2(0, 0);


    void Start()
    {
        scriptControle = (ControleDirecao)seta.GetComponent(typeof(ControleDirecao));
        scriptBarraForca = (BarraForca)bola.GetComponent(typeof(BarraForca));
        scriptPontuacao = (Pontuacao)bola.GetComponent(typeof(Pontuacao));
        rbBola = GetComponent<Rigidbody2D>() as Rigidbody2D;

        velocidadeFinalQuadrada = velocidadeFinal * velocidadeFinal;
    }

    public void Disparar()
    {

        Vector2 posicaoAtual = new Vector2(scriptControle.rbSeta.transform.position.x, scriptControle.rbSeta.transform.position.y).normalized;

        if (contador == 0)
        {

            rbBola.AddForce((posicaoAtual)
                        * (scriptBarraForca.valorVelocidadeLancamentoQuadrado() * Time.deltaTime * 200), ForceMode2D.Impulse);

            //rbBola.velocity = new Vector2(scriptControle.rbSeta.transform.position.x, scriptControle.rbSeta.transform.position.y) * scriptBarraForca.valorVelocidadeLancamentoQuadrado() * Time.deltaTime;


            Debug.Log("Posicao vetor bola = " + posicaoAtual);
            Debug.Log("Atirou");

        }
        if (contador > 1 && contador < 4)
        {
            //posicaoAtual = new Vector2(scriptControle.rbSeta.transform.position.x, scriptControle.rbSeta.transform.position.y);
            //rbBola.velocity = new Vector2(0, 0);
            rbBola.AddForce((posicaoAtual)
                        * (scriptBarraForca.valorVelocidadeLancamentoQuadrado() * Time.deltaTime * 200), ForceMode2D.Impulse);

            Debug.Log("Posicao vetor bola = " + posicaoAtual);
        }

        contador++;
        Debug.Log("Contador de disparos " + contador);
    }
}
