using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D meurB;
    [SerializeField] float velocidade = 5f;
    // Start is called before the first frame update
    void Start()
    {
        meurB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mov();

    }

    private void mov()
    {
        //pegando o input horizontal
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 minhavelocidade = new Vector2(horizontal, vertical);
        //normalizando
        minhavelocidade.Normalize();
        //passando a minha velocidade para o meu RB
        meurB.velocity = minhavelocidade * velocidade;
    }
}
