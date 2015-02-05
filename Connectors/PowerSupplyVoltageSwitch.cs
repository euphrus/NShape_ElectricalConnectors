using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class PowerSupplyVoltageSwitch : RectangleFBase
	{

		#region Constructors

		protected internal PowerSupplyVoltageSwitch(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 7F;
			Height = 12F;
		}

		protected internal PowerSupplyVoltageSwitch(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 7F;
			Height = 12F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new PowerSupplyVoltageSwitch(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.AddRectangle(new RectangleF(-3.5F * Scale, 6F * -1 * Scale, 7F * Scale, 12F * Scale));
				Path.AddRectangle(new RectangleF(-2.5F * Scale, 5F * -1 * Scale, 5F * Scale, 10F * Scale));
				Path.AddRectangle(new RectangleF(-2F * Scale, -1F * -1 * Scale, 0.4F * Scale, 3F * Scale));
				Path.AddRectangle(new RectangleF(-0.8F * Scale, -1F * -1 * Scale, 0.4F * Scale, 3F * Scale));
				Path.StartFigure();
				Path.AddLines(new PointF[]{new PointF(0.5F * Scale, -1F * -1 * Scale), new PointF(1.7F * Scale, -1F * -1 * Scale), new PointF(1.7F * Scale, -1.3F * -1 * Scale), new PointF(0.6F * Scale, -1.3F * -1 * Scale), new PointF(0.6F * Scale, -2.2F * -1 * Scale)});
				Path.AddArc(0F * Scale, -2.18F * -1 * Scale, 1.8F * Scale, 1.8F * Scale, 270F, 180F);
				Path.AddLines(new PointF[]{new PointF(0.3F * Scale, -4F * -1 * Scale), new PointF(0.3F * Scale, -1F * -1 * Scale)});
				Path.CloseFigure();
				Path.AddArc(0.1F * Scale, -2.38F * -1 * Scale, 1.4F * Scale, 1.4F * Scale, 270F, 180F);
				Path.AddRectangle(new RectangleF(0.3F * Scale, -2.4F * -1 * Scale, 0.5F * Scale, 1.4F * Scale));
				Path.AddArc(-1.9F * Scale, 3.8F * -1 * Scale, 1.1F * Scale, 1.1F * Scale, 180F, 180F);
				Path.AddLines(new PointF[]{new PointF(-2.1F * Scale, 1.3F * -1 * Scale), new PointF(-2.1F * Scale, 1F * -1 * Scale), new PointF(-0.6F * Scale, 1F * -1 * Scale), new PointF(-0.6F * Scale, 1.3F * -1 * Scale), new PointF(-1.9F * Scale, 1.3F * -1 * Scale)});
				Path.AddArc(-2.1F * Scale, 4F * -1 * Scale, 1.5F * Scale, 1.5F * Scale, 0F, -180F);
				Path.CloseFigure();
				Path.AddLines(new PointF[]{new PointF(-0.5F * Scale, 3.7F * -1 * Scale), new PointF(-0.5F * Scale, 3.99F * -1 * Scale)});
				Path.AddArc(-1F * Scale, 4F * -1 * Scale, 1.8F * Scale, 1.8F * Scale, 280F, 120F);
				Path.AddArc(-1F * Scale, 2.8F * -1 * Scale, 1.8F * Scale, 1.8F * Scale, 318F, 130F);
				Path.AddLines(new PointF[]{new PointF(-0.5F * Scale, 1F * -1 * Scale), new PointF(-0.5F * Scale, 1.3F * -1 * Scale)});
				Path.AddArc(-0.7F * Scale, 2.5F * -1 * Scale, 1.2F * Scale, 1.2F * Scale, 90F, -180F);
				Path.AddArc(-0.7F * Scale, 3.7F * -1 * Scale, 1.2F * Scale, 1.2F * Scale, 90F, -180F);
				Path.CloseFigure();
				Path.AddArc(0.9F * Scale, 4F * -1 * Scale, 1.5F * Scale, 3F * Scale, 180F, 360F);
				Path.AddArc(1.1F * Scale, 3.8F * -1 * Scale, 1.1F * Scale, 2.6F * Scale, 180F, 360F);
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("PowerSupplyVoltageSwitch", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new PowerSupplyVoltageSwitch(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.PowerSupplyVoltageSwitch);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 7F;
			Height = 12F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int PowerSupplyVoltageSwitchMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.PowerSupplyVoltageSwitchMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.PowerSupplyVoltageSwitchMiddleCenter);
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
				case ControlPointIds.PowerSupplyVoltageSwitchMiddleCenter:
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
