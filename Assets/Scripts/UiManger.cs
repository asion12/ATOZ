using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiManger : MonoBehaviour
{
    [SerializeField]
    private GameObject upgradePanelTemplate = null;
    [SerializeField]
    private Text enegryText = null;
    [SerializeField]
    private Animator beakerAnimator = null;
    // Start is called before the first frame update
    private List<UpgradePanel> upgradePanelsList = new List<UpgradePanel>();
    void Start()
    {
        UpateEnergyPanel();
        CreatePanel();
    }
    public void CreatePanel()
    {
        GameObject newPanel = null;
        UpgradePanel newPanelComponent = null;

        foreach(Soldier soldier in GameManager.Instance.CurrentUser.soldierList)
        {
            newPanel = Instantiate(upgradePanelTemplate, upgradePanelTemplate.transform.parent);
            newPanelComponent = newPanel.GetComponent<UpgradePanel>();
            newPanelComponent.SetValue(soldier);
            newPanel.SetActive(true);
            upgradePanelsList.Add(newPanelComponent);
        }
    }


    public void OnClickBeaker()
    {
        beakerAnimator.Play("Click");
    }// Update is called once per frame
    public void UpateEnergyPanel()
    {
        enegryText.text = string.Format("{0} ¿¡³ÊÁö", GameManager.Instance.CurrentUser.energy);
    }
}