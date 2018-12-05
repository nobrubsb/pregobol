using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarraForca : MonoBehaviour
{

    //Variável de verificação
    public bool toque { get; set; }
    public Rigidbody2D rbBola;

    //Variáveis responsáveis para o controle da barra de força
    public float forcaMaxima { get; set; }
    public float forcaAtual { get; set; }
    public float incremento { get; set; }
    public Slider barraForca;
    public float velocidadeMaxima { get; set; }

    public float velocidadeParada = 0.25f;
    float velocidadeParadaQuadrada;

    private void Awake()
    {
        rbBola = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        //Controle da barra de força
        forcaMaxima = 1.0f;
        incremento = 0.01f;
        forcaAtual = 0.0f;
        velocidadeMaxima = 10.00f;

        velocidadeParadaQuadrada = velocidadeParada * velocidadeParada;
    }


    void Update()
    {
        if (toque == true)
        {

        }
        else
        {
            verificaForca();
        }
    }

    private void OnMouseDown()
    {
        toque = true;
    }
    private void OnMouseUp()
    {
        toque = false;
        SendMessage("Disparar");

    }

    void verificaForca()
    {
        forcaAtual += incremento;
        if (forcaAtual >= forcaMaxima || forcaAtual < 0)
            incremento *= -1;
        barraForca.value += incremento;
    }

    public float valorVelocidadeLancamentoQuadrado()
    {

        float velocidadeLancamento = forcaAtual * velocidadeMaxima; ;
        float velocidadeLancamentoQuadrado = velocidadeLancamento * velocidadeLancamento;
        return velocidadeLancamentoQuadrado;
    }
}
