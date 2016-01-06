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
    /// DxfMLineStyle class
    /// </summary>
    public partial class DxfMLineStyle : DxfObject
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.MLineStyle; } }
        public string StyleName { get; set; }
        private int _flags { get; set; }
        public string Description { get; set; }
        public DxfColor FillColor { get; set; }
        public double StartAngle { get; set; }
        public double EndAngle { get; set; }
        private int _elementCount { get; set; }
        private IList<double> _elementOffsets { get; set; }
        private IList<DxfColor> _elementColors { get; set; }
        private IList<string> _elementLinetypes { get; set; }

        // _flags flags

        public bool FillOn
        {
            get { return DxfHelpers.GetFlag(_flags, 1); }
            set
            {
                var flags = _flags;
                DxfHelpers.SetFlag(value, ref flags, 1);
                _flags = flags;
            }
        }

        public bool DisplayMiters
        {
            get { return DxfHelpers.GetFlag(_flags, 2); }
            set
            {
                var flags = _flags;
                DxfHelpers.SetFlag(value, ref flags, 2);
                _flags = flags;
            }
        }

        public bool StartSquareEndCap
        {
            get { return DxfHelpers.GetFlag(_flags, 16); }
            set
            {
                var flags = _flags;
                DxfHelpers.SetFlag(value, ref flags, 16);
                _flags = flags;
            }
        }

        public bool StartInnerArcsCap
        {
            get { return DxfHelpers.GetFlag(_flags, 32); }
            set
            {
                var flags = _flags;
                DxfHelpers.SetFlag(value, ref flags, 32);
                _flags = flags;
            }
        }

        public bool StartRoundCap
        {
            get { return DxfHelpers.GetFlag(_flags, 64); }
            set
            {
                var flags = _flags;
                DxfHelpers.SetFlag(value, ref flags, 64);
                _flags = flags;
            }
        }

        public bool EndSquareCap
        {
            get { return DxfHelpers.GetFlag(_flags, 256); }
            set
            {
                var flags = _flags;
                DxfHelpers.SetFlag(value, ref flags, 256);
                _flags = flags;
            }
        }

        public bool EndInnerArcsCap
        {
            get { return DxfHelpers.GetFlag(_flags, 512); }
            set
            {
                var flags = _flags;
                DxfHelpers.SetFlag(value, ref flags, 512);
                _flags = flags;
            }
        }

        public bool EndRoundCap
        {
            get { return DxfHelpers.GetFlag(_flags, 1024); }
            set
            {
                var flags = _flags;
                DxfHelpers.SetFlag(value, ref flags, 1024);
                _flags = flags;
            }
        }

        public DxfMLineStyle()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.StyleName = null;
            this._flags = 0;
            this.Description = null;
            this.FillColor = DxfColor.ByLayer;
            this.StartAngle = 90.0;
            this.EndAngle = 90.0;
            this._elementCount = 0;
            this._elementOffsets = new List<double>();
            this._elementColors = new List<DxfColor>();
            this._elementLinetypes = new List<string>();
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbMlineStyle"));
            pairs.Add(new DxfCodePair(2, (this.StyleName)));
            pairs.Add(new DxfCodePair(70, (short)(this._flags)));
            pairs.Add(new DxfCodePair(3, (this.Description)));
            pairs.Add(new DxfCodePair(62, GetRawValue(this.FillColor)));
            pairs.Add(new DxfCodePair(51, (this.StartAngle)));
            pairs.Add(new DxfCodePair(52, (this.EndAngle)));
            pairs.Add(new DxfCodePair(71, (short)Elements.Count));
            foreach (var item in Elements)
            {
                pairs.Add(new DxfCodePair(49, item.Offset));
                pairs.Add(new DxfCodePair(62, GetRawValue(item.Color)));
                pairs.Add(new DxfCodePair(6, item.Linetype));
            }

        }
    }

}
