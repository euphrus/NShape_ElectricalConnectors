using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class IEC60320_C05 : RectangleFBase
	{

		#region Constructors

		protected internal IEC60320_C05(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			WidthF = 22F;
			HeightF = 17F;
		}

		protected internal IEC60320_C05(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			WidthF = 22F;
			HeightF = 17F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new IEC60320_C05(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.AddArc(-11F * Scale * _pixelToMmMultiple, 8.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 180F, 90F);
				Path.AddArc(8.5F * Scale * _pixelToMmMultiple, 8.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 270F, 90F);
				Path.AddArc(8.5F * Scale * _pixelToMmMultiple, -6F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 360F, 90F);
				Path.AddArc(-11F * Scale * _pixelToMmMultiple, -6F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 90F, 90F);
				Path.CloseFigure();
				Path.AddArc(-1.9F * Scale * _pixelToMmMultiple, 4.4F * -1 * Scale * _pixelToMmMultiple, 3.8F * Scale * _pixelToMmMultiple, 3.8F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-1.65F * Scale * _pixelToMmMultiple, 4.15F * -1 * Scale * _pixelToMmMultiple, 3.3F * Scale * _pixelToMmMultiple, 3.3F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-6.45F * Scale * _pixelToMmMultiple, -0.55F * -1 * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-6.2F * Scale * _pixelToMmMultiple, -0.8F * -1 * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(3.55F * Scale * _pixelToMmMultiple, -0.55F * -1 * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(3.8F * Scale * _pixelToMmMultiple, -0.8F * -1 * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-4.5F * Scale * _pixelToMmMultiple, 7F * -1 * Scale * _pixelToMmMultiple, 9F * Scale * _pixelToMmMultiple, 9F * Scale * _pixelToMmMultiple, 175F, 190F);
				Path.AddArc(0.9F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, 8.2F * Scale * _pixelToMmMultiple, 8.2F * Scale * _pixelToMmMultiple, 263F, 277F);
				Path.AddArc(-9.1F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, 8.2F * Scale * _pixelToMmMultiple, 8.2F * Scale * _pixelToMmMultiple, 360F, 277F);
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("IEC60320_C05", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new IEC60320_C05(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.IEC60320_C05);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			WidthF = 22F;
			HeightF = 17F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int IEC60320_C05MiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.IEC60320_C05MiddleCenter] = Point.Empty;
		}

		public override IEnumerable<ControlPointId> GetControlPointIds(ControlPointCapabilities controlPointCapability)
		{
			List<ControlPointId> returnValue = new List<ControlPointId>();
			if ((controlPointCapability & ControlPointCapabilities.Rotate) != 0)
			{
				returnValue.Add(ControlPointIds.MiddleCenter);
				returnValue.Add(ControlPointIds.Reference);
			}
			if ((controlPointCapability & ControlPointCapabilities.Connect) != 0)
			{
				returnValue.Add(ControlPointIds.IEC60320_C05MiddleCenter);
			}
			return returnValue;
		}

		public override Point GetControlPointPosition(ControlPointId controlPointId)
		{
			return ControlPoints[controlPointId];
		}

		public override bool HasControlPointCapability(ControlPointId controlPointId, ControlPointCapabilities controlPointCapability)
		{
			bool returnValue = false;
			switch (controlPointId)
			{
				case ControlPointIds.MiddleCenter:
				case ControlPointId.Reference:
					returnValue = (controlPointCapability & ControlPointCapabilities.Rotate) != 0;
					break;
				case ControlPointIds.IEC60320_C05MiddleCenter:
					returnValue = (controlPointCapability & ControlPointCapabilities.Connect) != 0;
					break;
			}
			return returnValue;
		}

		private const int _controlPointCount = 3;
		protected override int ControlPointCount
		{
			get
			{
				return _controlPointCount;
			}
		}

		#endregion ControlPoints

	}
}
