using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class Blade : RectangleFBase
	{

		#region Constructors

		protected internal Blade(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			WidthF = 4.5F;
			HeightF = 19.5F;
		}

		protected internal Blade(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			WidthF = 4.5F;
			HeightF = 19.5F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new Blade(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.StartFigure();
				Path.AddLines(new PointF[]{new PointF(2F * Scale * _pixelToMmMultiple, -9.75F * -1 * Scale * _pixelToMmMultiple), new PointF(-2.25F * Scale * _pixelToMmMultiple, -9.75F * -1 * Scale * _pixelToMmMultiple), new PointF(-2.25F * Scale * _pixelToMmMultiple, -4.75F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.85F * Scale * _pixelToMmMultiple, -3.75F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.85F * Scale * _pixelToMmMultiple, 1.25F * -1 * Scale * _pixelToMmMultiple)});
				Path.AddArc(-1.4F * Scale * _pixelToMmMultiple, 5.25F * -1 * Scale * _pixelToMmMultiple, 2.8F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 100F, 80F);
				Path.AddLines(new PointF[]{new PointF(-1.4F * Scale * _pixelToMmMultiple, 3.25F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.4F * Scale * _pixelToMmMultiple, 9.75F * -1 * Scale * _pixelToMmMultiple), new PointF(1.4F * Scale * _pixelToMmMultiple, 9.75F * -1 * Scale * _pixelToMmMultiple), new PointF(1.4F * Scale * _pixelToMmMultiple, 3.25F * -1 * Scale * _pixelToMmMultiple)});
				Path.AddArc(-1.4F * Scale * _pixelToMmMultiple, 5.25F * -1 * Scale * _pixelToMmMultiple, 2.8F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 360F, 80F);
				Path.AddLines(new PointF[]{new PointF(0.85F * Scale * _pixelToMmMultiple, 1.25F * -1 * Scale * _pixelToMmMultiple), new PointF(0.85F * Scale * _pixelToMmMultiple, -3.75F * -1 * Scale * _pixelToMmMultiple), new PointF(2.25F * Scale * _pixelToMmMultiple, -4.75F * -1 * Scale * _pixelToMmMultiple), new PointF(2.25F * Scale * _pixelToMmMultiple, -9.75F * -1 * Scale * _pixelToMmMultiple)});
				Path.CloseFigure();
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("Blade", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new Blade(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.Blade);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			WidthF = 4.5F;
			HeightF = 19.5F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int BladeMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.BladeMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.BladeMiddleCenter);
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
				case ControlPointIds.BladeMiddleCenter:
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
