﻿namespace GrasscutterTools.Game.Mail
{
    /// <summary>
    /// 附件
    /// </summary>
    public struct MailItem
    {
        /// <summary>
        /// 物品ID
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// 物品数量
        /// </summary>
        public int ItemCount { get; set; }

        /// <summary>
        /// 物品等级
        /// </summary>
        public int ItemLevel { get; set; }

        public override string ToString()
        {
            if (ItemLevel > 1)
                return $"{ItemId}:{GameData.Items[ItemId]} x{ItemCount} lv{ItemLevel}";
            else if (ItemCount > 1)
                return $"{ItemId}:{GameData.Items[ItemId]} x{ItemCount}";
            else
                return $"{ItemId}:{GameData.Items[ItemId]}";
        }
    }
}