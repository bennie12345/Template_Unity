using UnityEngine;
using System.Collections;

public class Intro_script : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(2);
        AutoFade.LoadLevel("Menu",3,1,Color.black);
        print("ayy");
    }

    #if UNITY_EDITOR
        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                Application.LoadLevel("Menu");
            }
        }
    #endif
}
