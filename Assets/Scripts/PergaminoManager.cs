using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PergaminoManager : MonoBehaviour
{

    public Text pergaminosTotales;

    public Text pergaminosCollected;

    private int pergaminosTotalesInLevel;


    private void Start()
    {
        pergaminosTotalesInLevel = transform.childCount;
    }

    private void Update()
    {
        AllPergaminosCollected();
        pergaminosTotales.text = pergaminosTotalesInLevel.ToString();
        pergaminosCollected.text = transform.childCount.ToString();
    }

    public void AllPergaminosCollected()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("Recolectaste todos los pergaminos, Victoria");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }
}
