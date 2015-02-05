using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class IEC60320_C02 : RectangleFBase
	{

		#region Constructors

		protected internal IEC60320_C02(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 19F;
			Height = 13.5F;
		}

		protected internal IEC60320_C02(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 19F;
			Height = 13.5F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new IEC60320_C02(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.AddRectangle(new RectangleF(-9.5F * Scale, 6.75F * -1 * Scale, 19F * Scale, 13.5F * Scale));
				Path.StartFigure();
				Path.AddArc(-7.2F * Scale, 4.2F * -1 * Scale, 8.4F * Scale, 8.4F * Scale, 90F, 180F);
				Path.AddArc(-1.2F * Scale, 4.2F * -1 * Scale, 8.4F * Scale, 8.4F * Scale, 270F, 180F);
				Path.CloseFigure();
				Path.StartFigure();
				Path.AddArc(-7.2F * Scale, 4.2F * -1 * Scale, 8.4F * Scale, 8.4F * Scale, 90F, 180F);
				Path.AddArc(-1.2F * Scale, 4.2F * -1 * Scale, 8.4F * Scale, 8.4F * Scale, 270F, 180F);
				Path.StartFigure();
				Path.AddArc(-4.55F * Scale, 1.25F * -1 * Scale, 2.5F * Scale, 2.5F * Scale, 180F, 360F);
				Path.StartFigure();
				Path.AddArc(2.05F * Scale, 1.25F * -1 * Scale, 2.5F * Scale, 2.5F * Scale, 180F, 360F);
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("IEC60320_C02", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new IEC60320_C02(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.IEC60320_C02);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 19F;
			Height = 13.5F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int IEC60320_C02MiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.IEC60320_C02MiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.IEC60320_C02MiddleCenter);
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
				case ControlPointIds.IEC60320_C02MiddleCenter:
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