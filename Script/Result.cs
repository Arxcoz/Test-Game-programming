using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public GameObject app;
    public Canvas currency;
    public Image VictoryIcon;
    public Image GameOverIcon;
    public Text Victory;
    public Text GameOver;
    public Button Returnbut;
    bool result;
    public void setResult(bool value)
    {
        result=value;
    }
    // Start is called before the first frame update
    void Start()
    {
        Returnbut.onClick.AddListener(() => GoShop());
    }

    // Update is called once per frame
    void Update()
    {
        if (result)
        {
            VictoryIcon.enabled = true;
            GameOverIcon.enabled = false;
            Victory.enabled = true;
            GameOver.enabled = false;
        }
        else
        {
            VictoryIcon.enabled = false;
            GameOverIcon.enabled = true;
            Victory.enabled = false;
            GameOver.enabled = true;
        }
    }
    void GoShop()
    {
        app.GetComponent<GestionnaireCanvas>().setInresult(false);
        currency.GetComponent<CurrencyShop>().NewColor();
    }
}
