using UnityEngine;

// AndOperator(And 연산자, &&) : 둘다 참일때만 참
// 결과 : true, false
// 두개의 불형이 연산할때 둘다 참일때 참이고 나머지는 거짓
public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 둘 다 참일때만 연산의 결과 참
        Debug.Log(true && true);    //? true

        //[2] 둘중에 하나라도 거짓이면 거짓
        Debug.Log(false && true);    //? false
        Debug.Log(true && false);    //? false

        //[3] 둘다 거짓일 경우도 거짓
        Debug.Log(false && false);    //? false
    }
}
