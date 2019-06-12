using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace SceneFlow
{
    public class changeSceneController
    {
		public string sceneToLoad;
			public void change(){
				SceneManager.LoadScene(sceneToLoad);
			}

    }
}