using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpgradePanel : MonoBehaviour
{
    [SerializeField]
    private Text soldierNameText = null;
    [SerializeField]
    private Text amountText = null;
    [SerializeField]
    private Text priceText = null;
    [SerializeField]
    private Button purchaseButton = null;
    public void SetValue(Soldier soldier)
    {
        soldierNameText.text = soldier.soldierName;
        amountText = string.Format("{0}",soldier.amount);
        priceText.text = string.Format("{0} ¿¡³ÊÁö", soldier.price);
    }
}
