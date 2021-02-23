using System.Collections.Generic;

namespace DeepDungeonDex
{
    public class DataHandler
    {
        public class MobData
        {
            public bool? IsStunnable { get; set; }
            public string MobNotes { get; set; }

            public enum ThreatLevel
            {
                Unspecified,
                Easy,
                Caution,
                Dangerous,
                Vicious
            }
            public ThreatLevel Threat { get; set; }

            public enum AggroType
            {
                Unspecified,
                视野感知,
                声音感知,
                范围感知,
                Boss
            }
            public AggroType Aggro { get; set; }
        }

        public static MobData Mobs(int nameID)
        {
            if (mobs.TryGetValue(nameID, out MobData value)) return value;
            else return null;
        }

        private static readonly Dictionary<int, MobData> mobs = new Dictionary<int, MobData>()
            {
				// HoH floors 1-9
                { 7262, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="给一仇附加可驱散的加重Debuff" } },
                { 7263, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="给一仇附加物理易伤10秒" } },
                { 7264, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条圆形可见范围AoE" } },
                { 7265, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="给一仇附加可驱散的中毒Dot" } },
                { 7266, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条扇形不可见睡眠AoE\n读条可见扇形AoE" } },
                { 7267, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="读条扇形可见AoE" } },
                { 7268, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="石化背对" } },
                { 7269, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条圆形可见范围AoE" } },
                { 7270, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见击退AoE" } },
                { 7271, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条扇形/圆形可见AoE" } },
                { 7272, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条对随机一人释放单体大伤害攻击" } },
                { 7273, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条对随机一人释放单体大伤害攻击" } },
                { 7274, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="对一仇附加可驱散的减速Debuff" } },
				// HoH floors 11-19
                { 7275, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条扇形可见AoE" } },
                { 7276, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="读条对一仇造成单体伤害" } },
                { 7277, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条圆形可见范围AoE" } },
                { 7278, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条圆形可见范围AoE" } },
                { 7279, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无读条对一仇释放三连伤害\n读条可见圆形AoE" } },
                { 7280, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条对一仇造成单体伤害\n读条对随机一人释放不可回避的圆形AoE" } },
                { 7281, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条背对\n读条圆形可见范围AoE" } },
                { 7282, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条圆形可见范围AoE" } },
                { 7283, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条圆形可见范围AoE" } },
                { 7284, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="读条圆形可见范围AoE" } },
                { 7285, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条圆形可见范围AoE" } },
                { 7286, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="无读条对一仇释放大扇形Aoe" } },
                { 7287, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条释放可见范围的直线AoE" } },
				// HoH floors 21-29
                { 7288, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="读条对一仇单体伤害+背对" } },
                { 7289, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条回血技能，可打断" } },
                { 7290, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="读条释放直线/圆形AoE" } },
                { 7291, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无论是否有仇恨，对随机1人位置释放可见范围的圆形Aoe" } },
                { 7292, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="读条对前方释放不可见范围的击退扇形Aoe\n读条点名一人释放单体大伤害攻击" } },
                { 7293, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="读条释放可见范围的直线Aoe" } },
                { 7294, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见范围的扇形Aoe" } },
                { 7295, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条点名随机1人释放吸引攻击将其吸引到自己脚下，然后对其释放扇形Aoe（可通过卡墙回避）" } },
                { 7296, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="混乱背对\n可见扇形AoE" } },
                { 7297, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="读条释放可见范围的直线Aoe" } },
                { 7298, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条释放可见范围的十字Aoe（附加生命最大值下降Debuff）\n读条释放可见范围的圆形Aoe" } },
                { 7299, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条释放超大范围的强麻痹（可打断）" } },
                { 7300, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条释放可见范围的圆形Aoe" } }, 
                //HoH floors 31-39
                { 7301, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无读条对一仇释放方格范围的Aoe" } },
                { 7302, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条释放可见范围的圆形Aoe\n无读条对一仇释放单体伤害" } },
                { 7303, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无读条对一仇释放单体伤害并附加可驱散的流血DoT\n读条可见扇形AoE" } },
                { 7304, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条全屏范围的超高伤害的自爆技能“切腹”" } },
                { 7305, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见直线AoE\n全屏范围的超高伤害的自爆技能“切腹”" } },
                { 7306, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="对一仇无读条释放单体伤害" } },
                { 7307, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见范围圆形Aoe" } },
                { 7308, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="读条释放需要分摊的中等伤害Aoe" } },
                { 7309, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无读条对一仇释放三连击" } },
                { 7310, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见范围的超大范围圆形Aoe" } },
                { 7311, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见直线AoE\n全屏范围的超高伤害的自爆技能“切腹”" } },
                { 7312, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无读条对前方发动不可见范围的连续扇形Aoe（看到抬起爪子远离正面）" } },
                { 7313, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="形变背对\n平A为扇形攻击" } },
				// HoH floors 41-49
                { 7314, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条对随机角色释放圆形Aoe龙卷" } },
                { 7315, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="读条一仇单体伤害" } },
                { 7316, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见范围的圆形Aoe" } },
                { 7317, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见范围的直线Aoe" } },
                { 7318, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="读条可见范围的直线Aoe" } },
                { 7319, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条对随机角色释放圆形Aoe龙卷" } },
                { 7320, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条一仇单体伤害\n读条释放可见范围的圆形Aoe" } },
                { 7321, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="读条释放可见范围的扇形Aoe" } },
                { 7322, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条释放前方可见范围的直线Aoe\n对随机玩家释放不可回避的圆形Aoe" } },
                { 7323, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无论是否有仇恨，会读条对随机1人释放可见范围的圆形AoE" } },
                { 7324, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="读条可见大范围的直线Aoe" } },
                { 7325, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见范围的直线Aoe" } },
                { 7326, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.声音感知, IsStunnable=true, MobNotes="无读条对随机1人释放圆形Aoe\n读条释放全屏AoE" } },
				//HoH floors 51-59
                { 7327, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="给一仇不断叠加易伤" } },
                { 7328, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="无读条对一仇造成单体伤害并附加30s流血Dot" } },
                { 7329, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条强化其自身攻击力20s\n读条圆形可见范围AoE" } },
                { 7330, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="读条可见范围直线高伤害Aoe\n读条全屏范围超高伤害AoE" } },
                { 7331, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无读条对一仇造成单体伤害并附加30s流血Dot\n读条可见扇形AoE" } },
                { 7332, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="读条释放可见范围的长直线Aoe" } },
                { 7333, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无" } },
                { 7334, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见范围扇形Aoe" } },
                { 7335, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条全屏附加吸附效果的AoE，接着迅速使用环形AoE" } },
                { 7336, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="无论是否有仇恨，会对随机1人释放不可回避的圆形AoE\n无读条对一仇释放单体伤害" } },
                { 7337, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="石化背对\n读条全屏范围超高伤害可打断AoE" } },
                { 7338, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="读条可见范围圆形/直线AoE" } },
                { 7339, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="读条可见范围圆形/扇形AoE" } },
				// HoH floors 61-69
                { 7340, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="给一仇不断叠加可驱散的中毒Dot" } },
                { 7341, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="给一仇不断叠加易伤" } },
                { 7342, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见范围圆形Aoe" } },
                { 7343, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="短读条释放可见范围方格高伤害Aoe" } },
                { 7344, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.声音感知, IsStunnable=true, MobNotes="读条可见范围扇形Aoe" } },
                { 7345, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见范围扇形Aoe" } },
                { 7346, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无读条释放前方扇形范围Aoe" } },
                { 7347, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条释放大环形Aoe，靠近打\n背对魅惑" } },
                { 7348, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条释放可见范围大圆形流血Aoe" } },
                { 7349, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见范围扇形Aoe\n读条为自己或身边的怪物附加增强防御Buff，可打断" } },
                { 7350, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条释放可见范围附加大量Debuff的圆形Aoe" } },
                { 7351, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见范围圆形/扇形AoE" } },
				// HoH floors 71-79
                { 7352, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条自身为圆心的可见范围圆形Aoe" } },
                { 7353, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="无论是否有仇恨，读条可见范围的圆形Aoe\n读条可见范围可打断/沉默的超大圆形附加睡眠效果的Aoe" } },
                { 7354, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无读条对站着其后方的目标释放单体击退大伤害攻击" } },
                { 7355, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无读条对一仇释放方格范围带冻伤Debuff的AoE" } },
                { 7356, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无论是否有仇恨，会读条对随机1人释放可见范围的圆形AoE\n读条附加冻结Buff的可打断扇形Aoe" } },
                { 7357, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="当没有仇恨时，不断释放超大范围低伤害AoE（可破除隐身效果）\n读条可见范围的大范围扇形Aoe,随后立即释放前方180度不可见范围超大伤害AoE" } },
                { 7358, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条强化自身，接着对一仇不断释放较高伤害单体攻击" } },
                { 7359, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="建立仇恨瞬间会对玩家释放大范围读条圆形aoe\n无读条对一仇释放单体大伤害攻击\n读条释放全屏范围狂暴AoE“凛冬之风”" } },
                { 7360, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见范围的超大范围扇形Aoe\n狂暴技能“狂风暴雪”" } },
                { 7361, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="狂暴技能“震地”" } },
                { 7362, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="读条可见范围的超大范围附加冻结效果的扇形Aoe\n背对”冰冷视线“\n一旦没有背对或躲避aoe会被立即扑杀" } },
                { 7363, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="读条小范围扇形AoE" } },
                { 7364, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见范围的大范围圆形Aoe" } },
				// HoH floors 81-89
				{ 7365, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.范围感知, IsStunnable=false, MobNotes="“雷电咆哮”靠近“寒冰咆哮”远离，读条释放有范围提示的扇形AoE“寒冰/火焰吐息”" } },
                { 7366, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="未建立仇恨时释放可使隐身失效的全屏Aoe“捶胸”，给我方叠加易伤Debuff\n未建立仇恨时会读条技能“吃香蕉”强化自身攻击力15s" } },
                { 7367, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="无读条对建立仇恨者瞬发跳劈技能“殴打”\n读条释放有范围提示的扇形/圆形Aoe" } },
                { 7368, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="读条对正前方释放没有范围提示的超大范围扇形Aoe“十一吨横扫”\n读条释放“恶咒” 需背对" } },
                { 7369, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="无论是否有仇恨，读条释放可见范围的圆形止步Aoe“古代岩石”" } },
                { 7370, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条可见范围圆形Aoe“火水”\n读条对其后方角色释放不可见扇形Aoe" } },
                { 7371, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="读条释放没有范围提示的直线/圆形Aoe" } },
                { 7372, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条释放可见范围的圆形Aoe“平地捶打”\n不断对一仇瞬发高伤害平A" } },
                { 7373, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="每隔几秒就会读条释放一次附加可叠加流血Dot的全屏Aoe“古菩的悲伤”，Dot很疼，可驱散\n读条可见圆形AoE\n无读条随机向一人方向释放扇形吸引，并马上释放可见范围扇形Aoe" } },
                { 7374, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.范围感知, IsStunnable=false, MobNotes=" 无读条释放全屏附加易伤的AoE“鲜血之月”\n读条释放可见范围环形/扇形Aoe，建议靠近打" } },
                { 7375, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="对建立仇恨者瞬发冲锋技能\n读条可见扇形Aoe“掀地”\n读条超大范围圆形Aoe“吼叫”\n软狂暴：十连全屏大伤害Aoe“遁地”" } },
                { 7376, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="建立仇恨立刻释放单体伤害‘躯体冲撞'，附加15秒可驱散流血Dot\n读条释放有范围提示的扇形Aoe“缺氧吐息”\n读条点名一人释放非常疼的4连圆形Aoe“震雷”，带感电Dot" } },
                { 7377, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="无读条对开怪者释放直线攻击“狂野冲锋”\n读条对前方释放无范围提示扇形Aoe“撕裂利爪”\n读条释放可见范围的圆形Aoe" } },
				// HoH floors 91-99
                { 7378, new MobData { Threat=MobData.ThreatLevel.Vicious, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无读条对一仇释放单体高伤害技能”寒风斧“/'裂石暴环'\n无读条对一仇连续连续使用3次附加击退效果的冲锋技能”猛突进“，MT建议靠墙打" } },
                { 7379, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条'步法'给自身附加加速buff，可打断\n读条“飘羽步”强化自身回避率6s，可被打断\n无读条对一仇附加流血Dot并释放三连攻击" } },
                { 7380, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条对一仇释放单体攻击“飞石”\n读条“救疗”为其他敌人恢复体力并增强防御，可打断" } },
                { 7381, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.范围感知, IsStunnable=false, MobNotes="平A为正面扇形范围，请注意面向\n读条点名随机一人释放可见范围直线冲锋Aoe" } },
                { 7382, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无读条对随机1人位置释放没有范围提示的圆形Aoe\n读条对随机1人释放可见范围的圆形Aoe'大漩涡'" } },
                { 7383, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="远离背面（待补全）" } },
                { 7384, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="无论是否有仇恨，读条可见范围的附带割伤DoT的圆形Aoe狂风Gust\n读条对自身附加强化防御Debuff" } },
                { 7385, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="读条释放可见范围的圆形AOE“虚无陷阱”\n 无读条对一仇释放没有范围提示的扇形Aoe虚无斩" } },
                { 7386, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条释放非常快的直线Aoe“葬送击”，必须提前躲避" } },
                { 7387, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="读条释放可见范围的扇形Aoe”深渊回转“\n无读条随机对一人释放单体大伤害攻击" } },
                { 7388, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="无读条对建立仇恨者瞬发高伤害直线冲锋\n无读条对一仇方向释放无范围提示扇形Aoe“十六吨横扫”\n读条释放无范围提示超大扇形Aoe“三十二吨横扫”\n读条释放没有范围提示的以自身为圆心的圆形Aoe“百二十八吨回转”" } },
                { 7389, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="无读条对一仇释放没有范围提示的扇形Aoe\n读条释放有范围提示的圆形Aoe'浓云密布'\n注意：会不断对自己使用无读条的“巨大化”强化自身伤害，请务必尽快击杀。" } },
                { 7390, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=true, MobNotes="背对恐惧\n无读条对一仇释放单体攻击\n会不断强化自身伤害\n读条释放可见范围的大范围圆形超高威力Aoe'亚拉戈陨石'" } },
                { 7391, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.视野感知, IsStunnable=null, MobNotes="锥形Aoe（待补全）" } },
                { 7584, new MobData { Threat=MobData.ThreatLevel.Dangerous, Aggro=MobData.AggroType.视野感知, IsStunnable=false, MobNotes="背对恐惧\n无读条对一仇造成单体伤害\n读条释放可见范围的大范围圆形超高威力Aoe“亚拉戈陨石”\n注意：怪物会不断提高自身攻击力，请尽快击杀。" } }, 
                // HoH bosses and misc.
                { 7392, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="1-30层: 仅限铜箱子\n会释放高伤害单体攻击以及小范围即死AoE\n诅咒可被打断" } },
                { 7393, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.范围感知, IsStunnable=true, MobNotes="31-60层: 仅限银箱子\n会释放高伤害单体攻击以及小范围即死AoE\n诅咒可被打断" } },
                { 7394, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.范围感知, IsStunnable=false, MobNotes="61+层: 仅限金箱子\n会释放高伤害单体攻击以及小范围即死AoE\n诅咒只能被'插言'打断" } },
                { 7478, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.Boss, IsStunnable=false, MobNotes="出啥躲啥,当读条全屏AoE“踏脚”时，去场边雷云底下处理机制，亦可在读条时直接砸魔石处理（仅限21-30练级用）" } },
                { 7480, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.Boss, IsStunnable=false, MobNotes="出啥躲啥" } },
                { 7481, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.Boss, IsStunnable=false, MobNotes="出啥躲啥，注意背对，boss会在场外召唤若干小怪并引爆，站在中间处理" } },
                { 7483, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.Boss, IsStunnable=false, MobNotes="出啥躲啥，风团出现后提前观察风团位置，读条全屏击退攻击”古代暴风“时注意不要被击退到风团区域" } },
                { 7485, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.Boss, IsStunnable=false, MobNotes="1.无读条对前方释放无范围扇形AoE，看见Boss举起手就离开前方\n2.无读条对随机角色放出直线Aoe，看见Boss举起手就离开前方\n3.注意背对恐惧\n4.当Boss放置黑球时，观察黑球位置，往没有黑球的区域远离boss即可" } },
                { 7487, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.Boss, IsStunnable=false, MobNotes="走位回避各种Aoe，奶妈注意在读条”古代核爆“时抬血" } },
                { 7489, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.Boss, IsStunnable=false, MobNotes="1.读条释放前方的不可见范围扇形Aoe”猎食爪“\n2.读条释放圆形Aoe'唾液飞溅'\n3.点名随机1人读条释放'缩小球'并形成一个圆形区域。\n4.读条全屏Aoe'狂吠'\n5.读条点名随机1人释放可见范围的直线冲锋攻击'地狱冲',请被点名者立刻进入圆形区域中缩小回避，回避后也要迅速离开圆形区域。" } },
                { 7490, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.Boss, IsStunnable=false, MobNotes="出啥躲啥，当冰块出现时走位回避直线aoe并始终远离冰块" } },
                { 7493, new MobData { Threat=MobData.ThreatLevel.Caution, Aggro=MobData.AggroType.Boss, IsStunnable=false, MobNotes="出啥躲啥，读条全屏大伤害AoE“古代爆震”时请务必注意恢复\n沙球出现后会不断释放不可见范围的圆形Aoe，附带加重，一旦沙球出现立刻远离，如果坦克吃到了加重debuff请务必驱散" } },
                { 7610, new MobData { Threat=MobData.ThreatLevel.Easy, Aggro=MobData.AggroType.范围感知, IsStunnable=false, MobNotes="白给" } }
            };
    }
}