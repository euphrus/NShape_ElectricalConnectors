using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class EightP8C : RectangleFBase
	{

		#region Constructors

		protected internal EightP8C(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 11.83F;
			Height = 9.36F;
		}

		protected internal EightP8C(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 11.83F;
			Height = 9.36F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new EightP8C(Type, Template);
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
				Path.AddArc(-5.915F * Scale, -4.18F * -1 * Scale, 0.5F * Scale, 0.5F * Scale, 90F, 90F);
				Path.AddLines(new PointF[]{new PointF(-5.915F * Scale, 0.68F * -1 * Scale), new PointF(-3.05F * Scale, 0.68F * -1 * Scale), new PointF(-3.05F * Scale, -0.14F * -1 * Scale), new PointF(3.05F * Scale, -0.14F * -1 * Scale), new PointF(3.05F * Scale, 0.68F * -1 * Scale), new PointF(5.915F * Scale, 0.68F * -1 * Scale)});
				Path.AddArc(5.415F * Scale, -4.18F * -1 * Scale, 0.5F * Scale, 0.5F * Scale, 360F, 90F);
				Path.AddLines(new PointF[]{new PointF(3.75F * Scale, -4.68F * -1 * Scale), new PointF(3.75F * Scale, -4.18F * -1 * Scale), new PointF(3.25F * Scale, -4.18F * -1 * Scale), new PointF(3.25F * Scale, -4.68F * -1 * Scale), new PointF(2.75F * Scale, -4.68F * -1 * Scale), new PointF(2.75F * Scale, -4.18F * -1 * Scale), new PointF(2.25F * Scale, -4.18F * -1 * Scale), new PointF(2.25F * Scale, -4.68F * -1 * Scale), new PointF(1.75F * Scale, -4.68F * -1 * Scale), new PointF(1.75F * Scale, -4.18F * -1 * Scale), new PointF(1.25F * Scale, -4.18F * -1 * Scale), new PointF(1.25F * Scale, -4.68F * -1 * Scale), new PointF(0.75F * Scale, -4.68F * -1 * Scale), new PointF(0.75F * Scale, -4.18F * -1 * Scale), new PointF(0.25F * Scale, -4.18F * -1 * Scale), new PointF(0.25F * Scale, -4.68F * -1 * Scale), new PointF(-0.25F * Scale, -4.68F * -1 * Scale), new PointF(-0.25F * Scale, -4.18F * -1 * Scale), new PointF(-0.75F * Scale, -4.18F * -1 * Scale), new PointF(-0.75F * Scale, -4.68F * -1 * Scale), new PointF(-1.25F * Scale, -4.68F * -1 * Scale), new PointF(-1.25F * Scale, -4.18F * -1 * Scale), new PointF(-1.75F * Scale, -4.18F * -1 * Scale), new PointF(-1.75F * Scale, -4.68F * -1 * Scale), new PointF(-2.25F * Scale, -4.68F * -1 * Scale), new PointF(-2.25F * Scale, -4.18F * -1 * Scale), new PointF(-2.75F * Scale, -4.18F * -1 * Scale), new PointF(-2.75F * Scale, -4.68F * -1 * Scale), new PointF(-3.25F * Scale, -4.68F * -1 * Scale), new PointF(-3.25F * Scale, -4.18F * -1 * Scale), new PointF(-3.75F * Scale, -4.18F * -1 * Scale), new PointF(-3.75F * Scale, -4.68F * -1 * Scale)});
				Path.CloseFigure();
				Path.StartFigure();
				Path.AddArc(-5.915F * Scale, 1.925F * -1 * Scale, 0.5F * Scale, 0.5F * Scale, 180F, 90F);
				Path.AddLines(new PointF[]{new PointF(-3.05F * Scale, 1.925F * -1 * Scale), new PointF(-3.05F * Scale, 0.68F * -1 * Scale), new PointF(-5.915F * Scale, 0.68F * -1 * Scale)});
				Path.CloseFigure();
				Path.StartFigure();
				Path.AddArc(5.415F * Scale, 1.925F * -1 * Scale, 0.5F * Scale, 0.5F * Scale, 270F, 90F);
				Path.AddLines(new PointF[]{new PointF(5.915F * Scale, 0.68F * -1 * Scale), new PointF(3.05F * Scale, 0.68F * -1 * Scale), new PointF(3.05F * Scale, 1.925F * -1 * Scale)});
				Path.CloseFigure();
				Path.AddLines(new PointF[]{new PointF(-3.05F * Scale, -0.14F * -1 * Scale), new PointF(-3.05F * Scale, 2.91F * -1 * Scale), new PointF(-1.625F * Scale, 2.91F * -1 * Scale), new PointF(-1.625F * Scale, 2.34F * -1 * Scale), new PointF(1.625F * Scale, 2.34F * -1 * Scale), new PointF(1.625F * Scale, 2.91F * -1 * Scale), new PointF(3.05F * Scale, 2.91F * -1 * Scale), new PointF(3.05F * Scale, -0.14F * -1 * Scale)});
				Path.CloseFigure();
				Path.AddRectangle(new RectangleF(-1.625F * Scale, 4.68F * -1 * Scale, 3.25F * Scale, 2.34F * Scale));
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("EightP8C", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new EightP8C(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.EightP8C);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 11.83F;
			Height = 9.36F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int EightP8CMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.EightP8CMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.EightP8CMiddleCenter);
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
				case ControlPointIds.EightP8CMiddleCenter:
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
