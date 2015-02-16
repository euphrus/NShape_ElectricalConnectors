using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class WireWrap : RectangleFBase
	{

		#region Constructors

		protected internal WireWrap(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			WidthF = 20F;
			HeightF = 2F;
		}

		protected internal WireWrap(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			WidthF = 20F;
			HeightF = 2F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new WireWrap(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.AddRectangle(new RectangleF(-10F * Scale * _pixelToMmMultiple, 1F * -1 * Scale * _pixelToMmMultiple, 20F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
				Path.AddRectangle(new RectangleF(-9.215F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
				Path.AddRectangle(new RectangleF(-6.675F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
				Path.AddRectangle(new RectangleF(-4.135F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
				Path.AddRectangle(new RectangleF(-1.595F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
				Path.AddRectangle(new RectangleF(0.945F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
				Path.AddRectangle(new RectangleF(3.485F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
				Path.AddRectangle(new RectangleF(6.025F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
				Path.AddRectangle(new RectangleF(8.565F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
				Path.AddArc(-9.215F * Scale * _pixelToMmMultiple, 0.3175F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-6.675F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-4.135F * Scale * _pixelToMmMultiple, 0.3255F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-1.595F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(0.945F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(3.485F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(6.025F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(8.565F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("WireWrap", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new WireWrap(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.WireWrap);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			WidthF = 20F;
			HeightF = 2F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int WireWrapMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.WireWrapMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.WireWrapMiddleCenter);
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
				case ControlPointIds.WireWrapMiddleCenter:
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
