using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint rocketTurret;
    public TurretBlueprint laserBeamer;

    BuildManager buildManager;
    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }
    public void SelectRocketTurret()
    {
        Debug.LogWarning("Rocket Turret Selected");
        buildManager.SelectTurretToBuild(rocketTurret);
    }
    public void SelectLaserBeamer()
    {
        Debug.LogWarning("Laser Beameer Selected");
        buildManager.SelectTurretToBuild(laserBeamer);
    }
}
