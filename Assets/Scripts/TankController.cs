using UnityEngine;

public class TankController 
{
    private TankModel tankModel;
    private TankView tankView;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        this.tankModel = _tankModel;
        this.tankView = _tankView;
        GameObject.Instantiate(tankView.gameObject);
        tankView.SetTankController(this);
        tankModel.SetTankController(this);
    }
}
