using UnityEngine;
using System.Collections;

public class ControleDirecao : MonoBehaviour
{

    SpriteRenderer renderSeta;

    BarraForca barraforca;
    public GameObject seta;
    public GameObject bola;
    public Rigidbody2D rbSeta;
    public Rigidbody2D rbBola;
    public Transform transSeta;


    UnityStandardAssets.Utility.AutoMoveAndRotate rotateSeta;

    bool isMoving = false;
    bool hasMouseOver = false;


    // Use this for initialization
    void Start()
    {

        renderSeta = GetComponent<SpriteRenderer>();
        barraforca = (BarraForca)bola.GetComponent(typeof(BarraForca));
        rotateSeta = (UnityStandardAssets.Utility.AutoMoveAndRotate)seta.GetComponent(typeof(UnityStandardAssets.Utility.AutoMoveAndRotate));


    }

    // Update is called once per frame
    void Update()
    {

        verificaObjeto();

    }


    void verificaObjeto()
    {

        if (barraforca.toque == true)
        {
            renderSeta.enabled = true;
            rbSeta.isKinematic = false;
            rotateSeta.enabled = true;
            rotateSeta.moveUnitsPerSecond.value.y = 75.0f;
            hasMouseOver = true;
        }
        else
        {
            renderSeta.enabled = false;
            rbSeta.isKinematic = true;
            rotateSeta.enabled = false;
            //rotateSeta.moveUnitsPerSecond.value.y = 0.0f;
        }
        if (hasMouseOver && !barraforca.toque)
        {
            isMoving = true;
            hasMouseOver = false;
            barraforca.rbBola.isKinematic = false;

        }
    }



}
