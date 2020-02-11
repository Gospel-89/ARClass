using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigate: MonoBehaviour
    {
       
        public void Geography()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }

         public void Biology()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
        }
         public void Physics()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +3);
        }
           public void Back()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex  -1);
        }
        public void close ()
	    {
		Application.Quit();
	    }
    }

