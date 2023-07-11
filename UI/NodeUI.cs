using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{
    public GameObject ui;
    public GameObject ui2;

    public Text upgradeCost;
    public Button upgradeButton;
    public Button upgradeButton2;

    public Text sellAmount;

    private Nodes target;

    public void SetTarget(Nodes _target)
    {
        target = _target;

        transform.position = target.GetBuildPosition();

        if (!target.isUpgraded)
        {
            upgradeCost.text = "$" + target.turretBlueprint.upgradeCost;
            upgradeButton.interactable = true;
            upgradeButton2.interactable = false;
            ui.SetActive(true);
            ui2.SetActive(false);
        }
        else if (!target.isUpgraded1)
        {
            upgradeCost.text = "$" + target.turretBlueprint.upgrade2Cost;
            upgradeButton.interactable = false;
            upgradeButton2.interactable = true;
            ui.SetActive(false);
            ui2.SetActive(true);
        }
        else
        {
            upgradeCost.text = "Done";
            upgradeButton.interactable = false;
            upgradeButton2.interactable = false;
            ui.SetActive(false);
            ui2.SetActive(true);
        }

        sellAmount.text = "$" + target.turretBlueprint.GetSellAmount();

        //ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
        ui2.SetActive(false);
    }

    public void Upgrade()
    {
        target.UpgradeTurret();
        upgradeButton.interactable = false;
        upgradeButton2.interactable = true;
        ui.SetActive(true);
        ui2.SetActive(false);
        BuildManager.instance.DeselectNode();
    }

    public void Upgrade2()
    {
        target.UpgradeTurret2();
        upgradeButton.interactable = false;
        upgradeButton2.interactable = false;
        ui.SetActive(false);
        ui2.SetActive(true);
        BuildManager.instance.DeselectNode();
    }

    public void Sell()
    {
        target.SellTurret();
        BuildManager.instance.DeselectNode();
    }

}
