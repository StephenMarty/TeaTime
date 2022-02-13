using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //for things like Game Over

public class Orders : MonoBehaviour
{
    [SerializeField] Workspace workspace; //Our general Workspace
    public class Tea
    {
        public int Sugar = 0;
        public int Honey = 0;
        public int Chamomile = 0;
        public int GreenTea = 0;
        public int BlackTea = 0;

        public Tea(int _Sugar, int _Honey, int _Chamomile, int _GreenTea, int _BlackTea)
        {
            Sugar = _Sugar;
            Honey = _Honey;
            Chamomile = _Chamomile;
            GreenTea = _GreenTea;
            BlackTea = _BlackTea;
        }
    }

    public class Order
    {
        public Tea Tea;
        public float TimeRemaining = 20f;
        public Order(Tea _Tea, float _TimeRemaining)
        {
            Tea = _Tea;
            TimeRemaining = _TimeRemaining;
        }
    }

    public List<Order> OrderList = new List<Order>();

    public Tea GenerateTea()
    {
        Tea NewTea;
        int Sugar = Random.Range(0, 3);
        int Honey = Random.Range(0, 3);

        int Type = Random.Range(0, 3);
        switch (Type)
        {
            case 0:
                NewTea = new Tea(Sugar, Honey, 1, 0, 0);
                break;
            case 1:
                NewTea = new Tea(Sugar, Honey, 0, 1, 0);
                break;
            case 2:
                NewTea = new Tea(Sugar, Honey, 0, 0, 1);
                break;
            default:
                NewTea = new Tea(Sugar, Honey, 1, 1, 1);
                break;
        }

        return NewTea;
    }

    public void MakeOrder()
    {
        OrderList.Add(new Order(GenerateTea(), 20f));
    }

    void Start()
    {
        MakeOrder();
    }

    void Update()
    {
        foreach (Order Ord in OrderList)
        {
            Ord.TimeRemaining -= Time.deltaTime;
            if (Ord.TimeRemaining <= 0f)
            {
                Debug.Log("GAME OVER");
            }
        }
    }
}
