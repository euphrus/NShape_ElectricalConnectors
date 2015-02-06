using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class FourP4C : RectangleFBase
	{

		#region Constructors

		protected internal FourP4C(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 7.62F;
			Height = 9.37F;
		}

		protected internal FourP4C(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 7.62F;
			Height = 9.37F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new FourP4C(Type, Template);
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
				Path.AddArc(-3.81F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 90F, 90F);
				Path.AddLines(new PointF[]{new PointF(-3.81F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.05F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.05F * Scale * _pixelToMmMultiple, -0.14F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, -0.14F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(3.81F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple)});
				Path.AddArc(3.31F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 360F, 90F);
				Path.AddLines(new PointF[]{new PointF(2.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(1.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(1.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(1.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(1.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(0.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(0.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(0.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(0.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-2.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple)});
				Path.CloseFigure();
				Path.StartFigure();
				Path.AddArc(-3.81F * Scale * _pixelToMmMultiple, 1.925F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 180F, 90F);
				Path.AddLines(new PointF[]{new PointF(-3.05F * Scale * _pixelToMmMultiple, 1.925F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.05F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.81F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple)});
				Path.CloseFigure();
				Path.StartFigure();
				Path.AddArc(3.31F * Scale * _pixelToMmMultiple, 1.925F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 270F, 90F);
				Path.AddLines(new PointF[]{new PointF(3.81F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, 1.925F * -1 * Scale * _pixelToMmMultiple)});
				Path.CloseFigure();
				Path.AddLines(new PointF[]{new PointF(-3.05F * Scale * _pixelToMmMultiple, -0.14F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.05F * Scale * _pixelToMmMultiple, 2.91F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.625F * Scale * _pixelToMmMultiple, 2.91F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.625F * Scale * _pixelToMmMultiple, 2.34F * -1 * Scale * _pixelToMmMultiple), new PointF(1.625F * Scale * _pixelToMmMultiple, 2.34F * -1 * Scale * _pixelToMmMultiple), new PointF(1.625F * Scale * _pixelToMmMultiple, 2.91F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, 2.91F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, -0.14F * -1 * Scale * _pixelToMmMultiple)});
				Path.CloseFigure();
				Path.AddRectangle(new RectangleF(-1.625F * Scale * _pixelToMmMultiple, 4.68F * -1 * Scale * _pixelToMmMultiple, 3.25F * Scale * _pixelToMmMultiple, 2.34F * Scale * _pixelToMmMultiple));
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("FourP4C", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new FourP4C(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.FourP4C);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 7.62F;
			Height = 9.37F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int FourP4CMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.FourP4CMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.FourP4CMiddleCenter);
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
				case ControlPointIds.FourP4CMiddleCenter:
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
