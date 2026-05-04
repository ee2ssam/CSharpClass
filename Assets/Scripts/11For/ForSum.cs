using UnityEngine;

public class ForSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 n(20)까지의 합을 구하는 프로그램 구현
        // 1 + 2 + 3 + 4 + 5 ....
        /*int n = 20;
        int sum = 0;        //합

        for(int i = 1; i <= n; i++)
        {
            sum = sum + i;  //i 누적식
        }

        Debug.Log($"합은 {sum}");*/

        //1부터 n(10)까지의 정수중 짝수들의 합을 구하는 프로그램 구현
        // 2, 4, 6, 8, 10, ...
        int n = 10;
        int sum = 0;

        for(int i = 1; i <= n; i++)
        {
            //반복 실행문
            if(i % 2 == 0) //짝수 판별식
            {
                sum = sum + i;
            }
        }

        Debug.Log($"합은 {sum}");

    }
}
