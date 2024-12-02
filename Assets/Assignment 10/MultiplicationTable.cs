using UnityEngine;

public class NewEmptyCSharpScript : MonoBehaviour

 
{

       void Start()
    {
           for (int x =1; x <= 10; x++){
            int sum = Multiply(5, x);
            Debug.Log(sum);
            
           }
           
    }
    int  Multiply(int num1 , int num2 )
{
    int Multiplication=num1*num2;
    return Multiplication;

    }
}
