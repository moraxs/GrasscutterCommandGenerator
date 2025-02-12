﻿namespace GrasscutterTools.Pages
{
    partial class PageSetProp
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageSetProp));
            this.LblWorldLevel = new System.Windows.Forms.Label();
            this.NUDWorldLevel = new System.Windows.Forms.NumericUpDown();
            this.LblTowerLevel = new System.Windows.Forms.Label();
            this.NUDTowerLevel = new System.Windows.Forms.NumericUpDown();
            this.LblBPLevel = new System.Windows.Forms.Label();
            this.NUDBPLevel = new System.Windows.Forms.NumericUpDown();
            this.LblGodMode = new System.Windows.Forms.Label();
            this.LblUnlimitedStamina = new System.Windows.Forms.Label();
            this.LblUnlimitedEnergy = new System.Windows.Forms.Label();
            this.LblOpenState = new System.Windows.Forms.Label();
            this.BtnGodModeOn = new System.Windows.Forms.Button();
            this.BtnGodModeOff = new System.Windows.Forms.Button();
            this.BtnUnlimitedStaminaOn = new System.Windows.Forms.Button();
            this.BtnUnlimitedStaminaOff = new System.Windows.Forms.Button();
            this.BtnUnlimitedEnergyOn = new System.Windows.Forms.Button();
            this.BtnUnlimitedEnergyOff = new System.Windows.Forms.Button();
            this.BtnSetOpenState = new System.Windows.Forms.Button();
            this.BtnUnsetOpenState = new System.Windows.Forms.Button();
            this.BtnUnlockMap = new System.Windows.Forms.Button();
            this.NUDOpenStateValue = new System.Windows.Forms.NumericUpDown();
            this.LblSetPropTitle = new System.Windows.Forms.Label();
            this.LblPlayerProperty = new System.Windows.Forms.Label();
            this.CmbPlayerProperty = new System.Windows.Forms.ComboBox();
            this.NUDPlayerPropertyValue = new System.Windows.Forms.NumericUpDown();
            this.BtnPlayerPropertyOff = new System.Windows.Forms.Button();
            this.BtnPlayerPropertyOn = new System.Windows.Forms.Button();
            this.LblPlayerPropertyDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWorldLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTowerLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBPLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOpenStateValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPlayerPropertyValue)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWorldLevel
            // 
            resources.ApplyResources(this.LblWorldLevel, "LblWorldLevel");
            this.LblWorldLevel.Name = "LblWorldLevel";
            // 
            // NUDWorldLevel
            // 
            resources.ApplyResources(this.NUDWorldLevel, "NUDWorldLevel");
            this.NUDWorldLevel.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NUDWorldLevel.Name = "NUDWorldLevel";
            this.NUDWorldLevel.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NUDWorldLevel.ValueChanged += new System.EventHandler(this.NUDWorldLevel_ValueChanged);
            this.NUDWorldLevel.Click += new System.EventHandler(this.NUDWorldLevel_ValueChanged);
            // 
            // LblTowerLevel
            // 
            resources.ApplyResources(this.LblTowerLevel, "LblTowerLevel");
            this.LblTowerLevel.Name = "LblTowerLevel";
            // 
            // NUDTowerLevel
            // 
            resources.ApplyResources(this.NUDTowerLevel, "NUDTowerLevel");
            this.NUDTowerLevel.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NUDTowerLevel.Name = "NUDTowerLevel";
            this.NUDTowerLevel.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NUDTowerLevel.ValueChanged += new System.EventHandler(this.NUDBPLevel_ValueChanged);
            this.NUDTowerLevel.Click += new System.EventHandler(this.NUDBPLevel_ValueChanged);
            // 
            // LblBPLevel
            // 
            resources.ApplyResources(this.LblBPLevel, "LblBPLevel");
            this.LblBPLevel.Name = "LblBPLevel";
            // 
            // NUDBPLevel
            // 
            resources.ApplyResources(this.NUDBPLevel, "NUDBPLevel");
            this.NUDBPLevel.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDBPLevel.Name = "NUDBPLevel";
            this.NUDBPLevel.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDBPLevel.ValueChanged += new System.EventHandler(this.NUDTowerLevel_ValueChanged);
            this.NUDBPLevel.Click += new System.EventHandler(this.NUDTowerLevel_ValueChanged);
            // 
            // LblGodMode
            // 
            resources.ApplyResources(this.LblGodMode, "LblGodMode");
            this.LblGodMode.Name = "LblGodMode";
            // 
            // LblUnlimitedStamina
            // 
            resources.ApplyResources(this.LblUnlimitedStamina, "LblUnlimitedStamina");
            this.LblUnlimitedStamina.Name = "LblUnlimitedStamina";
            // 
            // LblUnlimitedEnergy
            // 
            resources.ApplyResources(this.LblUnlimitedEnergy, "LblUnlimitedEnergy");
            this.LblUnlimitedEnergy.Name = "LblUnlimitedEnergy";
            // 
            // LblOpenState
            // 
            resources.ApplyResources(this.LblOpenState, "LblOpenState");
            this.LblOpenState.Name = "LblOpenState";
            // 
            // BtnGodModeOn
            // 
            resources.ApplyResources(this.BtnGodModeOn, "BtnGodModeOn");
            this.BtnGodModeOn.Name = "BtnGodModeOn";
            this.BtnGodModeOn.Tag = "godmode on";
            this.BtnGodModeOn.UseVisualStyleBackColor = true;
            this.BtnGodModeOn.Click += new System.EventHandler(this.BtnSetPropButton_Click);
            // 
            // BtnGodModeOff
            // 
            resources.ApplyResources(this.BtnGodModeOff, "BtnGodModeOff");
            this.BtnGodModeOff.Name = "BtnGodModeOff";
            this.BtnGodModeOff.Tag = "godmode off";
            this.BtnGodModeOff.UseVisualStyleBackColor = true;
            this.BtnGodModeOff.Click += new System.EventHandler(this.BtnSetPropButton_Click);
            // 
            // BtnUnlimitedStaminaOn
            // 
            resources.ApplyResources(this.BtnUnlimitedStaminaOn, "BtnUnlimitedStaminaOn");
            this.BtnUnlimitedStaminaOn.Name = "BtnUnlimitedStaminaOn";
            this.BtnUnlimitedStaminaOn.Tag = "unlimitedstamina on";
            this.BtnUnlimitedStaminaOn.UseVisualStyleBackColor = true;
            this.BtnUnlimitedStaminaOn.Click += new System.EventHandler(this.BtnSetPropButton_Click);
            // 
            // BtnUnlimitedStaminaOff
            // 
            resources.ApplyResources(this.BtnUnlimitedStaminaOff, "BtnUnlimitedStaminaOff");
            this.BtnUnlimitedStaminaOff.Name = "BtnUnlimitedStaminaOff";
            this.BtnUnlimitedStaminaOff.Tag = "unlimitedstamina off";
            this.BtnUnlimitedStaminaOff.UseVisualStyleBackColor = true;
            this.BtnUnlimitedStaminaOff.Click += new System.EventHandler(this.BtnSetPropButton_Click);
            // 
            // BtnUnlimitedEnergyOn
            // 
            resources.ApplyResources(this.BtnUnlimitedEnergyOn, "BtnUnlimitedEnergyOn");
            this.BtnUnlimitedEnergyOn.Name = "BtnUnlimitedEnergyOn";
            this.BtnUnlimitedEnergyOn.Tag = "unlimitedenergy on";
            this.BtnUnlimitedEnergyOn.UseVisualStyleBackColor = true;
            this.BtnUnlimitedEnergyOn.Click += new System.EventHandler(this.BtnSetPropButton_Click);
            // 
            // BtnUnlimitedEnergyOff
            // 
            resources.ApplyResources(this.BtnUnlimitedEnergyOff, "BtnUnlimitedEnergyOff");
            this.BtnUnlimitedEnergyOff.Name = "BtnUnlimitedEnergyOff";
            this.BtnUnlimitedEnergyOff.Tag = "unlimitedenergy off";
            this.BtnUnlimitedEnergyOff.UseVisualStyleBackColor = true;
            this.BtnUnlimitedEnergyOff.Click += new System.EventHandler(this.BtnSetPropButton_Click);
            // 
            // BtnSetOpenState
            // 
            resources.ApplyResources(this.BtnSetOpenState, "BtnSetOpenState");
            this.BtnSetOpenState.Name = "BtnSetOpenState";
            this.BtnSetOpenState.UseVisualStyleBackColor = true;
            this.BtnSetOpenState.Click += new System.EventHandler(this.BtnSetOpenState_Click);
            // 
            // BtnUnsetOpenState
            // 
            resources.ApplyResources(this.BtnUnsetOpenState, "BtnUnsetOpenState");
            this.BtnUnsetOpenState.Name = "BtnUnsetOpenState";
            this.BtnUnsetOpenState.UseVisualStyleBackColor = true;
            this.BtnUnsetOpenState.Click += new System.EventHandler(this.BtnUnsetOpenState_Click);
            // 
            // BtnUnlockMap
            // 
            resources.ApplyResources(this.BtnUnlockMap, "BtnUnlockMap");
            this.BtnUnlockMap.Name = "BtnUnlockMap";
            this.BtnUnlockMap.Tag = "unlockmap on";
            this.BtnUnlockMap.UseVisualStyleBackColor = true;
            this.BtnUnlockMap.Click += new System.EventHandler(this.BtnSetPropButton_Click);
            // 
            // NUDOpenStateValue
            // 
            resources.ApplyResources(this.NUDOpenStateValue, "NUDOpenStateValue");
            this.NUDOpenStateValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDOpenStateValue.Name = "NUDOpenStateValue";
            // 
            // LblSetPropTitle
            // 
            resources.ApplyResources(this.LblSetPropTitle, "LblSetPropTitle");
            this.LblSetPropTitle.Name = "LblSetPropTitle";
            // 
            // LblPlayerProperty
            // 
            resources.ApplyResources(this.LblPlayerProperty, "LblPlayerProperty");
            this.LblPlayerProperty.Name = "LblPlayerProperty";
            // 
            // CmbPlayerProperty
            // 
            resources.ApplyResources(this.CmbPlayerProperty, "CmbPlayerProperty");
            this.CmbPlayerProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPlayerProperty.FormattingEnabled = true;
            this.CmbPlayerProperty.Name = "CmbPlayerProperty";
            this.CmbPlayerProperty.SelectedIndexChanged += new System.EventHandler(this.CmbPlayerProperty_SelectedIndexChanged);
            // 
            // NUDPlayerPropertyValue
            // 
            resources.ApplyResources(this.NUDPlayerPropertyValue, "NUDPlayerPropertyValue");
            this.NUDPlayerPropertyValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDPlayerPropertyValue.Name = "NUDPlayerPropertyValue";
            this.NUDPlayerPropertyValue.ValueChanged += new System.EventHandler(this.NUDPlayerPropertyValue_ValueChanged);
            this.NUDPlayerPropertyValue.Click += new System.EventHandler(this.NUDPlayerPropertyValue_ValueChanged);
            // 
            // BtnPlayerPropertyOff
            // 
            resources.ApplyResources(this.BtnPlayerPropertyOff, "BtnPlayerPropertyOff");
            this.BtnPlayerPropertyOff.Name = "BtnPlayerPropertyOff";
            this.BtnPlayerPropertyOff.Tag = "off";
            this.BtnPlayerPropertyOff.UseVisualStyleBackColor = true;
            this.BtnPlayerPropertyOff.Click += new System.EventHandler(this.BtnPlayerPropertyButton_Click);
            // 
            // BtnPlayerPropertyOn
            // 
            resources.ApplyResources(this.BtnPlayerPropertyOn, "BtnPlayerPropertyOn");
            this.BtnPlayerPropertyOn.Name = "BtnPlayerPropertyOn";
            this.BtnPlayerPropertyOn.Tag = "on";
            this.BtnPlayerPropertyOn.UseVisualStyleBackColor = true;
            this.BtnPlayerPropertyOn.Click += new System.EventHandler(this.BtnPlayerPropertyButton_Click);
            // 
            // LblPlayerPropertyDesc
            // 
            resources.ApplyResources(this.LblPlayerPropertyDesc, "LblPlayerPropertyDesc");
            this.LblPlayerPropertyDesc.AutoEllipsis = true;
            this.LblPlayerPropertyDesc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblPlayerPropertyDesc.Name = "LblPlayerPropertyDesc";
            // 
            // PageSetProp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblPlayerPropertyDesc);
            this.Controls.Add(this.BtnPlayerPropertyOff);
            this.Controls.Add(this.BtnPlayerPropertyOn);
            this.Controls.Add(this.NUDPlayerPropertyValue);
            this.Controls.Add(this.CmbPlayerProperty);
            this.Controls.Add(this.LblPlayerProperty);
            this.Controls.Add(this.LblSetPropTitle);
            this.Controls.Add(this.NUDOpenStateValue);
            this.Controls.Add(this.BtnUnlockMap);
            this.Controls.Add(this.BtnUnsetOpenState);
            this.Controls.Add(this.BtnSetOpenState);
            this.Controls.Add(this.BtnUnlimitedEnergyOff);
            this.Controls.Add(this.BtnUnlimitedEnergyOn);
            this.Controls.Add(this.BtnUnlimitedStaminaOff);
            this.Controls.Add(this.BtnUnlimitedStaminaOn);
            this.Controls.Add(this.BtnGodModeOff);
            this.Controls.Add(this.BtnGodModeOn);
            this.Controls.Add(this.LblOpenState);
            this.Controls.Add(this.LblUnlimitedEnergy);
            this.Controls.Add(this.LblUnlimitedStamina);
            this.Controls.Add(this.LblGodMode);
            this.Controls.Add(this.NUDBPLevel);
            this.Controls.Add(this.LblBPLevel);
            this.Controls.Add(this.NUDTowerLevel);
            this.Controls.Add(this.LblTowerLevel);
            this.Controls.Add(this.NUDWorldLevel);
            this.Controls.Add(this.LblWorldLevel);
            this.Name = "PageSetProp";
            ((System.ComponentModel.ISupportInitialize)(this.NUDWorldLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTowerLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBPLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOpenStateValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPlayerPropertyValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblWorldLevel;
        private System.Windows.Forms.NumericUpDown NUDWorldLevel;
        private System.Windows.Forms.Label LblTowerLevel;
        private System.Windows.Forms.NumericUpDown NUDTowerLevel;
        private System.Windows.Forms.Label LblBPLevel;
        private System.Windows.Forms.NumericUpDown NUDBPLevel;
        private System.Windows.Forms.Label LblGodMode;
        private System.Windows.Forms.Label LblUnlimitedStamina;
        private System.Windows.Forms.Label LblUnlimitedEnergy;
        private System.Windows.Forms.Label LblOpenState;
        private System.Windows.Forms.Button BtnGodModeOn;
        private System.Windows.Forms.Button BtnGodModeOff;
        private System.Windows.Forms.Button BtnUnlimitedStaminaOn;
        private System.Windows.Forms.Button BtnUnlimitedStaminaOff;
        private System.Windows.Forms.Button BtnUnlimitedEnergyOn;
        private System.Windows.Forms.Button BtnUnlimitedEnergyOff;
        private System.Windows.Forms.Button BtnSetOpenState;
        private System.Windows.Forms.Button BtnUnsetOpenState;
        private System.Windows.Forms.Button BtnUnlockMap;
        private System.Windows.Forms.NumericUpDown NUDOpenStateValue;
        private System.Windows.Forms.Label LblSetPropTitle;
        private System.Windows.Forms.Label LblPlayerProperty;
        private System.Windows.Forms.ComboBox CmbPlayerProperty;
        private System.Windows.Forms.NumericUpDown NUDPlayerPropertyValue;
        private System.Windows.Forms.Button BtnPlayerPropertyOff;
        private System.Windows.Forms.Button BtnPlayerPropertyOn;
        private System.Windows.Forms.Label LblPlayerPropertyDesc;
    }
}
