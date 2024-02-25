using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject sueloPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateSuelo());
    }
    IEnumerator CreateSuelo()
    {
        while (true)
        {
            int xPosition = Random.Range(0, 3);

            GameObject newSuelo = Instantiate(sueloPrefab, new Vector2(Utils.GetRightSide(), xPosition), Quaternion.identity);
            newSuelo.name = "Suelo";
            yield return new WaitForSeconds(3.0f);
        }
    } 

        // Update is called once per frame
        void Update()
    {
        
    }
}
