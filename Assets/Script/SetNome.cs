using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetNome : MonoBehaviour
{
    public Text text;

    public string nome;

    void Start()
    {
        text.text = PlayerPrefs.GetString(nome);
    }
}
