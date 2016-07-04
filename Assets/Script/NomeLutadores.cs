using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NomeLutadores : MonoBehaviour
{
    public InputField tempo, tempoIntervalo, tempoMedico, nomeA, nomeV;

    void Start()
    {
        tempo.text = PlayerPrefs.GetString("Tempo");
        tempoIntervalo.text = PlayerPrefs.GetString("TempoIntervalo");
        tempoMedico.text = PlayerPrefs.GetString("TempoMedico");
    }

    void Update()
    {
        PlayerPrefs.SetString("Tempo", tempo.text);
        PlayerPrefs.SetString("TempoIntervalo", tempoIntervalo.text);
        PlayerPrefs.SetString("TempoMedico", tempoMedico.text);
        PlayerPrefs.SetString("NomeA", nomeA.text);
        PlayerPrefs.SetString("NomeV", nomeV.text);
    }
}
