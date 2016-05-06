﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CrazyStorm_Player.CrazyStorm
{
    abstract class Resource : IPlayData
    {
        public string Label { get; set; }

        public virtual void LoadPlayData(BinaryReader reader)
        {
            using (BinaryReader resourceReader = PlayDataHelper.GetBlockReader(reader))
            {
                Label = PlayDataHelper.ReadString(resourceReader);
            }
        }
    }
}