using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    bool dead = false;
    // Start is called before the first frame update
    void Start ()
    {
        int number = Numbers(10, 11);


        int number1 = Numbers(5, 1);

        int number2 = Numbers(3010, -650);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Numbers(int firstNumber, int secondNumber)
    {
      int finalNumber = firstNumber + secondNumber;
        return finalNumber;

    }


}
