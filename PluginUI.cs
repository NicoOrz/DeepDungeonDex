
using ImGuiNET;
using System.Numerics;

namespace DeepDungeonDex
{
    public class PluginUI
    {
        public bool IsVisible { get; set; }
        private Configuration config;

        public PluginUI(Configuration config)
        {
            this.config = config;
        }

        public void Draw()
        {
            if (!IsVisible)
                return;
            var mobData = DataHandler.Mobs(TargetData.NameID);
            if (mobData == null) return;
            var flags = ImGuiWindowFlags.NoResize | ImGuiWindowFlags.AlwaysAutoResize | ImGuiWindowFlags.NoTitleBar;
            if (config.IsClickthrough)
            {
                flags |= ImGuiWindowFlags.NoInputs;
            }
            ImGui.SetNextWindowSizeConstraints(new Vector2(250, 0), new Vector2(9001, 9001));
            ImGui.SetNextWindowBgAlpha(config.Opacity);
            ImGui.Begin("cool strati window", flags);
            ImGui.Text("怪物名称：\n"+TargetData.Name);
            ImGui.NewLine();
            ImGui.Columns(3, null, false);
            ImGui.Text("怪物类型:\n");
            ImGui.Text(mobData.Aggro.ToString());
            ImGui.NextColumn();
            ImGui.Text("难度:\n");
            switch (mobData.Threat)
            {
                case DataHandler.MobData.ThreatLevel.Easy:
                    ImGui.PushStyleColor(ImGuiCol.Text, 0xFF00FF00);
                    ImGui.Text("简单");
                    ImGui.PopStyleColor();
                    break;
                case DataHandler.MobData.ThreatLevel.Caution:
                    ImGui.PushStyleColor(ImGuiCol.Text, 0xFF00FFFF);
                    ImGui.Text("中等");
                    ImGui.PopStyleColor();
                    break;
                case DataHandler.MobData.ThreatLevel.Dangerous:
                    ImGui.PushStyleColor(ImGuiCol.Text, 0xFF0000FF);
                    ImGui.Text("困难");
                    ImGui.PopStyleColor();
                    break;
                case DataHandler.MobData.ThreatLevel.Vicious:
                    ImGui.PushStyleColor(ImGuiCol.Text, 0xFFFF00FF);
                    ImGui.Text("噩梦");
                    ImGui.PopStyleColor();
                    break;
                default:
                    ImGui.Text("Undefined");
                    break;
            }
            ImGui.NextColumn();
            ImGui.Text("是否可眩晕:\n");
            switch (mobData.IsStunnable)
            {
                case true:
                    ImGui.PushStyleColor(ImGuiCol.Text, 0xFF00FF00);
                    ImGui.Text("是");
                    ImGui.PopStyleColor();
                    break;
                case false:
                    ImGui.PushStyleColor(ImGuiCol.Text, 0xFF0000FF);
                    ImGui.Text("否");
                    ImGui.PopStyleColor();
                    break;
                default:
                    ImGui.Text("Untested");
                    break;
            }
            ImGui.NextColumn();
            ImGui.Columns(1);
            ImGui.NewLine();
            ImGui.TextWrapped(mobData.MobNotes);
            ImGui.End();
        }
    }
}
