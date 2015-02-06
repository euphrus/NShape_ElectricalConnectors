using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class IEC60320_C17 : RectangleFBase
	{

		#region Constructors

		protected internal IEC60320_C17(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 30F;
			Height = 22F;
		}

		protected internal IEC60320_C17(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 30F;
			Height = 22F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new IEC60320_C17(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.AddRectangle(new RectangleF(-15F * Scale * _pixelToMmMultiple, 11F * -1 * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 22F * Scale * _pixelToMmMultiple));
				Path.AddLines(new PointF[]{new PointF(-11.5F * Scale * _pixelToMmMultiple, 2.5F * -1 * Scale * _pixelToMmMultiple), new PointF(-7.681623F * Scale * _pixelToMmMultiple, 8F * -1 * Scale * _pixelToMmMultiple), new PointF(7.681623F * Scale * _pixelToMmMultiple, 8F * -1 * Scale * _pixelToMmMultiple), new PointF(11.5F * Scale * _pixelToMmMultiple, 2.5F * -1 * Scale * _pixelToMmMultiple)});
				Path.AddArc(8F * Scale * _pixelToMmMultiple, -4.5F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 360F, 90F);
				Path.AddArc(-11.5F * Scale * _pixelToMmMultiple, -4.5F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 90F, 90F);
				Path.CloseFigure();
				Path.AddRectangle(new RectangleF(-8.25F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple));
				Path.AddRectangle(new RectangleF(-1.25F * Scale * _pixelToMmMultiple, 4.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple));
				Path.AddRectangle(new RectangleF(5.75F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple));
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("IEC60320_C17", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new IEC60320_C17(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.IEC60320_C17);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 30F;
			Height = 22F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int IEC60320_C17MiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.IEC60320_C17MiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.IEC60320_C17MiddleCenter);
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
				case ControlPointIds.IEC60320_C17MiddleCenter:
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
