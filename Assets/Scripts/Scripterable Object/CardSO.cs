using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSO : Region_Class
{
    public int Cost;
    public int Rank;
    public string Text;
    // Start is called before the first frame update

    public CardSO(int cost, int rank, string region, string text)
    {
        this.Cost = cost;
        this.Rank = rank;
        this.Text = text;
        
        base.Set_Region(region);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}