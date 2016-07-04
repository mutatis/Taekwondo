using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AddPonto : MonoBehaviour
{
    public Text azul, vermelho;

    int pontoAzul, pontoVermelho;

    void Update()
    {
        azul.text = pontoAzul.ToString();

        vermelho.text = pontoVermelho.ToString();

        if (Tempo.tempo.theTimer > 0)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                pontoAzul++;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                pontoVermelho++;
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                pontoAzul += 3;
            }
            else if (Input.GetKeyDown(KeyCode.Z))
            {
                pontoVermelho += 3;
            }

            if (Input.GetKeyDown(KeyCode.D) && pontoAzul > 0)
            {
                pontoAzul--;
            }
            else if (Input.GetKeyDown(KeyCode.A) && pontoVermelho > 0)
            {
                pontoVermelho--;
            }
        }
    }
}