using System.Collections;
using UnityEngine;

public class Minotauros : MonoBehaviour
{
    private Coroutine coroutine;


    private void Start()
    {
      

        StartCoroutine(Smash());    
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (coroutine != null)
            {
                StopCoroutine(coroutine);
            }

            coroutine = StartCoroutine(Damnation());
        }
    }

    private IEnumerator Smash()
    {
        Debug.Log("Smash");

        yield return new WaitForSeconds(2.5f);

        Debug.Log("Smash Exit");
    }

    private IEnumerator Damnation()
    {
        Debug.Log("Damnation");

        yield return new WaitForSeconds(2.5f);

        Debug.Log("Damnation Exit");
    }
}
