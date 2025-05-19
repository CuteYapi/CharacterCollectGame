using UnityEngine;

public class Character : MonoBehaviour
{
    public int Id {  get; private set; }
    public int Grade { get; private set; }
    public string Name { get; private set; }

    public string PrefabPath { get; private set; }
    public string PotraitPath { get; private set; }
    public string IconPath { get; private set; }
    public string BackgroundImagePath { get; private set; }

    public int Level { get; private set; }
    public int Exp { get; private set; }
    public int LovePoint { get; private set; }

    public CharacterStatus Status { get; private set; }

    // 1. ������ => �Ƚᵵ �����ٶ�� ��Ģ�� ���� ���� �ֱ��ؿ�. eg) �� �� ����..
    public Character(CharacterData data)
    {
        Id = data.Id;
        Grade = data.Grade;
        Name = data.Name;

        PrefabPath = data.PrefabPath;
        PotraitPath = data.PotraitPath;
        IconPath = data.IconPath;
        BackgroundImagePath = data.BackgroundImagePath;

        Level = data.Level;
        Exp = data.Exp;
        LovePoint = data.LovePoint;
    }

    public bool LevelUp(int expAmount)
    {
        Exp += expAmount;
        bool isLevelUp = false;

        while (Exp >= GetRequiredExpForNextlevel())
        {
            Exp -= GetRequiredExpForNextlevel();
            Level++;
            isLevelUp = true;
        }

        if(isLevelUp == true)
        {
            // ������ �ö��� �� ó��
            /*
             * 1) ������ �ö�
             * 2) ������ ó����
             */
        }

        return isLevelUp;
    }

    private int GetRequiredExpForNextlevel()
    {
        // �������� �䱸�Ǵ� ����ġ���� �ٸ��ݾƿ�? �ϴ� ����ġ �䱸�� ������ �̷��ٶ�� ����
        // ���࿡ ���̺��� �ִٸ� �� ���̺��� �����ϸ鼭 ��� ����ϸ� ��
        return 100 + (Level * 50);
    }

    // ���� ��� ����

    // ��ų
}
