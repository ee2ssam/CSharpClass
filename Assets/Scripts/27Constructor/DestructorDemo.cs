using UnityEngine;

namespace Constructor
{
    //소멸자 테스트
    public class DestructorDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {   
           /* //DestructorTest클래스의 인스턴스 생성
            DestructorTest destructorTest = new DestructorTest();
            //인스턴스 사용
            destructorTest.Run();

            //소멸자 호출 - 가비지켈렉터(GC)가 알아서 대신 해준다
            //~DestructorTest();*/

            //Car 클래스의 인스턴스(객체) 생성
            //하얀차, 파란차, 빨간차 만들기
            Car whiteCar = new Car();
            whiteCar.Run();

            Car blueCar = new Car("파란");
            blueCar.Run();

            Car redCar = new Car("빨간");
            redCar.Run();

            //폐차: GC가 알아서 한다
        }
    }
}

/*
Destructor(소멸자): 클레스가 사용된 후 가장 마지막에 호출되는 메서드
: 생성된 인스턴스(객체)가 메모리상에서 없어질때 호출
: 클래스에서 사용된 메모리 해제.. 등

c# 메모리 해제 : 가비지컬렉터(GC)가 메모리 해제 역할을 대신 해준다

class Dog(클래스이름)
{
    //생성자
    public Dog()
    {
    }

    //소멸자
    ~Dog()
    {
        //개체가 소멸할때 필요한 기능 수행
    }
}

*/



