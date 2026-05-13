using System.Collections.Generic;
using UnityEngine;

//제네릭 리스트
public class ListOfInt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 배열 - 정수형 배열 변수 선언하고 요소수(크기) 생성
        int[] arrNumbers = new int[3];
        //배열 초기화
        arrNumbers[0] = 10;
        arrNumbers[1] = 20;
        arrNumbers[2] = 30;
        //배열 사용
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            Debug.Log(arrNumbers[i]);
        }

        Debug.Log("=====================");

        //[2] 제네릭 리스트 사용: int 전용 <int>
        //List<T> 의 인스턴스를 int 전용으로 생성하고 리스트에 40, 50, 60 저장하고 출력하라
        List<int> lstNumbers = new List<int>();
        //리스트 값 넣기
        lstNumbers.Add(40);
        lstNumbers.Add(50);
        lstNumbers.Add(60);

        //리스트 사용
        for (int i = 0; i < lstNumbers.Count; i++)
        {
            Debug.Log(lstNumbers[i]);
        }

        Debug.Log("=====================");

        lstNumbers.Add(80);

        //리스트 사용
        for (int i = 0; i < lstNumbers.Count; i++)
        {
            Debug.Log(lstNumbers[i]);
        }


        //[3] 제네릭 리스트 클레스(List<T>) : List<int>, List<string>, List<object>, ....
        //<string> 전용 리스트 인스턴스 생성
        List<string> colors = new List<string>();
        //리스트에 데이터 넣기
        colors.Add("Red");
        colors.Add("Green");
        colors.Add("Blue");

        //리스트 사용
        foreach (var c in colors)
        {
            Debug.Log(c);
        }

        for (int i = 0; i < colors.Count; i++)
        {
            Debug.Log(colors[i]);
        }


    }
}
