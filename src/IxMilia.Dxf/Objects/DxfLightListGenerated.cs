// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using IxMilia.Dxf.Collections;
using IxMilia.Dxf.Entities;

namespace IxMilia.Dxf.Objects
{

    /// <summary>
    /// DxfLightList class
    /// </summary>
    public partial class DxfLightList : DxfObject
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.LightList; } }
        protected override DxfAcadVersion MaxVersion { get { return DxfAcadVersion.R2007; } }
        public int Version { get; set; }

        public DxfLightList()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.Version = 0;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbLightList"));
            pairs.Add(new DxfCodePair(90, (this.Version)));
            pairs.Add(new DxfCodePair(90, Lights.Count));
            foreach (var item in Lights)
            {
                pairs.Add(new DxfCodePair(5, UIntHandle(item.Handle)));
                pairs.Add(new DxfCodePair(1, item.Name));
            }

        }
    }

}
