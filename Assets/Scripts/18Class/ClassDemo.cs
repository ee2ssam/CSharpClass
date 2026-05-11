using UnityEngine;

public class ClassDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 정적(static) 메서드 호출
        //(클래스이름).메서드이름,  (클래스이름).변수이름
        ClassMember.StaticMethod();

        //[2]인스턴스(Instance) 메서드 호출
        //클래스의 객체를 생성 : new 키워드로 생성
        //(객체이름).메서드이름, (객체이름).변수이름
        ClassMember member = new ClassMember();
        member.InstanceMethod();

    }
}

/*
//변수(Variable) : 프로그램에서 사용할 데이터를 저장해 놓는 그릇, 하나
//Array(배열) : 하나의 이름으로 같은 데이터 형식을 여러개 보관해 놓는 그릇, 복수(같은 데이터 형식)
//데이터 형식 : int, long, bool, float, double, string, char
//변수 선언: (데이터 형식) 변수이름;
//배열 선언: (데이터 형식)[] 변수이름;

//구조체(Struct) : 하나의 이름으로 서로 다른 형식의 데이터들과 함수들을 묶어 관리하는 데이터 구조
//Enum (열거형, Enumeration) : 하나의 이름으로 서로 관련있는 정수 값을 갖는 상수들의 집합
//사용자 정의 데이터 형식 : 개발자가 만든 데이터 형식

//클래스(Class) : 하나의 이름으로 서로 다른 형식의 데이터들과 함수들을 묶어 관리하는 데이터 구조
//닷넷에서 사용하는 기본 구문
//사용자 정의 데이터 형식 : 개발자가 만든 데이터 형식
//클래스 객체(개체, 인스턴스) 생성(변수 선언)
//new 키워드로 새로운 객체를 생성
//(클래스이름) 객체이름 = new 클래스이름();
//(객체이름).메서드이름 - 함수 호출

//클래스 선언, 정의
public class 클래스이름
{
}

//클래스에 안에 있는 함수(Function, 메서드) 사용

*/