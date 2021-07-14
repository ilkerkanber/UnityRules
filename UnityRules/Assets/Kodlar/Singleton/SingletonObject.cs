using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonObject : MonoBehaviour
{
    public static SingletonObject Instance {
        get;     
        private set; //başka classlar değiştirmesin diye 
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else {
            Destroy(this);
        }
    }

    //classlarda
    private void Start()
    {
        NormalClassSingleton ns = NormalClassSingleton.Instance();//RAM 101
        NormalClassSingleton ns2 = NormalClassSingleton.Instance();//RAM 101   2 DEFA OLUŞTURMAZ 1 TANE OLUR.
    }
    public void SingletonMethod()
    {
        Debug.Log("Singleton Class Object çalıştı");
    }

    class NormalClassSingleton
    {
        private static NormalClassSingleton _Instance;
        private NormalClassSingleton()
        {

        }
        public static NormalClassSingleton Instance()
        {
            if (_Instance == null)
            {
                _Instance = new NormalClassSingleton();
            }
            return _Instance;
        }

    }

}
