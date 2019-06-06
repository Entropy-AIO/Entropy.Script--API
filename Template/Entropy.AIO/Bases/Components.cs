namespace Entropy.AIO.Bases
{
    using System.Collections.Generic;
    using SDK.Enumerations;
    using SDK.Extensions.Objects;
    using SDK.UI;
    using SDK.UI.Components;
    using SDK.UI.CustomComponents;
    using SharpDX;

    class Components
    {
        public static class General
        {
            public static readonly MenuBool OrbwalkerOnlyMenuBool = new MenuBool("orbwalker", "ֻ�����߿�", false);

            public static readonly MenuBool CastOnSmallJungleMinionsMenuBool =
                new MenuBool("junglesmall", "��Ұ��СҰ���ͷż���", false);

            public static readonly MenuBool StormrazorComboMenubool = new MenuBool("Combo", "����", false);
            public static readonly MenuBool StormrazorLaneClearMenubool = new MenuBool("LaneClear", "����", false);
            public static readonly MenuBool StormrazorHarassMenubool = new MenuBool("Harass", "ɧ��", false);
            public static readonly MenuBool StormrazorLasthitMenubool = new MenuBool("Lasthit", "β��", false);

            public static readonly MenuBool IgnoreManaManagerBlue =
                new MenuBool("nomanagerifblue", "��BUFFʱ��������������", false);

            public static readonly MenuSlot PreserveManaMenu =
                new MenuSlot($"{LocalPlayer.Instance.CharName.ToLower()}.���������˵�", false, false);

            public static readonly MenuSlot PreserveSpellsMenu =
                new MenuSlot($"{LocalPlayer.Instance.CharName.ToLower()}.�������ܲ˵�",
                    false,
                    0,
                    0,
                    10);
        }

        public static class DrawingMenu
        {
            public static readonly MenuBool SharpDXMode = new MenuBool("sharpDXMode", "SharpDX ģʽ");
            public static readonly MenuSlider CircleThickness = new MenuSlider("CircleThickness", "��Ȧ�ֶ�", 1, 1, 10);

            public static readonly MenuColor ColorQ = new MenuColor("color1", "Q ��ɫ", new Color(255, 0, 0));
            public static readonly MenuColor ColorW = new MenuColor("color2", "W ��ɫ", new Color(0, 255, 0));
            public static readonly MenuColor ColorE = new MenuColor("color3", "E ��ɫ", new Color(0, 0, 255));
            public static readonly MenuColor ColorR = new MenuColor("color4", "R ��ɫ", new Color(255, 255, 255));
            public static readonly MenuColor ColorExtra = new MenuColor("color5", "������ɫ", new Color(0, 0, 0));

            public static readonly MenuBool QBool = new MenuBool($"{LocalPlayer.Instance.CharName}.QR", "���� Q", false);
            public static readonly MenuBool WBool = new MenuBool($"{LocalPlayer.Instance.CharName}.WR", "���� W", false);

            public static readonly MenuBool EBool = new MenuBool($"{LocalPlayer.Instance.CharName}.ER",
                "���� E",
                LocalPlayer.Instance.GetChampion() == Champion.Twitch ||
                LocalPlayer.Instance.GetChampion() == Champion.Kalista);

            public static readonly MenuBool RBool = new MenuBool($"{LocalPlayer.Instance.CharName}.RR", "���� R", false);

            public static readonly MenuBool QDamageBool =
                new MenuBool($"{LocalPlayer.Instance.CharName}.QD", "���� Q �˺�", false);

            public static readonly MenuBool WDamageBool =
                new MenuBool($"{LocalPlayer.Instance.CharName}.WD", "���� W �˺�", false);

            public static readonly MenuBool EDamageBool = new MenuBool($"{LocalPlayer.Instance.CharName}.ED",
                "���� E �˺�",
                LocalPlayer.Instance.GetChampion() == Champion.Twitch ||
                LocalPlayer.Instance.GetChampion() == Champion.Kalista);

            public static readonly MenuBool RDamageBool =
                new MenuBool($"{LocalPlayer.Instance.CharName}.RD", "���� R �˺�", false);

            public static readonly MenuSliderBool AutoDamageSliderBool =
                new MenuSliderBool($"{LocalPlayer.Instance.CharName}.autos", "���� X ���չ��˺�", false, 1, 1, 10);
        }

        public static class Gapcloser
        {
            public static Dictionary<string, Menu> AntiGapcloserSpellSlot = new Dictionary<string, Menu>();
            public static Dictionary<string, Menu> EnemyChampionName = new Dictionary<string, Menu>();
            public static Dictionary<string, MenuBool> EnemySpell = new Dictionary<string, MenuBool>();
        }
    }
}