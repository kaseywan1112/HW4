using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBox : MonoBehaviour
{
    bool passed = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(passed) return;

        if (other.gameObject.tag == "Player")
        {
            passed = true;
            ScoreManager.instance.IncreaseScore();

        }
    }
    // Start is called before the first frame update

}
