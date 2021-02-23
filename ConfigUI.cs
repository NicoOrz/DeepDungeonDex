﻿using ImGuiNET;
using System.Diagnostics;
using System.Numerics;
using Dalamud.Plugin;

namespace DeepDungeonDex
{
    public class ConfigUI
    {

        public bool IsVisible { get; set; }
        private float opacity;
        private bool isClickthrough;
        private Configuration config;

        public ConfigUI(float opacity, bool isClickthrough, Configuration config)
        {
            this.config = config;
            this.opacity = opacity;
            this.isClickthrough = isClickthrough;
        }

        public void Draw()
        {
            if (!IsVisible)
                return;
            var flags = ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoTitleBar | ImGuiWindowFlags.AlwaysAutoResize;
            ImGui.SetNextWindowSizeConstraints(new Vector2(250, 100), new Vector2(1000, 1000));
            ImGui.Begin("设置", flags);
            if (ImGui.SliderFloat("不透明度", ref opacity, 0.0f, 1.0f))
            {
                config.Opacity = opacity;
            }
            if (ImGui.Checkbox("启用鼠标穿透", ref isClickthrough))
            {
                config.IsClickthrough = isClickthrough;
            }
            ImGui.NewLine();
            if (ImGui.Button("保存"))
            {
                IsVisible = false;
                config.Save();
            }
            ImGui.SameLine();
            var c = ImGui.GetCursorPos();
            ImGui.SetCursorPosX(ImGui.GetWindowContentRegionWidth() - ImGui.CalcTextSize("<3    Support on Ko-fi").X);
            ImGui.SmallButton("<3");
            ImGui.SetCursorPos(c);
            if (ImGui.IsItemHovered())
            {
                ImGui.BeginTooltip();
                ImGui.PushTextWrapPos(400f);
                ImGui.TextWrapped("Thanks to the Deep Dungeons Discord server for a lot of clarification and information. Special shoutouts to Maygi for writing the best Deep Dungeon guides out there!");
                ImGui.PopTextWrapPos();
                ImGui.EndTooltip();
            };
            ImGui.SameLine();
            ImGui.PushStyleColor(ImGuiCol.Button, 0xFF5E5BFF);
            ImGui.PushStyleColor(ImGuiCol.ButtonActive, 0xFF5E5BAA);
            ImGui.PushStyleColor(ImGuiCol.ButtonHovered, 0xFF5E5BDD);
            c = ImGui.GetCursorPos();
            ImGui.SetCursorPosX(ImGui.GetWindowContentRegionWidth() - ImGui.CalcTextSize("Support on Ko-fi").X);
            if (ImGui.SmallButton("Support on Ko-fi"))
            {
                Process.Start("https://ko-fi.com/strati");
            }
            ImGui.SetCursorPos(c);
            ImGui.PopStyleColor(3);
            ImGui.End();
        }
    }
}
