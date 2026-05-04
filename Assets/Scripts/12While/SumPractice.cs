using UnityEngine;

//1부터 100까지의 정수중에 3의 배수 또는 4의 배수를 구해서 합하는 프로그램을 구현
//for, while
public class SumPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;

        for (int i = 1; i <= 100; i++)
        {
            /*if(i % 3  == 0 || i % 4 == 0) //3의 배수 또는 4의 배수 
            {
                sum = sum + i;
            }*/

            if(i % 3 == 0) //3의 배수
            {
                sum = sum + i;
            }
            else if(i % 4 == 0) //4의 배수
            {
                sum = sum + i;
            }
        }

        Debug.Log($"sum: {sum}");

    }
}
