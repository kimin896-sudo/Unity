using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TestK : MonoBehaviour
{
      void Start()
    {
        FirstStudy first_study = new FirstStudy();
        first_study.eassignment_3();
    }
}
public class FirstStudy
{
    public void eassignment_3()
    {
        int hp = 100;
        bool isDead = hp <= 0;

        if(isDead)
        {
            Debug.Log("사망");
        }
        else if(hp==50)
        {
            Debug.Log("반만 죽었어");
        }
        else
        {
            Debug.Log("살았다");
        }
    }
    //public void eassignment_3()
    //{
    //    // 논리연산
    //    // && 논리곱AND, ||(논리합 OR), ! (논리부정 NOT)
    //    // AND  모든 조건이 참일경우
    //    // OR 모든 조건중 하나라도 참일 때 
    //    // NOT 참이면 거짓을 거짓이면 참을 

    //    bool b =  true && false;
    //}
    //public void eassignment_2()
    //{
    //    // 정수 10을 담는 변수 a
    //    byte a = 10;
    //    // 정수 5를 담는 변수 b
    //    byte b = 5;
    //    // a 가 b 보다 크다 를 담는 불리언 변수 c
    //    bool c = a > b;
    //    // b 가 a 보다 작다 를 담는 불리언 변수 d
    //    bool d = b < a;
    //    // b + a 가 b 보다 작다. 를 담는 불리언 변수 e
    //    bool e = (b + a) < b;
    //    // a가 b와 같다를 담는 불리언 변수 f
    //    bool f = a == b;
    //    // a가 a와 다르다를 담는 불리언 변수 g
    //    bool g = a != a;
    //}

    //public void Operetion()
    //{
    //    int hp = 100;
    //    int monsterAttack = 101;
    //    hp -= monsterAttack;

    //    bool isAlive = hp >= 0;

    //    Debug.Log(isAlive);

    //}
    //void Nomal_function()
    //{
    //    Debug.Log("일반");
    //    Debug.LogWarning("경고");
    //    Debug.LogError("오류");

    //    int a = 10;
    //    float b = 0.2F;
    //    string c = "asdasd";
    //    char d = 'a';

    //    //스트링 포맷 방식
    //    Debug.LogFormat("{0},{1},{2}", a, b, c, d);
    //    //스트링 인터폴레이션
    //    Debug.Log($"{a} {b} {c} {d}");
    //}

    //public void Temp()
    //{
    //    int a = 10;
    //    int b = 20;

    //    a += b;
    //    Debug.Log(a);
    //    a -= b;
    //    Debug.Log(a);
    //    a *= b;
    //    Debug.Log(a);
    //    a /= b;
    //    Debug.Log(a);
    //}

    //public void eassignment_1()
    //{
    //    // maxHP변수를 만들고 100을 저장해 주세요
    //    byte maxHp = 100;
    //    // monsterAttack 변수를 만들고 50을 저장해주세요.
    //    byte monsterAttack = 50;
    //    // hp 변수를 만들고 maxHp변수의 값을 대입해 주세요
    //    byte hp = maxHp;
    //    // hp변수에서 monsterAttack 값을 빼주세요
    //    hp -= monsterAttack;
    //    // hp 변수의 값을 다시 maxHp의 값과 동일하게 만들어주세요
    //    hp = maxHp;
    //    // 최종적으로 hp 값을 출력하는데 "hp : 100"이 출력되게 해주세요
    //    Debug.Log($"hp : {hp}");

    //}

    //public void AddMinus()
    //{   
    //        //증감연산자 ++,--
    //        // 1 증감, 1 감소
    //        // 전위 증감 ++hp
    //        // 후위 증감 hp++
    //    int a = 10;
    //    int b = 10;
    //    Debug.Log(++a);
    //    Debug.Log(b++);
    //    Debug.Log(b);
    //}
}
