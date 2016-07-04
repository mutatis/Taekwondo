using UnityEngine;
using System.Collections;

public class MudaCena : MonoBehaviour
{
    public void Muda (string  nome)
    {
        Application.LoadLevel(nome);
    }
}
