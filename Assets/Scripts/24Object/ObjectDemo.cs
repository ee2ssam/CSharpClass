using UnityEngine;

//클래스(Class) : 하나의 이름으로 서로 다른 형식의 데이터들과 함수들을 묶어 관리하는 데이터 구조
//클래스 : 설계도
//객체(object) : 설계도인 클래스로 부터 만들어진 하나의 인스턴스(실체)

//[1] CarClass 이름으로 클래스 만들기
public class CarClass
{
    //Empty
}


public class ObjectDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]CarClass 의 객체(인스턴스, object) 생성하기
        CarClass car1 = new CarClass();
        var car2 = new CarClass();

        Debug.Log($"car1: {car1.GetHashCode()}");
        Debug.Log($"car2: {car2.GetHashCode()}");
    }
}
