using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class LC : RectangleFBase
	{

		#region Constructors

		protected internal LC(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 6.02F;
			Height = 6.02F;
		}

		protected internal LC(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 6.02F;
			Height = 6.02F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new LC(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.StartFigure();
				Path.AddLines(new PointF[]{new PointF(-2.2F * Scale * _pixelToMmMultiple, -1.9F * -1 * Scale * _pixelToMmMultiple), new PointF(-2.2F * Scale * _pixelToMmMultiple, 1.9F * -1 * Scale * _pixelToMmMultiple)});
				Path.AddBezier(-2.2F * Scale * _pixelToMmMultiple, 1.9F * -1 * Scale * _pixelToMmMultiple, -2.2F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple, -1.9F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple, -1.9F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple);
				Path.AddLines(new PointF[]{new PointF(-1.59F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.59F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple), new PointF(1.59F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple), new PointF(1.59F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple)});
				Path.AddBezier(1.9F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple, 1.9F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple, 2.2F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple, 2.2F * Scale * _pixelToMmMultiple, 1.9F * -1 * Scale * _pixelToMmMultiple);
				Path.AddLines(new PointF[]{new PointF(2.2F * Scale * _pixelToMmMultiple, 1.9F * -1 * Scale * _pixelToMmMultiple), new PointF(2.2F * Scale * _pixelToMmMultiple, -1.9F * -1 * Scale * _pixelToMmMultiple)});
				Path.AddBezier(2.2F * Scale * _pixelToMmMultiple, -1.9F * -1 * Scale * _pixelToMmMultiple, 2.2F * Scale * _pixelToMmMultiple, -1.9F * -1 * Scale * _pixelToMmMultiple, 2.2F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple, 1.9F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple);
				Path.AddLines(new PointF[]{new PointF(1.9F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.9F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple)});
				Path.AddBezier(-1.9F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple, -1.9F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple, -2.2F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple, -2.2F * Scale * _pixelToMmMultiple, -1.9F * -1 * Scale * _pixelToMmMultiple);
				Path.CloseFigure();
				Path.StartFigure();
				Path.AddLines(new PointF[]{new PointF(-2.1F * Scale * _pixelToMmMultiple, -1.8F * -1 * Scale * _pixelToMmMultiple)});
				Path.AddBezier(-2.1F * Scale * _pixelToMmMultiple, 1.8F * -1 * Scale * _pixelToMmMultiple, -2.1F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, -1.8F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, -1.8F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple);
				Path.AddLines(new PointF[]{new PointF(-1.8F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple), new PointF(1.8F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple)});
				Path.AddBezier(1.8F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, 2.1F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, 2.1F * Scale * _pixelToMmMultiple, 1.8F * -1 * Scale * _pixelToMmMultiple, 2.1F * Scale * _pixelToMmMultiple, 1.8F * -1 * Scale * _pixelToMmMultiple);
				Path.AddLines(new PointF[]{new PointF(2.1F * Scale * _pixelToMmMultiple, 1.2F * -1 * Scale * _pixelToMmMultiple), new PointF(2.1F * Scale * _pixelToMmMultiple, -1.2F * -1 * Scale * _pixelToMmMultiple)});
				Path.AddBezier(2.1F * Scale * _pixelToMmMultiple, -1.8F * -1 * Scale * _pixelToMmMultiple, 2.1F * Scale * _pixelToMmMultiple, -1.8F * -1 * Scale * _pixelToMmMultiple, 2.1F * Scale * _pixelToMmMultiple, -2.1F * -1 * Scale * _pixelToMmMultiple, 1.8F * Scale * _pixelToMmMultiple, -2.1F * -1 * Scale * _pixelToMmMultiple);
				Path.AddLines(new PointF[]{new PointF(1.8F * Scale * _pixelToMmMultiple, -2.1F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.8F * Scale * _pixelToMmMultiple, -2.1F * -1 * Scale * _pixelToMmMultiple)});
				Path.AddBezier(-1.8F * Scale * _pixelToMmMultiple, -2.1F * -1 * Scale * _pixelToMmMultiple, -2.1F * Scale * _pixelToMmMultiple, -2.1F * -1 * Scale * _pixelToMmMultiple, -2.1F * Scale * _pixelToMmMultiple, -1.8F * -1 * Scale * _pixelToMmMultiple, -2.1F * Scale * _pixelToMmMultiple, -1.8F * -1 * Scale * _pixelToMmMultiple);
				Path.CloseFigure();
				Path.StartFigure();
				Path.AddRectangle(new RectangleF(-1.6F * Scale * _pixelToMmMultiple, 2.39F * -1 * Scale * _pixelToMmMultiple, 3.2F * Scale * _pixelToMmMultiple, 0.29F * Scale * _pixelToMmMultiple));
				Path.CloseFigure();
				Path.StartFigure();
				Path.AddRectangle(new RectangleF(-1.6F * Scale * _pixelToMmMultiple, 2.59F * -1 * Scale * _pixelToMmMultiple, 3.2F * Scale * _pixelToMmMultiple, 0.2F * Scale * _pixelToMmMultiple));
				Path.CloseFigure();
				Path.StartFigure();
				Path.AddArc(-0.625F * Scale * _pixelToMmMultiple, 0.625F * -1 * Scale * _pixelToMmMultiple, 1.25F * Scale * _pixelToMmMultiple, 1.25F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.CloseFigure();
				Path.StartFigure();
				Path.AddArc(-0.3F * Scale * _pixelToMmMultiple, 0.3F * -1 * Scale * _pixelToMmMultiple, 0.6F * Scale * _pixelToMmMultiple, 0.6F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.CloseFigure();
				Path.StartFigure();
				Path.AddArc(-1.5F * Scale * _pixelToMmMultiple, 1.5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.CloseFigure();
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("LC", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new LC(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.LC);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 6.02F;
			Height = 6.02F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int LCMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.LCMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.LCMiddleCenter);
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
				case ControlPointIds.LCMiddleCenter:
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
