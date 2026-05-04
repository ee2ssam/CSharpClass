using UnityEngine;

//1부터 5까지 1씩 증가하면서 값을 출력하는 프로그램 구현
//Count: 1
//Count: 2
//Count: 3
//Count: 4
//Count: 5
public class ForCount : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 5까지 1씩 증가하면서 값을 출력 - 5번 반복
        /*for(int i = 0; i < 5; i++)  //5번 반복 - 1
        {
            Debug.Log($"Count: {i + 1}");
        }*/

        for(int i = 1; i <= 5; i++) //5번 반복 - 2
        {
            Debug.Log($"Count: {i}");
        }

        /*for(int i = 1; i < 6; i++) //5번 반복 - 3
        {
            Debug.Log($"Count: {i}");
        }*/

        Debug.Log("=====================");

        //5부터 1까지 1씩 감소하면서 값을 출력
        for(int i = 5; i >= 1; i--)
        {
            Debug.Log($"CountDown: {i}");
        }
    }
}
