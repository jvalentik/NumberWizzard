using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] private int min;
    [SerializeField] private int max;
    [SerializeField] private TextMeshProUGUI guessText;
    private int _guess;
    
    private void Start()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = _guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = _guess - 1;
        NextGuess();
    }

    private void NextGuess()
    {
        _guess = Random.Range(min, max + 1);
        guessText.text = _guess.ToString();
    }
}
