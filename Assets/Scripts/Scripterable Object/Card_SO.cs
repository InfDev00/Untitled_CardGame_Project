using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card_SO : Region_Class
{
    private int Cost;
    private int Rank;
    private string Text;

    public struct Card_Dataset
    {
        public int Data_Cost;
        public int Data_Rank;
        public string Data_Text;
        public string Data_Region;
    }

    public void Set_Card(int cost, int rank, string region, string text)
    {
        this.Cost = cost;
        this.Rank = rank;
        this.Text = text;
        
        base.Set_Region(region);
    }

    public Card_Dataset Get_Card()
    {
        Card_Dataset Rtn_Set = new Card_Dataset();
        Rtn_Set.Data_Cost = this.Cost;
        Rtn_Set.Data_Rank = this.Rank;
        Rtn_Set.Data_Text = this.Text;
        Rtn_Set.Data_Region = base.Get_Region();

        return Rtn_Set;
    }
}