using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1](정수형) 배열 선언    
        int[] numbers;

        //[2] 배열 요소수 생성, 배열 크기(길이) 결정 - 3
        numbers = new int[10];   //[0], [1], [2]

        //[3] 배열 값 초기화
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;

        //[4] 배열 사용하기
        /*
        Debug.Log($"numbers[0]: {numbers[0]}");
        Debug.Log($"numbers[1]: {numbers[1]}");
        Debug.Log($"numbers[2]: {numbers[2]}");
        */
        /*
        for (int i = 0; i < 3; i++)
        {
            //Debug.Log($"{i}번째 방의 값은 {numbers[i]}");
            Debug.Log($"{i} 인덱스의 값은 {numbers[i]}");
        }
        */
        // i=0 ~ i=numbers.Length-1
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log($"인덱스 {i}의 값은 {numbers[i]}");
        }

    }
}
