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

    // 1. 생성자 => 안써도 괜찮다라는 규칙을 가진 곳도 있긴해요. eg) 내 전 직장..
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
            // 레벨이 올라갔을 때 처리
            /*
             * 1) 스탯이 올라감
             * 2) 업적을 처리함
             */
        }

        return isLevelUp;
    }

    private int GetRequiredExpForNextlevel()
    {
        // 구간마다 요구되는 경험치량이 다르잖아요? 일단 경험치 요구량 공식은 이렇다라고 가정
        // 만약에 테이블이 있다면 그 테이블을 참조하면서 계속 계산하면 됨
        return 100 + (Level * 50);
    }

    // 이하 장비 장착

    // 스킬
}
