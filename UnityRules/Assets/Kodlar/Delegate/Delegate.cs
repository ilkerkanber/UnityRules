using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate : MonoBehaviour
{
   ///Delegateler birden çok methodu aynı anda toplu çağırmayı sağlar
    public delegate void DelegateOrnek1();
    public delegate void DelegateOrnek2(int s1, int s2);

    private void Awake()
    {
        DelegateOrnek1 del = new DelegateOrnek1(Islem1);
        del += Islem2;
        del += Islem3;

        //Islem1()
        //Islem2()
        //Islem3()  sırasıyla çalışır

        DelegateOrnek2 del2 = new DelegateOrnek2(RefIslem1);
        del2 += RefIslem2;
        del2 += RefIslem3;

        //RefIslem1()
        //RefIslem2()
        //RefIslem3()  sırasıyla çalışır
    }

    void Islem1() { }
    void Islem2() { }
    void Islem3() { }


    void RefIslem1(int sayı1,int sayı2) {

    }
    void RefIslem2(int sayı1, int sayı2){

    }
    void RefIslem3(int sayı1, int sayı2){

    }

}
