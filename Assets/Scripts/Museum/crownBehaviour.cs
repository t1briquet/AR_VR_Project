using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Museum
{
    public class crownBehaviour : MonoBehaviour
    {
        private Transform _crownTransform;


        // Start is called before the first frame update
        void Start()
        {

        }


        // Update is called once per frame
        void Update()
        {
          
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("you win !");
            SceneManager.LoadScene(4);


        }
    }
}
