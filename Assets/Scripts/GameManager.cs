using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chapter.Singleton
{
    public class GameManager : Singleton<GameManager>
    {
        public GameObject snake;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                deathRestart();
            }
        }

        public void deathRestart()
        {
            snake.transform.position = new Vector2(0, -1);
            snake.transform.rotation = Quaternion.Euler(0, 0, -90);
            snake.GetComponent<Snake>().direction = Vector2.right;
            Time.timeScale = 0.05f;
            snake.GetComponent<Snake>().resetSegments();
        }
    }

}