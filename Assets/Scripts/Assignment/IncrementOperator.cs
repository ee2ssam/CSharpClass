using UnityEngine;

//증가 연산자 (++): 정수형 변수의 값을 1씩 증가
//감소 연산자 (--): 정수형 변수의 값을 1씩 감소
public class IncrementOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 증가 연산자
        int num = 100;

        //1씩 증가
        //num = num + 1;        //101
        //num += 1;             //101
        ++num;                  //101

        Debug.Log($"num: {num}");

        //[2] 감소 연산자
        int number = 100;

        //1씩 감소
        //number = number - 1;      //99
        //number -= 1;              //99
        --number;                   //99

        Debug.Log($"number: {number}");
    }
}
