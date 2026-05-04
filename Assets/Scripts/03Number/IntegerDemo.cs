using UnityEngine;

//숫자 데이터 형식 사용하기 : 정수형, 실수형
//정수형 (Integer)
public class IntegerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SignedInteger : (+,-) 부호가 있는 정수형 데이터 형식
        sbyte iSbyte = 127;
        short iInt16 = 32767;
        int iInt32 = 2147483647;
        long iInt64 = long.MaxValue;

        Debug.Log("iSbyte: " + iSbyte);
        Debug.Log("iInt16: " + iInt16);
        Debug.Log("iInt32: " + iInt32);
        Debug.Log("iInt64: " + iInt64);

        //UnSignedInter : (+,-) 부호가 없는 정수형 데이터 형식

    }
}


/*
1Byte : 8bit
1비트 : 0, 1 데이터를 저장하는 단위

8비트
-> -128

0000 0000   -> 0
0000 0001   -> 1
0000 0010   -> 2
0000 0011   -> 3

-> 127

sbyte : -128 ~ 127

byte : 0 ~ 255






*/