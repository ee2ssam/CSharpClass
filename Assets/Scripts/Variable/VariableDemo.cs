using UnityEngine;

public class VariableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]변수 선언과 동시에 값 대입하기 - 초기화
        int number = 7;
        Debug.Log(number);

        //[2]여러개의 변수를 콤마(,)를 이용해 한줄에서 선언하기
        //int number1;
        //int number2;
        //int number3;
        int number1, number2, number3;
        number1 = 1;
        number2 = 2;
        number3 = 3;
        Debug.Log(number1 + "," +  number2 + "," + number3);

        //[3] 여러개의 변수를 콤마(,)를 이용해 한줄에서 선언하고 같은 값(10)으로 초기화
        int a, b, c;
        a = b = c = 10;
        Debug.Log(a + "," + b + "," + c);

    }
}
