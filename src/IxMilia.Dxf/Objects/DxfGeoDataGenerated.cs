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
    /// DxfGeoData class
    /// </summary>
    public partial class DxfGeoData : DxfObject
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.GeoData; } }
        protected override DxfAcadVersion MinVersion { get { return DxfAcadVersion.R2010; } }
        public DxfGeoDataVersion Version { get; set; }
        public DxfDesignCoordinateType CoordinateType { get; set; }
        public uint HostBlockhandle { get; set; }
        public DxfPoint DesignPoint { get; set; }
        public DxfPoint ReferencePoint { get; set; }
        public DxfVector NorthVector { get; set; }
        public double HorizontalUnitScale { get; set; }
        public double VerticalUnitScale { get; set; }
        public DxfUnits HorizontalUnits { get; set; }
        public DxfUnits VerticalUnits { get; set; }
        public DxfVector UpDirection { get; set; }
        public DxfScaleEstimationMethod ScaleEstimationMethod { get; set; }
        public bool UseSeaLevelCorrection { get; set; }
        public double UserSpecifiedScaleFactor { get; set; }
        public double SeaLevelElevation { get; set; }
        public double CoordinateProjectionRadius { get; set; }
        public string CoordinateSystemDefinition { get; set; }
        public string GeoRssTag { get; set; }
        public string ObservationFromTag { get; set; }
        public string ObservationToTag { get; set; }
        public string ObservationCoverageTag { get; set; }
        private int _geoMeshPointCount { get; set; }
        private IList<double> _sourceMeshXPoints { get; set; }
        private IList<double> _sourceMeshYPoints { get; set; }
        private IList<double> _destinationMeshXPoints { get; set; }
        private IList<double> _destinationMeshYPoints { get; set; }
        private int _facesCount { get; set; }
        private IList<int> _facePointIndexX { get; set; }
        private IList<int> _facePointIndexY { get; set; }
        private IList<int> _facePointIndexZ { get; set; }

        public DxfGeoData()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.Version = DxfGeoDataVersion.R2009;
            this.CoordinateType = DxfDesignCoordinateType.Unknown;
            this.HostBlockhandle = 0u;
            this.DesignPoint = DxfPoint.Origin;
            this.ReferencePoint = DxfPoint.Origin;
            this.NorthVector = DxfVector.ZAxis;
            this.HorizontalUnitScale = 1.0;
            this.VerticalUnitScale = 1.0;
            this.HorizontalUnits = DxfUnits.Unitless;
            this.VerticalUnits = DxfUnits.Unitless;
            this.UpDirection = DxfVector.ZAxis;
            this.ScaleEstimationMethod = DxfScaleEstimationMethod.None;
            this.UseSeaLevelCorrection = false;
            this.UserSpecifiedScaleFactor = 1.0;
            this.SeaLevelElevation = 0.0;
            this.CoordinateProjectionRadius = 0.0;
            this.CoordinateSystemDefinition = null;
            this.GeoRssTag = null;
            this.ObservationFromTag = null;
            this.ObservationToTag = null;
            this.ObservationCoverageTag = null;
            this._geoMeshPointCount = 0;
            this._sourceMeshXPoints = new List<double>();
            this._sourceMeshYPoints = new List<double>();
            this._destinationMeshXPoints = new List<double>();
            this._destinationMeshYPoints = new List<double>();
            this._facesCount = 0;
            this._facePointIndexX = new List<int>();
            this._facePointIndexY = new List<int>();
            this._facePointIndexZ = new List<int>();
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(90, (int)(this.Version)));
            pairs.Add(new DxfCodePair(70, (short)(this.CoordinateType)));
            if (this.HostBlockhandle != 0u)
            {
                pairs.Add(new DxfCodePair(330, UIntHandle(this.HostBlockhandle)));
            }

            pairs.Add(new DxfCodePair(10, DesignPoint?.X ?? default(double)));
            pairs.Add(new DxfCodePair(20, DesignPoint?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(30, DesignPoint?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(11, ReferencePoint?.X ?? default(double)));
            pairs.Add(new DxfCodePair(21, ReferencePoint?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(31, ReferencePoint?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(12, NorthVector?.X ?? default(double)));
            pairs.Add(new DxfCodePair(22, NorthVector?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(40, (this.HorizontalUnitScale)));
            pairs.Add(new DxfCodePair(41, (this.VerticalUnitScale)));
            pairs.Add(new DxfCodePair(91, (int)(this.HorizontalUnits)));
            pairs.Add(new DxfCodePair(92, (int)(this.VerticalUnits)));
            pairs.Add(new DxfCodePair(210, UpDirection?.X ?? default(double)));
            pairs.Add(new DxfCodePair(220, UpDirection?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(230, UpDirection?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(95, (int)(this.ScaleEstimationMethod)));
            pairs.Add(new DxfCodePair(294, (this.UseSeaLevelCorrection)));
            pairs.Add(new DxfCodePair(141, (this.UserSpecifiedScaleFactor)));
            pairs.Add(new DxfCodePair(142, (this.SeaLevelElevation)));
            pairs.Add(new DxfCodePair(143, (this.CoordinateProjectionRadius)));
            pairs.Add(new DxfCodePair(301, (this.CoordinateSystemDefinition)));
            pairs.Add(new DxfCodePair(302, (this.GeoRssTag)));
            pairs.Add(new DxfCodePair(305, (this.ObservationFromTag)));
            pairs.Add(new DxfCodePair(306, (this.ObservationToTag)));
            pairs.Add(new DxfCodePair(307, (this.ObservationCoverageTag)));
            pairs.Add(new DxfCodePair(93, GeoMeshPoints.Count));
            foreach (var item in GeoMeshPoints)
            {
                pairs.Add(new DxfCodePair(13, item.SourcePoint.X));
                pairs.Add(new DxfCodePair(23, item.SourcePoint.Y));
                pairs.Add(new DxfCodePair(14, item.DestinationPoint.X));
                pairs.Add(new DxfCodePair(24, item.DestinationPoint.Y));
            }

            pairs.Add(new DxfCodePair(96, FaceIndices.Count));
            foreach (var item in FaceIndices)
            {
                pairs.Add(new DxfCodePair(97, item.X));
                pairs.Add(new DxfCodePair(98, item.Y));
                pairs.Add(new DxfCodePair(99, item.Z));
            }

        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 210:
                    this.UpDirection.X = pair.DoubleValue;
                    break;
                case 220:
                    this.UpDirection.Y = pair.DoubleValue;
                    break;
                case 230:
                    this.UpDirection.Z = pair.DoubleValue;
                    break;
                case 12:
                    this.NorthVector.X = pair.DoubleValue;
                    break;
                case 22:
                    this.NorthVector.Y = pair.DoubleValue;
                    break;
                case 11:
                    this.ReferencePoint.X = pair.DoubleValue;
                    break;
                case 21:
                    this.ReferencePoint.Y = pair.DoubleValue;
                    break;
                case 31:
                    this.ReferencePoint.Z = pair.DoubleValue;
                    break;
                case 10:
                    this.DesignPoint.X = pair.DoubleValue;
                    break;
                case 20:
                    this.DesignPoint.Y = pair.DoubleValue;
                    break;
                case 30:
                    this.DesignPoint.Z = pair.DoubleValue;
                    break;
                case 13:
                    this._sourceMeshXPoints.Add((pair.DoubleValue));
                    break;
                case 14:
                    this._destinationMeshXPoints.Add((pair.DoubleValue));
                    break;
                case 23:
                    this._sourceMeshYPoints.Add((pair.DoubleValue));
                    break;
                case 24:
                    this._destinationMeshYPoints.Add((pair.DoubleValue));
                    break;
                case 40:
                    this.HorizontalUnitScale = (pair.DoubleValue);
                    break;
                case 41:
                    this.VerticalUnitScale = (pair.DoubleValue);
                    break;
                case 70:
                    this.CoordinateType = (DxfDesignCoordinateType)(pair.ShortValue);
                    break;
                case 90:
                    this.Version = (DxfGeoDataVersion)(pair.IntegerValue);
                    break;
                case 91:
                    this.HorizontalUnits = (DxfUnits)(pair.IntegerValue);
                    break;
                case 92:
                    this.VerticalUnits = (DxfUnits)(pair.IntegerValue);
                    break;
                case 93:
                    this._geoMeshPointCount = (pair.IntegerValue);
                    break;
                case 95:
                    this.ScaleEstimationMethod = (DxfScaleEstimationMethod)(pair.IntegerValue);
                    break;
                case 96:
                    this._facesCount = (pair.IntegerValue);
                    break;
                case 97:
                    this._facePointIndexX.Add((pair.IntegerValue));
                    break;
                case 98:
                    this._facePointIndexY.Add((pair.IntegerValue));
                    break;
                case 99:
                    this._facePointIndexZ.Add((pair.IntegerValue));
                    break;
                case 141:
                    this.UserSpecifiedScaleFactor = (pair.DoubleValue);
                    break;
                case 142:
                    this.SeaLevelElevation = (pair.DoubleValue);
                    break;
                case 143:
                    this.CoordinateProjectionRadius = (pair.DoubleValue);
                    break;
                case 294:
                    this.UseSeaLevelCorrection = (pair.BoolValue);
                    break;
                case 301:
                    this.CoordinateSystemDefinition = (pair.StringValue);
                    break;
                case 302:
                    this.GeoRssTag = (pair.StringValue);
                    break;
                case 305:
                    this.ObservationFromTag = (pair.StringValue);
                    break;
                case 306:
                    this.ObservationToTag = (pair.StringValue);
                    break;
                case 307:
                    this.ObservationCoverageTag = (pair.StringValue);
                    break;
                case 330:
                    this.HostBlockhandle = UIntHandle(pair.StringValue);
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }

}
