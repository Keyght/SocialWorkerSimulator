using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nazhatie : MonoBehaviour {
    int sceneId;
    bool PerehodNaScene2 = false;

    public void TrueOn ()
    {
        PerehodNaScene2 = true;
    }
    public void Perehod (int sceneId)
    {
        if (PerehodNaScene2) SceneManager.LoadScene(sceneId);
    }
		
	}

