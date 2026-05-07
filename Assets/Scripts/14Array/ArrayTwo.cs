using UnityEngine;

//2차원배열 : 행과 열로 이루어진 배열
public class ArrayTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        //[1]배열 선언
        int[,] intArray;

        //[2]배열의 요소수(크기) 생성 - 행과 열이 고정(fix)
        intArray = new int[2,3];

        //[3]배열 초기화
        intArray[0, 0] = 1;
        intArray[0, 1] = 2;
        intArray[0, 2] = 3;

        intArray[1, 0] = 4;
        intArray[1, 1] = 5;
        intArray[1, 2] = 6;
        */
        //배열 선언, 배열의 요소수(크기) 생성, 배열 초기화 
        //int[,] intArray = new int[2, 3] { {1,2,3}, {4,5,6} };
        //int[,] intArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] intArray = { { 1, 2, 3 }, { 4, 5, 6 } };

        //[4]배열 사용하기
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log(intArray[i, j]);
            }
        }


    }
}
